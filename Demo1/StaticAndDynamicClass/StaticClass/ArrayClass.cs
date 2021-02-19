using System;
using System.Collections.Generic;


namespace StaticAndDynamicClass.StaticClass
{
    public static class ArrayClass
    {
        //从数组中查找指定的元素
        //public static T Find<T>(T[] array, Func<T, bool> ary)
        //static : 静态   T : 泛型  Find<T> : 方法内为泛型    T[] array ; 形参  Func<T, bool> : 形参    ary : 委托形参 
        public static T Find<T>(T[] array, Func<T, bool> ary)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (ary(array[i]))
                {
                    return array[i];
                }
            }
            return default(T);
        }

        //从数组中查找满足条件的元素
        public static T[] FindAll<T>(T[] array, Func<T, bool> ary)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < array.Length; i++)
            {
                if (ary(array[i]))
                {
                    list.Add(array[i]);
                }
            }
            return list.ToArray();
        }


    }
}
