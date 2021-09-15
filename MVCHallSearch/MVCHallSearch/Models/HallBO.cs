using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHallSearch.Models
{
    public class HallBO
    {
        public List<Hall> GetHalls()
        {
            List<Hall> halls = new List<Hall>();
            halls.Add(new Hall("The Walt Disney Concert Hall", "Peter Parker", 20000, "9876543210", "Washington"));
            halls.Add(new Hall("Hall Paradise", "Steve Jobs", 40000, "9123458760", "California"));
            halls.Add(new Hall("Hall Magica", "Bill Gates", 50000, "8976543210", "London"));
            halls.Add(new Hall("The Oslo Opera House", "Shakespeare", 45000, "7890654321", "Norway"));
            halls.Add(new Hall("Rudolfinum", "Othello", 35000, "7986574032", "Denmark"));
            halls.Add(new Hall("Casa da Musica", "Jason Smith", 25000, "8967452310", "Portugal"));
            halls.Add(new Hall("Carnegie Hall", "Bratt", 25000, "7907056342", "London"));
            halls.Add(new Hall("Palacio de Bellas Artes", "James Harry", 32000, "9056567834", "Washington"));
            halls.Add(new Hall("Opera House", "Thomas Peterson", 45000, "7890786512", "London"));
            halls.Add(new Hall("Esplanade", "Bobby", 30000, "7589341240", "London"));
            return halls;
        }
    }
}