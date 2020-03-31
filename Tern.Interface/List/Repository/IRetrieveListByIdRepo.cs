using Tern.Model;

namespace Tern.Interface.List
{
    public interface IRetrieveListByIdRepo
    {
        ListModel GetListById(int listId);
    }
}
