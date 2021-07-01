using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkijFood.Core.Entities;
using AkijFood.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkijFood.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColdDrinksController : ControllerBase
    {
        private readonly IColdDrinks _coldDrinks;

        public ColdDrinksController(IColdDrinks coldDrinks)
        {
            this._coldDrinks = coldDrinks;
        }

        [HttpGet]
        public ActionResult<string> GetAllColdDrinksName()
        {
            return Ok(_coldDrinks.GetAllColdDrinksName());

        }

        [HttpGet("getAllColdDrinks")]
        public ActionResult<IEnumerable<ColdDrink>> GetAllColdDrinks()
        {

            return Ok(_coldDrinks.GetAllColdDrinks());

        }

        [HttpPost]
        public ActionResult<ColdDrink> CreateColdDrinks([FromBody]ColdDrink coldDrink)
        {
            return Ok(_coldDrinks.CreateColdDrinks(coldDrink));

        }

        [HttpDelete("{id}")]
        public ActionResult<ColdDrink> DeleteColdDrinks(int id)
        {
            return Ok(_coldDrinks.DeleteColdDrink(id));

        }
       
        [HttpDelete("quantity/{quantity}")]
        public ActionResult<IEnumerable<ColdDrink>> DeleteColdDrinksByQuantity(decimal quantity)
        {
            return Ok(_coldDrinks.DeleteColdDrinksByQuantity(quantity));

        }

        [HttpPut("{name}/{unitPrice}")]
        public ActionResult<string> UpdateUnitPrice(string name, decimal unitPrice)
        {
            return Ok(_coldDrinks.UpdateUnitPrice(name, unitPrice));

        }

        [HttpGet("getTotalPrice")]
        public ActionResult<decimal> GetTotalPrice()
        {
            return Ok(_coldDrinks.GetTotalPrice());

        }

    }
}
