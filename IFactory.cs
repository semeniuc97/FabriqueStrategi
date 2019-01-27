﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces
{
    public interface IFactory
    {
        IDataReader GetReader();
        IDataWriter GetWriter();

    }
}
