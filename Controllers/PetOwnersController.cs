using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetOwnersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetOwnersController(ApplicationContext context) {
            _context = context;
        }

        // This is just a stub for GET / to prevent any weird frontend errors that 
        // occur when the route is missing in this controller
        [HttpGet]
        public IEnumerable<PetOwner> GetPets() {
             Console.WriteLine("get route getting");

            return _context.PetOwners;
        }

           [HttpPost]
        public PetOwner Post(PetOwner owner)
            {
                Console.WriteLine("post route postting");
                _context.Add(owner);
                _context.SaveChanges();
                return owner;
            }
        //          [HttpPut("{id}")]
        // public PetOwner Put(PetOwner owner)
        //     {
        //         Console.WriteLine("post route postting");
        //         _context.Add(owner);
        //         _context.SaveChanges();
        //         return owner;
        //     }
        //          [HttpPost]
        // public PetOwner Post(PetOwner owner)
        //     {
        //         Console.WriteLine("post route postting");
        //         _context.Add(owner);
        //         _context.SaveChanges();
        //         return owner;
        //     }
    }
}
