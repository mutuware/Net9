namespace CS13
{
    public partial class PartialProperties
    {
        public partial int MyProperty { get; } // definition
    }

    public partial class PartialProperties
    {
        public partial int MyProperty => 42; // implementation
    }
}
