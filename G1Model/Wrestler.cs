﻿using System;
using System.Collections.Generic;
using System.Text;

namespace G1Model
{
    public class Wrestler
    {
        public string Name { get; set; }

        public int Points { get; set; }


        public Wrestler(string name)
        {
            Name = name;
            Points = 0;

        }

    }
}
