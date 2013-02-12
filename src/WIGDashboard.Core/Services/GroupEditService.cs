using System;
using System.Collections.Generic;
using System.Linq;
using Aperea.Data;
using WIGDashboard.Core.Entities;

namespace WIGDashboard.Core.Services
{
    public class GroupEditService : IGroupEditService
    {
        private readonly IRepository<Group> _groupRepository;
        public GroupEditService(IRepository<Group> groupRepository)
        {
            _groupRepository = groupRepository;
        }


        public IEnumerable<Group> AllGroups()
        {
            return _groupRepository.Entities.OrderBy(g => g.Title);
        }

    }
}