using System;
using System.Collections;
using System.Collections.Generic;

namespace ObjectGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectGenerator objectGenerator = new ObjectGenerator();
            var newObject = objectGenerator.GetNewObject<Monkey>();
            Console.WriteLine(newObject.ToString());
            var list = objectGenerator.GetNewObjects<Car>(5);
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            

        }
    }
}
