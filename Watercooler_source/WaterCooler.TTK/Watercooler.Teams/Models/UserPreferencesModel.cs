namespace Watercooler.Teams.Models
{
    public class UserPreferencesModel
    {
        public TopicModel[] topics { get; set; }
        public FrequencyModel[] frequency { get; set; }
        public WorkinghoursfromModel[] workinghoursfrom { get; set; }
        public WorkinghourstoModel[] workinghoursto { get; set; }
    }

}
