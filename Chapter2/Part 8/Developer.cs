using System;

namespace Chapter2
{
    /// <summary>
    /// Category can be used for both classes and methods.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class CategoryAttribute : Attribute
    {
        public CategoryAttribute(string value)
            : base()
        { }
    }

    public class UnitTestAttribute : CategoryAttribute
    {
        public UnitTestAttribute()
            : base("Unit Test")
        { }
    }
    class Developer
    {
        [Category("Human")]
        [Category("Person")]
        [UnitTest]
        public void HelloWorld()
        { }
    }
}