using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using System.Linq;
using Entities.DTOs;
using Core.Utilities.Results;
using Business.Constants;
using FluentValidation;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Aspects.Autofac.Validation;
using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Cashing;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Performance;
using System.Threading;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            if (!CheckCarColorLimit(car.ColorId).Success)
            {
                return new ErrorResult("Başarısız");
            }


            _carDal.Add(car);

            return new SuccessResult(Messages.Added);

        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            _carDal.Update(car);
            _carDal.Add(car);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }


        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Car>> GetAll()
        {
            Thread.Sleep(5000);
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.CarDetails(), Messages.Listed);
        }

        public IDataResult<Car> GetCarId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.Id==id),Messages.Listed);
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult(Messages.Updated);
        }

        private  IResult CheckCarColorLimit(int colorId)
        {
            var result = _carDal.GetAll(c => c.ColorId == colorId).Count;

            if (result>10)
            {
                return new ErrorResult("Limit aşıldı eklenemez.");
            }
            return new SuccessResult("Araba eklendi.");
        }
    }
}
