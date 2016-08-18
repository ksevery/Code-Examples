using Examples.Data.Models;
using Examples.Data.UnitOfWork;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Tests.Mocks
{
    public class MoqExamplesRepository : ExamplesRepositoryMock
    {
        protected override void ArrangeExamplesDataMock()
        {
            var mockedExamplesRepository = new Mock<IExamplesData>();
            mockedExamplesRepository.Setup(r => r.Examples.Add(It.IsAny<Example>())).Verifiable();

            this.ExamplesData = mockedExamplesRepository.Object;
        }
    }
}
