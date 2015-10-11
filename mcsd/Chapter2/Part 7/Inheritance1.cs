namespace Chapter2
{
    interface IMyInterface
    {
        int MyAge { get; }
    }

    struct MyConcrete : IMyInterface
    {
        public int MyAge { get; set; }
    }
}