using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanOverloadingMethod
{
    class Numbers
    {
        //Minimum
        public int Minimum(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;

            }

            else
            {
                return num2;
            }
        }
        
        public int Minimum(int num1, int num2, int num3)
        {
            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    return num1;
                }

                else
                {
                    return num3;
                }

            }

            else
            {
                if (num2 < num3)
                {
                    return num2;
                }

                else
                {
                    return num3;
                }
            }
        }

        //Maximum
        public int Maximum(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;

            }

            else
            {
                return num2;
            }
        }


        public int Maximum (int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    return num1;
                }

                else
                {
                    return num3;
                }

            }

            else
            {
                if (num2 > num3)
                {
                    return num2;
                }

                else
                {
                    return num3;
                }
            }
        }
    }
}
