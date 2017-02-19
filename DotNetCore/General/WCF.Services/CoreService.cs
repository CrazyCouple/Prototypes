using System.Collections.Generic;
using System.Linq;
using WCF.Contracts;
using WCF.Data;

namespace WCF.Services
{
    public class CoreService : ICoreService
    {
        public void Add(string name)
        {            
            MyContext.Instance.MyTable.Add(new MyTable { Name = name });
            MyContext.Instance.SaveChanges();
        }       

        public IEnumerable<string> List()
        {
            return MyContext.Instance.MyTable.ToList().Select(x => x.Name);
        }
    }
}
