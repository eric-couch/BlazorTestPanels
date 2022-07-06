using System.ComponentModel.DataAnnotations;

namespace BlazorTestPanels.Shared
{
    public class Person
    {
        public Guid Id { get; set; }
        
        [ValidateComplexType]
        public PersonName Name { get; set; }
        [ValidateComplexType]
        public PersonAge Age { get; set; }
        [ValidateComplexType]
        public ContactInfo ContactInfo { get; set; }
        [ValidateComplexType]
        public AgeRestrictions AgeRestrictions { get; set; }
        [ValidateComplexType]
        public AddressDetails AddressDetails { get; set; }
    }
}
