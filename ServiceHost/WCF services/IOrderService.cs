using System.Collections.Generic;
using System.ServiceModel;

namespace ServiceHost.WCF_services
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IOrderService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        void SendOrder(List<order_details>);
    }
}
