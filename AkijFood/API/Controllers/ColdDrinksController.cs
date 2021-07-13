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
            var response = _coldDrinks.GetAllColdDrinksName();

            return Ok(response);

        }

        [HttpGet("getAllColdDrinks")]
        public ActionResult<IEnumerable<ColdDrink>> GetAllColdDrinks()
        {
            var response = _coldDrinks.GetAllColdDrinks();

            return Ok(response);

        }

        [HttpPost]
        public ActionResult<ColdDrink> CreateColdDrinks([FromBody]ColdDrink coldDrink)
        {

            var response = _coldDrinks.CreateColdDrinks(coldDrink);

            return Ok(response);

        }

        [HttpDelete("{id}")]
        public ActionResult<ColdDrink> DeleteColdDrinks(int id)
        {
            var response = _coldDrinks.DeleteColdDrink(id);

            return Ok(response);

        }
       
        [HttpDelete("quantity/{quantity}")]
        public ActionResult<IEnumerable<ColdDrink>> DeleteColdDrinksByQuantity(decimal quantity)
        {
            var response = _coldDrinks.DeleteColdDrinksByQuantity(quantity);

            return Ok(response);

        }

        [HttpPut("{name}/{unitPrice}")]
        public ActionResult<string> UpdateUnitPrice(string name, decimal unitPrice)
        {
            var response = _coldDrinks.UpdateUnitPrice(name, unitPrice);

            return Ok(response);

        }

        [HttpGet("getTotalPrice")]
        public ActionResult<decimal> GetTotalPrice()
        {
            var response = _coldDrinks.GetTotalPrice();

            return Ok(response);

        }

    }
}
