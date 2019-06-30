using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_Doors
{
    class DoorActions
    {
        public string MakeDoors(string n)
        {
            char[] splitArray = n.ToCharArray();
            int increase = 1;

            for (int i = 0; i < splitArray.Length; i++)
            {
                for (int j = increase - 1; j < splitArray.Length; j += increase)
                {
                    if (splitArray[j] == '#')
                    {
                        splitArray[j] = '@';
                    }
                    else
                    {
                        splitArray[j] = '#';
                    }
                }

                increase++;
            }

            string result = new string(splitArray);

            return result;
        }
    }
}
