using System;
using System.Collections.Generic;
using System.Text;
using ServersideData.Model;
using ServersideData.EntityAsModel;

namespace ServersideData
{
    class DataAccess : IDataAccess
    {
        private readonly SQLDbContext db;

        public DataAccess(SQLDbContext db)
        {
            this.db = db;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Code PlaceOrder(IEnumerable<Order> orders)
        {
            throw new NotImplementedException();
        }
    }
}
