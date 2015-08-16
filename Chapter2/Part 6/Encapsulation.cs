namespace Chapter2
{
    interface IInterfaceA
    {
        void MyMethod();
    }

    class Implementation : IInterfaceA
    {
        void IInterfaceA.MyMethod() { }
    }
}
