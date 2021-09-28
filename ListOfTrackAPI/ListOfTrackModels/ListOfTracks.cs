using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfTrackModels
{
    public class ListOfTracks : BaseEntity
    {
        public Guid TrackId { get; set; }
        public virtual List<Track> Tracks { get; set; } = new List<Track>();
    }
}
