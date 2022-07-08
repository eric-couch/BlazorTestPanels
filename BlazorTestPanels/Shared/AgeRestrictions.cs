namespace BlazorTestPanels.Shared
{
    public class AgeRestrictions : Fieldset
    {
        public bool VotingAge { get; set; }
        public bool DrivingAge { get; set; }
        public void ToggleVotingAge()
        {
            VotingAge = !VotingAge;
        }
        public void ToggleDrivingAge()
        {
            DrivingAge = !DrivingAge;
        }
    }
}
