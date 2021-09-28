using ListOfTrackModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListOfTrackDAL.Patterns
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Track> Tracks { get; }
        IRepository<ListOfTracks> ListOfTracks { get; }

        Task SaveAsync();
    }
}
