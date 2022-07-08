namespace BlazorTestPanels.Shared
{
    public class Rule
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Test { get; set; }
        public string UpdateMethod { get; set; }

    }
}
