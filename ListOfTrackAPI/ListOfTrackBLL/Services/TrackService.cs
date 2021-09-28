using ListOfTrackBLL.Interfaces;
using ListOfTrackDAL.Patterns;
using ListOfTrackModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfTrackBLL.Services
{
    public class TrackService : ITrackService
    {
        private readonly IUnitOfWork db;
        private readonly ListOfTracks listOfTracks;
        private  Track track1;
        public TrackService(IUnitOfWork _db, ListOfTracks _listOfTracks, Track _track)
        {
            db = _db;
            listOfTracks = _listOfTracks;
            track1 = _track;
        }

        public Track FindTrack(string nameOfTrack, string artistName, string genre)
        {
            foreach (Track track in listOfTracks.Tracks)
            {
                if (track.NameOfTrack == nameOfTrack && track.ArtistName == artistName && track.Genre == genre)
                {
                    track1 = track;
                }
            }
            return track1;
        }

        public List<Track> FindTrack2(Func<Track, bool> func)
        {
            try
            {
                var dbTrack = db.Tracks.GetAll().Where(func).
                                                      Select(m =>
                                                      {
                                                          return new Track()
                                                          {
                                                              NameOfTrack = m.NameOfTrack,
                                                              ArtistName = m.ArtistName,
                                                              Extension = m.Extension,
                                                              Rating = m.Rating,
                                                              Genre = m.Genre,
                                                              Path = m.Path
                                                          };
                                                      }).ToList();
                return dbTrack;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
