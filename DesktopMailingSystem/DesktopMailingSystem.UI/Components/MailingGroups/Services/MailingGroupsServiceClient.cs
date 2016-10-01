using DesktopMailingSystem.Contracts;
using DesktopMailingSystem.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;

namespace DesktopMailingSystem.UI.Components.MailingGroups.Services
{
    public class MailingGroupsServiceClient : IMailingGroupsServiceClient
    {
        IMailingGroupsService _service;

        public MailingGroupsServiceClient(IMailingGroupsService service)
        {
            _service = service;
        }

        public IObservable<List<MailingGroup>> GetAllMailingGroups()
        {
            return Observable.Start(() =>
            {
                return _service.GetAllMailingGroups();
            });
        }
    }
}
