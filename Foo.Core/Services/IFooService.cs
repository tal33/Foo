using Foo.Core.Models;

namespace Foo.Core.Services
{
    public interface IFooService
    {
        FooModel GetModel();

        void UpdateModel(FooModel model);
    }
}