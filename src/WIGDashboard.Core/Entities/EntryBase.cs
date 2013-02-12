using System;
using System.ComponentModel.DataAnnotations;

namespace WIGDashboard.Core.Entities
{
    public abstract class EntryBase
    {
        [StringLength(1024)]
        [Required]
        public string Title { get; set; }

        [StringLength(256)]
        [Required]
        public string Address { get; set; }


        [StringLength(1024)]
        public string Description { get; set; }
    }
}