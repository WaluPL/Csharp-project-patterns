using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface SportsmanCommand
    {
        string execute(Sportsman s);
    }

    public class SportsmanCommandRun: SportsmanCommand
    {
        public string execute(Sportsman s)
        {
            return s.Run();
        }
		public override string ToString()
		{
			return "Run";
		}
	}

    public class SportsmanCommandSwim : SportsmanCommand
    {
        public string execute(Sportsman s)
        {
            return s.Swim();
        }
        public override string ToString()
        {
            return "Swim";
        }
    }

    public class SportsmanCommandJump : SportsmanCommand
    {
        public string execute(Sportsman s)
        {
            return s.Jump();
        }
        public override string ToString()
        {
            return "Jump";
        }
    }
    public abstract class SportsmanCommandComplex : SportsmanCommand
    {
        public abstract string execute(Sportsman s);
        private string name;
        public SportsmanCommandComplex(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
    }

    public class SportsmenCommandTrening : SportsmanCommandComplex
    {
        private List<SportsmanCommand> list = new List<SportsmanCommand>();
        public SportsmenCommandTrening(string name, List<SportsmanCommand> list):base(name)
        {
            this.list = list;
        }
        public override string execute(Sportsman s)
        {
            StringBuilder sb = new StringBuilder();
            bool first = true;
            foreach(SportsmanCommand cmd in list)
            {
                if (first) first = false;
                else sb.Append(", ");
                sb.Append(cmd.execute(s));
            }
            return sb.ToString();
        }
       
    }

}
