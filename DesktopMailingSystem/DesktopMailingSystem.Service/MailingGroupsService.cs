using System.Collections.Generic;
using DesktopMailingSystem.Contracts.DTO;
using DesktopMailingSystem.Contracts;

namespace DesktopMailingSystem.Service
{
    public class MailingGroupsService : IMailingGroupsService
    {
        List<MailingGroup> IMailingGroupsService.GetAllMailingGroups()
        {
            return new List<MailingGroup>
            {
                new MailingGroup() { Name = "Name" , Description = "Description" }
            };
        }
    }
}
