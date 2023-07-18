using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
   public class IndexOutOfRangeException
    {
        public void Range()
        {
            try
            {
                List<Exception> exceptions = new List<Exception>();
                Console.WriteLine(exceptions[2]);
            } 
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
