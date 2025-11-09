using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndEvents.Task1
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
    public class Dispatcher
    {
        private string Name;
        public Dispatcher(string name) 
        {
            Name = name;
        }
        public string GetName() 
        {
            return Name;
        }
        public void SetName(string value) 
        {
            if (value != Name)
            {
                Name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }
        public event NameChangeEventHandler NameChange;
        protected virtual void OnNameChange(NameChangeEventArgs args) 
        {
            if (Name != null) 
            {
                NameChange(this, args);
            }
        }
    }
}
