using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Car
    {
        public abstract string info();
        public abstract int price();
        private delegate Car Maker();
        private static Dictionary<string, Maker> map = new Dictionary<string, Maker>()
        {
            {"Mercedes", ()=>new Mercedes() },
            {"Audi", ()=>new Audi() },
            {"BMW", ()=>new BMW() },
            {"Peugeot", ()=>new Peugeot() },
        };
        public static string[] Keys { get { return map.Keys.OrderBy((Key) => Key).ToArray(); } }
        public static Car make(string Key) { return map[Key](); }
    }
    public class Mercedes : Car
    {
        public override string info() { return "Mercedes"; }
        public override int price() { return 80000; }
    }
    public class Audi : Car
    {
        public override string info() { return "Audi"; }
        public override int price() { return 100000; }
    }
    public class BMW : Car
    {
        public override string info() { return "BMW"; }
        public override int price() { return 70000; }
    }
    public class Peugeot : Car
    {
        public override string info() { return "Peugeot"; }
        public override int price() { return 50000; }
    }
}
