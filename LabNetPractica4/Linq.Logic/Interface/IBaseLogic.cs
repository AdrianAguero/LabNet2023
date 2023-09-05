using System.Collections.Generic;
namespace Linq.Logic.Interface
{
    public interface IBaseLogic<T>
    {
        List<T> GetAll();
    }
}
