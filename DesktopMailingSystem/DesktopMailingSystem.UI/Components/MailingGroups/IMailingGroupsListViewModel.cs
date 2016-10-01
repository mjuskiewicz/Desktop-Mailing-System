using DesktopMailingSystem.Contracts.DTO;
using System.Collections.Generic;

namespace DesktopMailingSystem.UI.Components.MailingGroups
{
    public interface IMailingGroupsListViewModel
    {
        IList<MailingGroup> MailingGroups { get; set; }
    }
}
