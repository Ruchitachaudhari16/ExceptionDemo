using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public  class HandleException
    {

        public void Display()
        {
            try 
            {
                //code to try block goes here
                //put a statement where we want to raise a exception

                int[] myarray = { 10, 20, 30, 40 };
                for (int val = 0; val < myarray.Length; val++)
                {
                    Console.WriteLine(myarray[val]);
                }
                Console.WriteLine(myarray[10]);
            }
            catch(Exception ex) //Some specficexception. 
            {
                //Statement to handle the exception goes here
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                //Statement to execute after try and possibly catch block
                //cleanup code
            }
            
        }
    }
}
