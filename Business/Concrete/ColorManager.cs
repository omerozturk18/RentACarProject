﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Operation Successful.");
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Operation Successful.");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(b => b.ColorId == colorId);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Operation Successful.");
        }
    }
}