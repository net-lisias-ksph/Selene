﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Selene.DataTypes
{
    public interface ICelestialBody : ITarget
    {
        double GetRadius(); 
    }
}
