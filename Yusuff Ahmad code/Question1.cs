using System;
using System.Collections.Generic;
using System.Text;

namespace Yusuff_Ahmad_code
{
    class Question1
    {
        public static int CoinBase(int input)
        {
            if (input%2==0)
            {
                int count = input / 2;
                List<int> myList = new List<int>();
                for (int i = 1; myList.Count == input; i++)
                {

                    for (int j = i + 1; j == input; j++)
                    {
                        myList.Add(i + j);
                    }
                    count++;
                }
                return count - 1;
            }
            else
            {
                int count = (input /2) + 1;
                List<int> myList = new List<int>();
                for (int i = 1; myList.Count == input; i++)
                {

                    for (int j = i + 1; j == input; j++)
                    {
                        myList.Add(i + j);
                    }
                    count++;
                }
                return count - 1;
            }
            
        }
    }
}
