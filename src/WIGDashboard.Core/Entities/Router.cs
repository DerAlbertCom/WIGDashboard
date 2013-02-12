using System;
using System.ComponentModel.DataAnnotations;

namespace WIGDashboard.Core.Entities
{
    public class Router : EntryBase
    {
        public int Id { get; private set; }

        [StringLength(128)]
        public string Model { get; set; }

    }
}