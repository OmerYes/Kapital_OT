using OT.DAL.Context;
using OT.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OT.Business.Manager.Repository
{
   public class UnitOfWork:IDisposable
    {
        private OTContext tContext = new OTContext();
        public UnitOfWork()
        {
            tContext = new OTContext();
        }
        public UnitOfWork (OTContext db)
        {
            tContext = db;
        }

        private GenericRepository<User> userRepo;
        private GenericRepository<Ticket> ticketRepo;

        public GenericRepository<User> UserRepo
        {
            get
            {
                if (this.userRepo == null)
                {
                    this.userRepo = new GenericRepository<User>(tContext);
                }
                return userRepo;
            }
        }

        public GenericRepository<Ticket> TicketRepo
        {
            get
            {
                if (this.ticketRepo == null)
                {
                    this.ticketRepo = new GenericRepository<Ticket>(tContext);
                }
                return ticketRepo;
            }
        }
        public void Save()
        {
            tContext.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    tContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
