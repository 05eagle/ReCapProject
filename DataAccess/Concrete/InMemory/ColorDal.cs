using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class ColorDal
    {
        List<Color> _colors;

        public ColorDal()
        {
            _colors = new List<Color>()
            {
                new Color(){ ColorId = 1, ColorName = "Siyah"},
              
            };
        }

        public void Add(Color entity)
        {
            _colors.Add(entity);
        }

        public void Delete(int id)
        {
            var colorToDelete = _colors.SingleOrDefault(c => c.ColorId == id);
            _colors.Remove(colorToDelete);
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public void Update(Color entity)
        {
            var colorToUpdate = _colors.SingleOrDefault(c => c.ColorId == entity.ColorId);
            colorToUpdate.ColorName = entity.ColorName;
        }
    }
}
