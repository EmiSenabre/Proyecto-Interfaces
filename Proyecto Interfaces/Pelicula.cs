using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Interfaces
{
    internal class Pelicula
    {
        string name, director, category,actors,description;
        int id,year;
        double score;

        public string Name { get => name; set => name = value; }
        public string Director { get => director; set => director = value; }
        public string Category { get => category; set => category = value; }
        public string Actors { get => actors; set => actors = value; }
        public int Year { get => year; set => year = value; }
        public double Score { get => score; set => score = value; }
        public int Id { get => id; set => id = value; }
    }
}
