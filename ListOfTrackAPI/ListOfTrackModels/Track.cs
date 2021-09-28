using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfTrackModels
{
    public class Track : BaseEntity
    {
        public string NameOfTrack { get; set; }
        public string ArtistName { get; set; }
        public string Extension { get; set; }
        public int Rating { get; set; }
        public string Genre { get; set; }

        public string Path { get; set; }
    }
}
