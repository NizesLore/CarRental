﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,CarRentalContext>,ICarDal
    {
        //public void Add(Car entity)
        //{
        //    using (CarRentalContext context= new CarRentalContext())
        //    {
        //        var addedEntity = context.Entry(entity);   // Referansı yakala
        //        addedEntity.State = EntityState.Added;     // O aslında eklenecek bir nesne
        //        context.SaveChanges();                     // Şimdi EKLE
        //    }
        //}

        //public void Delete(Car entity)
        //{
        //    using (CarRentalContext context = new CarRentalContext())
        //    {
        //        var deletedEntity = context.Entry(entity);
        //        deletedEntity.State = EntityState.Deleted;     
        //        context.SaveChanges();                 
        //    }
        //}

        //public Car Get( Expression <Func <Car,bool>> filter)
        //{
        //    using (CarRentalContext context= new CarRentalContext())
        //    {
        //       return context.Set<Car>().SingleOrDefault(filter);
        //    }
        //}

        //public List<Car> GetAll (Expression < Func < Car,bool>> filter = null)
        //{
        //    using (CarRentalContext context= new CarRentalContext())
        //    {
        //        return filter == null
        //            ? context.Set<Car>().ToList()
        //            : context.Set<Car>().Where(filter).ToList();

        //    }
        //}

        //public void Update(Car entity)
        //{
        //    using (CarRentalContext context = new CarRentalContext())
        //    {
        //        var updatedEntity = context.Entry(entity);
        //        updatedEntity.State = EntityState.Modified;     
        //        context.SaveChanges();                    
        //    }
        //}
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car,bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in filter == null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandId = b.BrandId,
                                 ColorId = cl.ColorId,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };
                return result.ToList();
                         
            }
        }
    }
}
