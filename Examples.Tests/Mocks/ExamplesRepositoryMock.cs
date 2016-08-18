using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Data.UnitOfWork;
using Examples.Data.Models;

namespace Examples.Tests.Mocks
{
    public abstract class ExamplesRepositoryMock : IExamplesRepositoryMock
    {
        protected ExamplesRepositoryMock()
        {
            this.FillExamplesData();
            this.ArrangeExamplesDataMock();
        }

        public IExamplesData ExamplesData
        {
            get;
            protected set;
        }

        protected ICollection<Example> FakeExamplesCollection { get; private set; } = new List<Example>();

        protected abstract void ArrangeExamplesDataMock();

        private void FillExamplesData()
        {
            this.FakeExamplesCollection = new List<Example>()
            {
                new Example() { Name = "pesho", Description = "Some Pesho type example" }
            };
        }
    }
}
