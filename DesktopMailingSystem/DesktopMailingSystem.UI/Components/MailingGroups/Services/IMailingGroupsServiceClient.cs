using DesktopMailingSystem.Contracts.DTO;
using System;
using System.Collections.Generic;

namespace DesktopMailingSystem.UI.Components.MailingGroups.Services
{
    public interface IMailingGroupsServiceClient
    {
        IObservable<List<MailingGroup>> GetAllMailingGroups();
    }
}
