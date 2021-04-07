using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class BrandDal
    {
        List<Brand> _brands;

        public BrandDal()
        {
            _brands = new List<Brand>()
            {
                new Brand(){ BrandId = 1, BrandName = "BWM"},
               
            };
        }

        public void Add(Brand entity)
        {
            _brands.Add(entity);
        }

        public void Delete(int id)
        {
            var brandToDelete = _brands.SingleOrDefault(b => b.BrandId == id);
            _brands.Remove(brandToDelete);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public void Update(Brand entity)
        {
            var brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == entity.BrandId);
            brandToUpdate.BrandName = entity.BrandName;
        }
    }
}
