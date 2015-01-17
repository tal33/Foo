using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foo.Core.Models
{
    public class FooModel
    {
        public string Hello;
        public string Super;
        public string Sub;

        public FooModel Clone()
        {
            return (FooModel)this.MemberwiseClone();
        }
    }
}
