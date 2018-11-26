using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateRental(NewRentalDto rentalDto)
        {
            var customer = _context.Customers.Single(c => c.Id == rentalDto.CustomerId);
            
            var movies = _context.Movies.Where(m => rentalDto.MoviesId.Contains(m.Id)).ToList();
   
            foreach (var movie in movies)
            {
                if (movie.AvailableNumber == 0)
                    return BadRequest("Movie is not available");

                _context.Rentals.Add(new Rental()
                {
                    CustomerId = customer.Id,
                    MovieId = movie.Id,
                    DateRented = DateTime.Now
                });

                movie.AvailableNumber--;
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
