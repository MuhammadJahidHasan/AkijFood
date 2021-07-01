using AkijFood.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkijFood.Core.Interfaces
{
   public interface IColdDrinks
    {
        ColdDrink CreateColdDrinks(ColdDrink coldDrink);
        string UpdateUnitPrice(string name, decimal unitPrice);
        ColdDrink DeleteColdDrink(int id);
        IEnumerable<string> GetAllColdDrinksName();
        IEnumerable<ColdDrink> GetAllColdDrinks();
        IEnumerable<ColdDrink> DeleteColdDrinksByQuantity(decimal quantity);
        decimal GetTotalPrice();
    }
}
