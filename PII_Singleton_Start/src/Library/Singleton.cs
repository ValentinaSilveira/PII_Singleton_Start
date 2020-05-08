using System;

namespace Library
{
    public class Singleton<T> where T : new()
    {
        //private static Greeter instance;

        //public static Greeter Instance
        private static T instance;
        public static T Instance;


        public static Singleton<T> GetInstance()
        {
            if (instance == null)
            {
                instance = new T();
            }

            return instance;
         
        }  
    }
   
}