using Company.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository
{
    public class DepartmentRepository
    {
        private readonly CompanyDbContext _context;
        public DepartmentRepository()
        {
            _context = new CompanyDbContext();
        }
        
    }

}
