using System.ComponentModel.DataAnnotations;

namespace BlazorTestPanels.Shared
{
    public class PersonName : Fieldset
    {
        [DataType(DataType.Text)]
        [MaxLength(256, ErrorMessage = "First Name must be less than or equal to {1} characters.")]
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(256, ErrorMessage = "Last Name must be less than or equal to {1} characters.")]
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }
    }
}
