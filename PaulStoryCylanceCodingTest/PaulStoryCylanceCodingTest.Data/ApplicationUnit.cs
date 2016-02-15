using System;
using PaulStoryCylanceCodingTest.Models;

namespace PaulStoryCylanceCodingTest.Data
{
    public class ApplicationUnit : IDisposable
    {
        private DataContext _context = new DataContext();

        private IRepository<Product> _products = null;
        private IRepository<Supplier> _suppliers = null;

        public IRepository<Product> Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new GenericRepository<Product>(_context);
                }
                return _products;
            }
        }

        public IRepository<Supplier> Suppliers
        {
            get
            {
                if (_suppliers == null)
                {
                    _suppliers = new GenericRepository<Supplier>(_context);
                }
                return _suppliers;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}