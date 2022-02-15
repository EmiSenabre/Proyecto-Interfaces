using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Interfaces
{
    public class Pelicula
    {
        string name, director, category,actors,description;
        int id,year;
        float score;
        Bitmap image;

        public string Name { get => name; set => name = value; }
        public string Director { get => director; set => director = value; }
        public string Category { get => category; set => category = value; }
        public string Actors { get => actors; set => actors = value; }
        public int Year { get => year; set => year = value; }
        public float Score { get => score; set => score = value; }
        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public Bitmap Image { get => image; set => image = value; }
    }
}
