using System;
using System.ComponentModel.DataAnnotations;

namespace WIGDashboard.Core.Entities
{
    public class Camera : EntryBase
    {
        public int Id { get; private set; }

        [StringLength(1024)]
        public string Model { get; set; }
    }
}