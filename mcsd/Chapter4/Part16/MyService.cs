using System.ServiceModel;

namespace Chapter4
{
    [ServiceContract]
    class MyService
    {
        [OperationContract]
        public string DoSomeWork(string left, string right)
        {
            // Add System.ServiceModel reference to your project
            return string.Format("{0}, {1}", left, right);
        }
    }
}