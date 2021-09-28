using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ListOfTrackModels;

namespace ListOfTrackBLL.VMs.ListOfTrack
{
    public class CreateListOfTrack
    {
        public Guid TrackId { get; set; }

        [Required]
        [Display(Name = "Tracks")]
        public List<string> Tracks { get; set; }
    }
}
