using Examples.Data.Models;
using Examples.Data.UnitOfWork;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            mockedExamplesRepository.Setup(r => r.Examples.SearchFor(It.IsAny<Expression<Func<Example, bool>>>()))
                .Returns(new List<Example>()
                {
                    new Example() { Name = "pesho"}
                }.AsQueryable());

            this.ExamplesData = mockedExamplesRepository.Object;
        }
    }
}
