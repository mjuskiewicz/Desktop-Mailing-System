using System.Collections.Generic;
using DesktopMailingSystem.Contracts.DTO;
using DesktopMailingSystem.Contracts;

namespace DesktopMailingSystem.Service
{
    public class MailingGroupsService : IMailingGroupsService
    {
        public List<MailingGroup> GetAllMailingGroups()
        {
            return new List<MailingGroup>
            {
                new MailingGroup() { Name = "Hyundai" , Description = "Hyundai-stl" }
            };
        }
    }
}
