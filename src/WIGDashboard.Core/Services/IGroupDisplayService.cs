using System;
using System.Collections.Generic;
using WIGDashboard.Core.Entities;

namespace WIGDashboard.Core.Services
{
    public interface IGroupDisplayService
    {
        IEnumerable<Group> GetMainGroups();
    }
}