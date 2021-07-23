using System;
using System.Collections.Generic;
using System.Text;

namespace FindMax
{
    public class MaxNumber
    {

      
        public static int ReturnMaxInteger(int firstVal, int secondVal, int thirdVal)
        {
            
                if (firstVal.CompareTo(secondVal) > 0 && firstVal.CompareTo(thirdVal) > 0)
                {
                    return firstVal;

                }
                else if (secondVal.CompareTo(firstVal) > 0 && secondVal.CompareTo(thirdVal) > 0)
                {
                    return secondVal;

                }
                else if (thirdVal.CompareTo(firstVal) > 0 && thirdVal.CompareTo(secondVal) > 0)
                {
                    return thirdVal;

                }
              throw new Exception("Equal Numbers present");   // so as to provide an exception to
                                                                //return type of the method,as its not
                                                                //returning an integer value.
            
           





          

                
           
              
            


        }


    }
}

