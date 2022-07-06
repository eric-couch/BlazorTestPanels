using System.ComponentModel.DataAnnotations;
namespace BlazorTestPanels.Shared
{
    public class PersonAge : Fieldset
    {
        [Required(ErrorMessage = "Person Age is required.")]
        [Range(1,130, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Age { get; set; }
    }
}
