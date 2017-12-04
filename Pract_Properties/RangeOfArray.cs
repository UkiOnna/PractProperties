using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_Properties
{
    class RangeOfArray
    {
        public int rangeStart { get; set; }
        public int rangeFinish { get; set; }

        private bool isRangeStart = false;
        private int[] array;


        public int this[int index]
        {
            get
            {
                if (rangeFinish < 0 && rangeStart < 0)
                {
                    if (!isRangeStart)
                    {
                        rangeStart = rangeStart * (-1);
                        isRangeStart = true;
                    }
                    if (array == null)
                    {
                        array = new int[rangeStart - rangeFinish];
                    }
                    return array[rangeStart + index];
                }
                else
                {
                    if (!isRangeStart)
                    {
                        if (array == null)
                        {
                            array = new int[rangeFinish - rangeStart];
                        }
                        return array[index-rangeStart];
                    }

                    else
                    {
                        if (array == null)
                        {
                            array = new int[rangeStart - rangeFinish];
                        }
                        return array[rangeStart + index];
                    }
                }
               
               
                    
            }
            set
            {
                if (rangeFinish < 0 && rangeStart < 0)
                {
                    if (!isRangeStart)
                    {
                        rangeStart = rangeStart * (-1);
                        isRangeStart = true;
                    }
                    if (array == null)
                    {
                        array = new int[rangeStart - rangeFinish];
                    }
                    array[rangeStart + index] = value;
                }
                else
                {
                    if (!isRangeStart)
                    {
                        if (array == null)
                        {
                            array = new int[rangeFinish - rangeStart];
                        }
                        array[index-rangeStart] = value;
                    }
                    else
                    {
                        if (array == null)
                        {
                            array = new int[rangeStart - rangeFinish];
                        }
                        array[rangeStart + index] = value;
                    }
                }

            }


        }//индексирование
    }
}
