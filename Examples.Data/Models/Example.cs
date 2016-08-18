using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Data.Models
{
    public class Example
    {
        private string _name;

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentException();
                }

                this._name = value;
            }
        }

        public string Description { get; set; }
    }
}
