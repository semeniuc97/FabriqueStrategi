using Logic.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class UserManager
    {
        IFactory factory; 
        public UserManager(IFactory factory)
        {
            this.factory = factory;
        }

       
    }
}
