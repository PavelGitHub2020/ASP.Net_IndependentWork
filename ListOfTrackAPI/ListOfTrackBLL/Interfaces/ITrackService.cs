using ListOfTrackModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListOfTrackBLL.Interfaces
{
    public interface ITrackService
    {
        Track FindTrack(string nameOfTrack, string artistName, string genre);
        List<Track> FindTrack2(Func<Track, bool> func);
    }
}
