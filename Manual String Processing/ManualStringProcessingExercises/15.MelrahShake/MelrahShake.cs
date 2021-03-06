﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            var element = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var index = element.IndexOf(pattern);
                var lastIndex = element.LastIndexOf(pattern);

                if (index == -1 || index == lastIndex)
                {
                    break;
                }

                element = element.Remove(index, pattern.Length);
                index = element.LastIndexOf(pattern);
                element = element.Remove(index, pattern.Length);

                Console.WriteLine("Shaked it.");

                pattern = pattern.Remove(pattern.Length / 2, 1);

                if (pattern.Length == 0)
                {
                    break;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(element);
        }
    }
}
