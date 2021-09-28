using ListOfTrackModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListOfTrackBLL.Interfaces
{
    public interface IListOfTrackService
    {
        int Compare(Track track, Track track1);

        ListOfTracks CreateNewList();
        ListOfTracks AddTrackToList(Track track);

        int SortTracksByRating(Track track, Track track1);

        ListOfTracks Sort();
        Task<FileStreamResult> Download(string path);
    }
}
