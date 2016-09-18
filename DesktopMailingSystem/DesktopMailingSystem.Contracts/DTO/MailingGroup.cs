using System.Runtime.Serialization;

namespace DesktopMailingSystem.Contracts.DTO
{
    [DataContract]
    public class MailingGroup
    {
        [DataMember]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}