﻿using DealershipManager.Dtos;
using DealershipManager.Models;
using DealershipManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace DealershipManager.Controllers
{
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpPost] // POST api/cars
        [Route("cars")]
        public IActionResult Add(AddCarDto car)
        {
            _carService.Add(car);

            return Ok();
        }
        [HttpGet] // GET api/cars
        [Route("cars")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();

            return Ok(result);
        }
        // Get car by id : GET/ cars/{id}
        [HttpGet]
        [Route("cars/{carId}")]
        public IActionResult GetById(Guid carId)
        {
            var result = _carService.Get(carId);
            return result != null ? Ok(result) : NotFound();


        }
        // Update car : PUT/ cars/{id}
        [HttpPut]
        [Route("cars/{carId}")]
        public IActionResult Update(Guid carId, UpdateCarDto car)
        {
            _carService.Update(carId, car);

            return Ok();
        }

        // Detele car: DELETE/cars/{id}
        [HttpDelete]
        [Route("cars/{carId}")]
        public IActionResult Delete(Guid carId)
        {
            _carService.Delete(carId);

            return NoContent();
        }
    }
}
    
