using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foo.Core.Models;

namespace Foo.Core.Services
{
    public class FooService : IFooService
    {
        private FooModel _model = new FooModel() { Hello = "Hobbes", Super = "Strider", Sub = "Marvin"};

        public FooModel GetModel()
        {
            return _model.Clone();            
        }

        public void UpdateModel(FooModel model)
        {
            this._model = model.Clone();
        }
    }
}
