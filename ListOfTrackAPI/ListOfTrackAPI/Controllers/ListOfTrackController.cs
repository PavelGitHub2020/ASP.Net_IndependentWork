using ListOfTrackBLL.Interfaces;
using ListOfTrackModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfTrackAPI.Controllers
{
    public class ListOfTrackController : Controller
    {
        private readonly IListOfTrackService _listOfTrackService;
        private readonly ITrackService _track;

        public ListOfTrackController(IListOfTrackService listOfTrackService, ITrackService track)
        {
            _listOfTrackService = listOfTrackService;
            _track = track;
        }


        [HttpGet]
        [Authorize]
        [Route("listOfTrack/Add")]
        public ActionResult AddTrackTolist(Track track_)
        {
            var listOfTrack = _listOfTrackService.AddTrackToList(track_);
            return View(listOfTrack);
        }

        [HttpGet]
        [Authorize]
        [Route("listOfTrack/compare")]
        public ActionResult Compare(Track track, Track track1)
        {
            var listOfTrack = _listOfTrackService.Compare(track,track1);
            return View(listOfTrack);
        }

        [HttpGet]
        [Authorize]
        [Route("listOfTrack/create")]
        public ActionResult CreateNewList()
        {
            var listOfTrack = _listOfTrackService.CreateNewList();
            return View(listOfTrack);
        }

        [HttpGet]
        [Authorize]
        [Route("listOfTrack/download")]
        public ActionResult Download(string path)
        {
            var listOfTrack = _listOfTrackService.Download(path);
            return View(listOfTrack);
        }

        [HttpGet]
        [Authorize]
        [Route("listOfTrack/sort")]
        public ActionResult Sort()
        {
            var listOfTrack = _listOfTrackService.Sort();
            return View(listOfTrack);
        }

        [HttpGet]
        [Authorize]
        [Route("listOfTrack/sortByRating")]
        public ActionResult SortTracksByRating(Track track, Track track1)
        {
            var listOfTrack = _listOfTrackService.SortTracksByRating(track,track1);
            return View(listOfTrack);
        }
    }
}
