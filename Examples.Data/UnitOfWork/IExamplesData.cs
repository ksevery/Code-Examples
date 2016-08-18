using Examples.Data.Models;
using Examples.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Data.UnitOfWork
{
    public interface IExamplesData
    {
        IGenericRepository<Example> Examples { get; }
    }
}
