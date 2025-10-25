using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreTasksForAbstractionAndInterfaces.Task1
{
    public class Robot:IId
    {
        public string Model { get; set; }
        public string Id { get; set; }
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
    }
}
