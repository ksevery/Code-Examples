using Examples.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Data.Models;
using Examples.Data.Repositories;
using System.Data.Entity;

namespace Examples.Data
{
    public class ExamplesData : IExamplesData
    {
        private DbContext context;
        private IDictionary<Type, object> repositories;

        public IGenericRepository<Example> Examples
        {
            get
            {
                return this.GetRepository<Example>();
            }
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}
