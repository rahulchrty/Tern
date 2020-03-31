using System;
using Tern.Domain;
using Tern.Interface.List;

namespace Tern.Data.ListRepository
{
    public class CreateListRepo : ICreateListRepo
    {
        private TernContext _ternContext;
        public CreateListRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public int Create(string listName)
        {
            List newList = new List { ListName = listName , CreatedDate = DateTime.Now};
            _ternContext.Lists.Add(newList);
            _ternContext.SaveChanges();
            return newList.ListId;
        }
    }
}
