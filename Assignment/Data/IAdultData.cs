using System.Collections.Generic;
using Assignment.Models;

namespace Assignment.Data
{
    public interface IAdultData
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(Adult adult);
        void Update(Adult adult);
        Adult Get(int id);
    }
}