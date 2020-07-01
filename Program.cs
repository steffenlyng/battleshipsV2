using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;

namespace Battleships
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1N = 6;
            var t1S = "1AA 1AAA,2BB 3AAA";
            var t1T = "1AA 1AB 2DD 3DD 4DD 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D 1A 1B 2D 4D 3D";

            Console.WriteLine(solution(t1N, t1S, t1T));
        }

        public static string solution(int N, string S, string T)
        {
            int shipsHit, shipsSunk;

            var ships = GenerateShips(S);
            BombardShips(T, ships, out shipsHit, out shipsSunk);

            return $"{shipsHit},{shipsSunk}";
        }

        public static List<HashSet<Coord>> GenerateShips(string shipCoords)
        {
            return shipCoords
                .Split(',')
                .Select(GenerateShip)
                .ToList();
        }

        private static Coord GetCoordinateFromString(string coord)
        {
            int parseCoord(string charCoord)
            {
                var arrCoord = charCoord.ToUpper().ToCharArray();
                var baseNumber = 'Z' - 'A' + 1;
                var asciiOffset = (int)'A';

                var result = 0;
                for (var i = 0; i < arrCoord.Length; i++)
                {
                    var positionalMultiplier = (int)Math.Pow(baseNumber, i);
                    var charValue = arrCoord[arrCoord.Length - 1 - i] - asciiOffset + 1;
                    result += positionalMultiplier * charValue;
                }

                return result;
            }

            var x = int.Parse(Regex.Match(coord, @"\d+").Value);
            var y = parseCoord(Regex.Replace(coord, @"[\d-]", string.Empty));

            return new Coord(x, y);
        }

        public static HashSet<Coord> GenerateShip(string shipCoords)
        {
            var resultCoords = new HashSet<Coord>();

            var coords = shipCoords
                .Split(' ')
                .Select(GetCoordinateFromString)
                .OrderBy(coord => coord.X)
                .ThenBy(coord => coord.Y);

            var lowerCoord = coords.First();
            var upperCoord = coords.Last();

            for (int x = lowerCoord.X; x <= upperCoord.X; x++)
            {
                for (int y = lowerCoord.Y; y <= upperCoord.Y; y++)
                {
                    resultCoords.Add(new Coord(x, y));
                }
            }

            return resultCoords;
        }

        public static void BombardShips(string bombingCoordsString, List<HashSet<Coord>> ships, out int shipsHit, out int shipsSunk)
        {
            //default initial result
            shipsSunk = 0;
            shipsHit = 0;

            //generate bombing array
            var bombingCoords = bombingCoordsString.Split(' ').Select(GetCoordinateFromString);

            //calculate hit or sunk
            foreach (var ship in ships)
            {
                var hits = 0;
                foreach (var shipCoord in ship)
                {
                    if (bombingCoords.Contains(shipCoord))
                        hits++;
                }

                if (hits == ship.Count()) shipsSunk++;
                else if (hits > 0) shipsHit++;
            }
        }

        public class Coord : IEquatable<Coord>
        {
            public Coord(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; }
            public int Y { get; }

            public bool Equals(Coord other)
            {
                return X == other.X && Y == other.Y;
            }

            public override string ToString()
            {
                return $"{{{X},{Y}}}";
            }
        }
    }
}

