﻿using System;
using System.Collections.Generic;

namespace Comparable
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            foreach (var domino in dominoes)
            {
                Console.Write("[" + domino.GetValues()[0] + ", ");
                Console.WriteLine(domino.GetValues()[1] + "]");
            }
            Console.WriteLine("\n");
            /*
            for (int i = 0; i < dominoes.Count - 1; i++)
            {
                dominoes[i].CompareTo(dominoes[i + 1]);
            }
            */
            dominoes.Sort();

            foreach (var domino in dominoes)
            {
                Console.Write("[" + domino.GetValues()[0] + ", ");
                Console.WriteLine(domino.GetValues()[1] + "]");
            }

            Console.ReadLine();
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }

        
    }
}