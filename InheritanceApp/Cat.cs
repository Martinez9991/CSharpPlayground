﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat is meowing");
        }
    }
}
