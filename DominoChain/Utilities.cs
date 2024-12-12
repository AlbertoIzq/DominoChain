using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoChain
{
    public class Utilities
    {
        public static Domino ParseToDomino(string input)
        {
            // Split the input string by space and convert to integers
            var parts = input.Split(' ');

            // Parse each part to integer and return as a tuple
            if (parts.Length == 2)
            {
                return new Domino(int.Parse(parts[0]), int.Parse(parts[1]));
            }
            else
            {
                throw new ArgumentException("Input string must contain exactly two integers separated by a space.");
            }
        }

        // Method to find circular chain which can be considered as an Eulerian Circuit
        public static List<Domino> FindCircularChain(List<Domino> dominos)
        {
            return null;
        }
    }
}