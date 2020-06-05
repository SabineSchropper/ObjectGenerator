using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectGenerator
{
    class ObjectGenerator 
    {
        public T GetNewObject<T>() where T : new()
        {

            return new T();
        }

        public List<T> GetNewObjects<T>(int amountOfObjects) where T : new()
        {
            List<T> newList= new List<T>();
            for (int i = 0; i < amountOfObjects; i++)
            {
                newList.Add(new T());
            }

            return newList;
        }
    }
}
