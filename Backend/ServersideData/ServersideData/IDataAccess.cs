using System;
using System.Collections.Generic;
using ServersideData.Model;

namespace ServersideData
{
    public interface IDataAccess 
    {
        int Commit();
        //Orders
        public Code PlaceOrder(IEnumerable<Order> orders);
        public 

    }
}
