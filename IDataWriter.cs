using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces
{
    public interface IDataWriter
    {
        User Add(Guid id,string name, int age, string city);
        void Delte(Guid id);
    }
}
