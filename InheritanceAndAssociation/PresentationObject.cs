﻿using System;

namespace InheritanceAndAssociation
{
    public class PresentationObject 
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy() 
        {
            Console.WriteLine("Object Copied to clipboard");
        }

        public void Duplicate() 
        {
            Console.WriteLine("Object was duplicated");
        }



    }
}
