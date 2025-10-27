using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismWithInterfaces
{
    public class Trainer
    {
        private IAnimal Entity;
        public Trainer(IAnimal entity) 
        {
            Entity = entity;
        }
        public void Make() 
        {
            Entity.Perform();
        }
    }
}
