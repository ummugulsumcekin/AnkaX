using AnkaX.DataAccess.Data;
using AnkaX.DataAccess.Repository.IRepository;
using AnkaX.Models;
using AnkaX.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnkaX.DataAccess.Repository
{
   
        public class CompanyRepository : Repository<Company>, ICompanyRepository
    {

        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        
        public void Update(Company obj)
            {
                _db.Companies.Update(obj);
            }
        }
    }