using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerWebApplication
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IAddService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IAddService
    {
        [OperationContract]
        int Add(int a, int b);
    }
}
