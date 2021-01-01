using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalUsingInterface.Entities
{
    class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }

        public override string ToString()
        {
            return "Car model: " + Model;
        }
    }
}
