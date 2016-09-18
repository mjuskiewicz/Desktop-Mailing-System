using DesktopMailingSystem.Contracts.DTO;
using System.Collections.Generic;
using System.ServiceModel;

namespace DesktopMailingSystem.Service
{
    [ServiceContract]
    public interface IMailingGroupsService
    {
        [OperationContract]
        List<MailingGroup> GetAllMailingGroups();
    }
}
