namespace WpfDataTemplatingExample
{
    public abstract class ChildBase
    {
        public string DisplayName { get; } = "DisplayName " + nameof(ChildBase);
        public string Name2 { get; set; }
    }
}