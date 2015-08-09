class Types5<T>
    where T : class, new()
{
    public Types5()
    {
        Age = new T();
    }

    public T Age { get; set; }

    public void DefaultValueForMyGeneric<T>()
    {
        // get default value for my generic
        T defaultValue = default(T);
    }
}