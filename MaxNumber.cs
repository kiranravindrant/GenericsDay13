﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FindMax
{
    public class MaxNumber
    {


        public static int ReturnMaxInteger(int firstVal, int secondVal, int thirdVal)
        {
            #region
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
        #endregion

        public static double ReturnMaxFloat(double firstVal, double secondVal, double thirdVal)
        {
          #region
            if (firstVal.CompareTo(secondVal) > 0 && firstVal.CompareTo(thirdVal) > 0)
            {
                return firstVal;
            }
            if (secondVal.CompareTo(firstVal) > 0 && secondVal.CompareTo(thirdVal) > 0)
            {
                return secondVal;
            }
            if (thirdVal.CompareTo(firstVal) > 0 && thirdVal.CompareTo(secondVal) > 0)
            {
                return thirdVal;
            }
            throw new Exception("Similar numbers present!!!!");
        }
        #endregion

        public static string MaxStringNumber(string firstString, string secondString, string thirdString)
        {
            #region
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }

            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }

            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }

            throw new Exception("Few strings are similar");
        }
        #endregion











    }
}

