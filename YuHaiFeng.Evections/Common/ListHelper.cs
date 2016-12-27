using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YuHaiFeng.Evections.Common
{
    public static  class ListHelper
    {
        public static List<T[]> ListToTable<T>(this List<T> List, int Count = 2)
        {
            var value = new T[Count];
            int Index = 0;
            var Reborn = new List<T[]>();
            foreach (var item in List)
            {
                if (Index == Count)
                {
                    Reborn.Add(value);
                    value = new T[Count];
                    Index = 0;
                }
                value[Index] = item;
                Index++;
            }
            if (value != null)
            {
                Reborn.Add(value);
            }
            return Reborn;
        }
    }
}