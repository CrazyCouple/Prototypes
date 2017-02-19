using System.Collections.Generic;
using System.ServiceModel;

namespace WCF.Contracts
{
    [ServiceContract]
    public interface ICoreService
    {
        [OperationContract]
        void Add(string name);

        [OperationContract]
        IEnumerable<string> List();
    }
}
