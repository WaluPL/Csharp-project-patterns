using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Sportsman
    {
        private string name;

        public Sportsman(string name)
        {
            this.name = name;
        }

        public string Run()
        {
            return "Running"; 
        }

        public string Swim()
        {
            return "Swimming";
        }

        public string Jump()
        {
            return "Jumping";
        }
        public string Execute(SportsmanCommand command)
        {

            return name + " : " + command.execute(this);
        }
    }
}
