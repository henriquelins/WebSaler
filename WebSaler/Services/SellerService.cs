using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSaler.Data;
using WebSaler.Models;

namespace WebSaler.Services
{
    public class SellerService
    {
        private readonly WebSalerContext _context;

        public SellerService(WebSalerContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
