using System;
using System.ComponentModel.DataAnnotations;

namespace WIGDashboard.Core.Entities
{
    public class Storage : EntryBase
    {
        public int Id { get; private set; }

        [StringLength(128)]
        public string Model { get; set; }
        [StringLength(128)]
        public string Capacity { get; set; }
    }
}