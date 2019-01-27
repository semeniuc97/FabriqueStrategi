using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces
{
    public interface IDataReader
    {
        IEnumerable<User> All();
        IEnumerable<User> ByCity(string city);
    }
}
