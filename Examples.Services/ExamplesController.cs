using Examples.Data;
using Examples.Data.Models;
using Examples.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Services
{
    public class ExamplesController
    {
        private readonly IExamplesData _data;

        public ExamplesController()
            : this(new ExamplesData())
        {

        }

        public ExamplesController(IExamplesData data)
        {
            this._data = data;
        }

        public Example GetExampleByName(string name)
        {
            return this._data.Examples.SearchFor(e => e.Name == name).First();
        }
    }
}
