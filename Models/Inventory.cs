using System;
using System.ComponentModel.DataAnnotations;

namespace Trunk.Models
{
    public class Inventory
    {
        private string _colour;

        public int ID { get; set; }
        public string Title { get; set; }
        public string Colour { get => _colour; set => _colour = value; }
        public decimal Price { get; set; }
    }
}
