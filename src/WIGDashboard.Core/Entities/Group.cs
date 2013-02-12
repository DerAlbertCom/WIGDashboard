using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WIGDashboard.Core.Entities
{
    public class Group : EntryBase
    {
        public Group()
        {
            Entries = new Collection<EntryBase>();
        }

        public int Id { get; private set; }

        public IEnumerable<EntryBase> Entries { get; private set; }
    }
}