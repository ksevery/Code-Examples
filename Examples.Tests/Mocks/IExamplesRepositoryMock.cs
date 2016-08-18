using Examples.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Tests.Mocks
{
    public interface IExamplesRepositoryMock
    {
        IExamplesData ExamplesData { get; }
    }
}
