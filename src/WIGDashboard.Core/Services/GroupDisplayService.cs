using System;
using System.Collections.Generic;
using System.Linq;
using Aperea.Data;
using WIGDashboard.Core.Entities;

namespace WIGDashboard.Core.Services
{
    public class GroupDisplayService : IGroupDisplayService
    {
        private readonly IRepository<Group> _groupRepository;

        public GroupDisplayService(IRepository<Group> groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public IEnumerable<Group> GetMainGroups()
        {
            return _groupRepository.Entities.OrderBy(g => g.Title);
        }
    }
}