using AnkaX.Models;
using AnkaX.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkaX.DataAccess.Repository.IRepository
{
 

    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
       
    }
}
