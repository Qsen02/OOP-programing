using MoreTasksForAbstractionAndInterfaces.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreTasksForAbstractionAndInterfaces.Task2
{
    public class Robot1 : IId
    {
        public string Model { get; set; }
        public string Id { get; set; }
        public Robot1(string model, string id)
        {
            Model = model;
            Id = id;
        }
    }
}
