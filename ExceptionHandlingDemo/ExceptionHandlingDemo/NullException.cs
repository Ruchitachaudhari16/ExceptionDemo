﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public  class NullException
    {
        public void Display()
        {
            try
            {
                string str = null;
                Console.WriteLine(str.Substring(5));
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
       
        
    }
}
