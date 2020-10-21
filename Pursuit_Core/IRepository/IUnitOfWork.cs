using System;
using System.Collections.Generic;
using System.Text;

namespace Pursuit_Core.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
