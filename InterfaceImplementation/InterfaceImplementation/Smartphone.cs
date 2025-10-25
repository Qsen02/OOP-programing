using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    public class Smartphone:ICalling,IBrowsing
    {
        public string Model { get; set; }
        public Smartphone(string model)
        {
            Model = model;
        }

        public void Call(string[] phoneNumbers) 
        {
            string pattern = @"^[0-9]+$";
            foreach (string number in phoneNumbers) 
            {
                if (Regex.IsMatch(number, pattern)){
                    Console.WriteLine($"Calling... {number}");
                } else 
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
        public void Browse(string[] webSites) 
        {
            string pattern = @"[0-9]+";
            foreach (string website in webSites)
            {
                if (Regex.IsMatch(website, pattern))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else 
                {
                    Console.WriteLine($"Browsing: {website}!");
                }
            }
        }
    }
}
