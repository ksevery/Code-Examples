using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndFuncs
{
    public class ExampleClass
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                var newName = value.Trim();
                if (string.IsNullOrEmpty(newName))
                {
                    throw new ArgumentException();
                }

                this.name = newName;
            }
        }
    }
}
