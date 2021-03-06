using SallesWebMvc.Data;
using SallesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Services
{
    public class SellerService
    {
        private readonly SallesWebMvcContext _context;

        public SellerService (SallesWebMvcContext context)
        {
             _context = context;
        }
        public List<Saller> FindAll()
        {
            return _context.Saller.ToList();
        }
        public void Insert(Saller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
