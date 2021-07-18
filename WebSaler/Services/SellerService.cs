using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSaler.Data;
using WebSaler.Models;
using Microsoft.EntityFrameworkCore;

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

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

    }
}
