using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ListOfTrackBLL.VMs.Track
{
    public class CreateTrack
    {
        [Required]
        [Display(Name = "NameOfTrack")]
        public string NameOfTrack { get; set; }

        [Required]
        [Display(Name = "ArtistName")]
        public string ArtistName { get; set; }

        public string Extension { get; set; }

        public int Rating { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Required]
        [Display(Name = "Path")]
        public string Path { get; set; }
    }
}
