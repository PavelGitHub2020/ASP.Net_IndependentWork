using ListOfTrackBLL.Interfaces;
using ListOfTrackDAL.Patterns;
using ListOfTrackModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfTrackBLL.Services
{
    public class ListOfTravkService : IListOfTrackService
    {
        private readonly IUnitOfWork db;
        private  ListOfTracks _listOfTracks;
        private Track track1;

        public ListOfTravkService(IUnitOfWork _db, Track _track)
        {
            db = _db;
            track1 = _track;
        }
        public ListOfTracks AddTrackToList(Track track)
        {
            _listOfTracks.Tracks.Add(track);
            return _listOfTracks;
        }

        public int Compare(Track track, Track track1)
        {
            if (track.Rating > track1.Rating)
            {
                return 1;
            }
            else if (track.Rating < track1.Rating)
            {
                return -1;
            }

            return 0;
        }

        public ListOfTracks CreateNewList()
        {
            _listOfTracks = new ListOfTracks();
            return  _listOfTracks;
        }

        public async Task<FileStreamResult> Download(string path)
        {
            track1.Path = path;
            var stream =  File.OpenRead(track1.Path);
            return new  FileStreamResult(stream, "application/octet-stream");
        }

        public ListOfTracks Sort()
        {
            if (_listOfTracks.Tracks.Count != 0)
             _listOfTracks.Tracks.Sort();

            return _listOfTracks;
        }

        public int SortTracksByRating(Track track, Track track1)
        {
            _listOfTracks.Tracks.Sort(delegate (Track track, Track track1)
            {
                return track.Rating.CompareTo(track1.Rating);
            });
            return 0;
        }
    }
}
