using Pursuit_Core.IRepository;
using Pursuit_DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pursuit_DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PursuitDbContext _db;
        public UnitOfWork(PursuitDbContext db)
        {
            _db = db;
        }
        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
