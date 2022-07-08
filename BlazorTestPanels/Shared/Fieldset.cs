namespace BlazorTestPanels.Shared
{
    public class Fieldset
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public bool IsValidated { get; set; }
        public bool IsDirty { get; set; }
        public List<Rule> Rules { get; set; } = new List<Rule>();

    }
}
