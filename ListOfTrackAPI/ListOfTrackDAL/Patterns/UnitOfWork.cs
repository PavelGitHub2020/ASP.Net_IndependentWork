using ListOfTrackModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListOfTrackDAL.Patterns
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;
        public UnitOfWork(AppDbContext db)
        {
            _db = db;
        }

        private IRepository<Track> _tracks;
        private IRepository<ListOfTracks> _listOfTracks;

        public IRepository<Track> Tracks => _tracks ?? (_tracks = new Repository<Track>(_db));
        public IRepository<ListOfTracks> ListOfTracks => _listOfTracks ?? (_listOfTracks = new Repository<ListOfTracks>(_db));

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        private bool _disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (this._disposed)
                return;
            if (disposing)
            {
                _db.Dispose();
            }
            this._disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

