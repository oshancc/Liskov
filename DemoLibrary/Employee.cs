﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class Employee : BaseEmployee, IManaged
    {
       
        public IEmployee Manager { get; set; }
      

        public virtual void AssignManager(IEmployee manager)
        {
            Manager = manager;
        }

     
    }
}
