using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListOfTrackBLL.Interfaces;
using ListOfTrackModels;
using Microsoft.AspNetCore.Authorization;

namespace ListOfTrackAPI.Controllers
{
    public class TrackController : Controller
    {
        private readonly ITrackService _track;

        public TrackController(ITrackService track)
        {
            _track = track;
        }


        [HttpGet]
        [Authorize]
        [Route("track/find")]
        public ActionResult FindTrack(string nameOfTrack, string artistName, string genre)
        {
            var track = _track.FindTrack(nameOfTrack,artistName,genre);
            return View(track);
        }

        [HttpGet]
        [Authorize]
        [Route("track/find2")]
        public ActionResult FindTrack2()
        {
            var track = _track.FindTrack2(null);
            return View(track);
        }

        [HttpGet]
        [Route("track/create")]
        [Authorize]
        public ActionResult CreateTrack()
        {
            return View(new Track());
        }
    }
}

