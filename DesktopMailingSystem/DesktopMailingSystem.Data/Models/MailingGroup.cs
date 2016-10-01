using System.Collections.Generic;

namespace DesktopMailingSystem.Data.Models
{
    public class MailingGroup
    {
        public int MailingGroupID{ get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<EmailAddress> EmailAddresses { get; set;}
    }
}
