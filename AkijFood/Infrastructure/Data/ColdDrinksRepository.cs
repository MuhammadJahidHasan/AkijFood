using AkijFood.Core.Entities;
using AkijFood.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkijFood.Infrastructure.Data
{
    public class ColdDrinksRepository : IColdDrinks
    {
        private readonly AppDbContext _context;

        public ColdDrinksRepository(AppDbContext context)
        {
            this._context = context;
        }

        public ColdDrink CreateColdDrinks(ColdDrink coldDrink)
        {
            try
            {
                _context.tblColdDrinks.Add(coldDrink);
                _context.SaveChanges();
                return coldDrink;

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public ColdDrink DeleteColdDrink(int id)
        {
            try
            {
                var coldDrink = _context.tblColdDrinks.Find(id);
                if (coldDrink != null)
                {
                    _context.tblColdDrinks.Remove(coldDrink);
                    _context.SaveChanges();
                }
                return coldDrink;

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public IEnumerable<ColdDrink> DeleteColdDrinksByQuantity(decimal quantity)
        {
            try
            {
                var coldDrink = _context.tblColdDrinks.Where(q => q.numQuantity < quantity);
                if (coldDrink != null)
                {
                    _context.tblColdDrinks.RemoveRange(coldDrink);
                    _context.SaveChanges();
                }
                return coldDrink;

            }
            catch (Exception ex)
            {

                throw ex;
            }

           
        }

        public IEnumerable<string> GetAllColdDrinksName()
        {
            try
            {
               return _context.tblColdDrinks.Select(s => s.strColdDrinksName);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public IEnumerable<ColdDrink> GetAllColdDrinks()
        {
            try
            {
                return _context.tblColdDrinks;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public decimal GetTotalPrice()
        {
            try
            {
                return _context.tblColdDrinks.Sum(s => s.numQuantity * s.numUnitPrice);

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            
        }

        public string UpdateUnitPrice(string name, decimal unitPrice)
        {
            try
            {
                var coldDrink = _context.tblColdDrinks.FirstOrDefault(n => n.strColdDrinksName == name);
                if (coldDrink != null)
                {
                    coldDrink.numUnitPrice = unitPrice;

                    _context.SaveChanges();
                }

                return "successfully updated";
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
