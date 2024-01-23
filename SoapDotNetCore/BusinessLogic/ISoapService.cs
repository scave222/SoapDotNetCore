using System.ServiceModel;

namespace SoapDotNetCore.BusinessLogic
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string Sum(int num1, int num2);
    }
}
