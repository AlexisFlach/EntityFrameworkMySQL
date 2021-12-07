using EFTutorial.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFTutorial.Repository
{
    public class VinylsRepository : IVinylsRepository
    {
        private readonly MyDbContext _context;
        public VinylsRepository(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Vinyl> GetVinyls()
        {
           return _context.Vinyl.Include(v => v.Artist).ToList();
        }

            public Vinyl GetVinyl(int id)
        {
            return _context.Vinyl.Include(v => v.Artist).FirstOrDefault(x => x.Id == id);

        }
        public bool AddVinyl(Vinyl v)
        {   
            try
            {
                _context.Vinyl.Add(v);
                var res = _context.SaveChanges();

                string response = "Succesfully created a Vinyl" + res;
                
            } catch(Exception e)
            {
                Console.WriteLine("Error when adding vinyl", e.Message);
                return false;
            }
            return true;
        }
        public bool UpdateVinyl(Vinyl v)
        {   
            try
            {
                var vinyl = _context.Vinyl.SingleOrDefault(existingVinyl => existingVinyl.Id == v.Id);
                _context.Entry(vinyl).CurrentValues.SetValues(v);
                _context.SaveChanges();
            } catch(Exception e)
            {
                return false;
                throw new Exception(e.Message);
            }
            return true;
        }

        public bool DeleteVinyl(int id)
        {
            try
            {
                var vinyl = _context.Vinyl.SingleOrDefault(existingVinyl => existingVinyl.Id == id);
                _context.Vinyl.Remove(vinyl);
                _context.SaveChanges();

            } catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return true;
        }
    }
}
