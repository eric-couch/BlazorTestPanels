using System.ComponentModel.DataAnnotations;

namespace BlazorTestPanels.Shared
{
    public class ContactInfo : Fieldset
    {
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number is required.")]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }
        
    }
}
