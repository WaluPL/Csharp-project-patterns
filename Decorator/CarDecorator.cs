using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CarDecorator:Car
    {
        private Car car;
        public CarDecorator(Car car) { this.car = car; }
        public override string info() { return car.info(); }
        public override int price() { return car.price(); }
        private delegate Car Maker(Car car);
        private static Dictionary<string, Maker> mapDecor = new Dictionary<string, Maker>()
        {
            {"AirCondition", (car)=>new AirCondition(car) },
            {"TintedWindows", (car)=>new TintedWindows(car) },
            {"LeatherSeats", (car)=>new LeatherSeats(car) },
            {"WinterTire", (car)=>new WinterTire(car) },
        };
        public static string[] Decorators { get { return mapDecor.Keys.OrderBy((decorator) => decorator).ToArray(); } }
        public static Car make(string decorator,Car car) { return mapDecor[decorator](car); }
    }
    public class AirCondition : CarDecorator
    {
        public AirCondition(Car car):base(car) { }
        public override string info() { return base.info() + " + Air Condition"; }
        public override int price() { return base.price()+ 3000; }
    }
    public class TintedWindows : CarDecorator
    {
        public TintedWindows(Car car) : base(car) { }
        public override string info() { return base.info() + " + Tinted Windows"; }
        public override int price() { return base.price() + 5000; }
    }
    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car) { }
        public override string info() { return base.info() + " + Leather Seats"; }
        public override int price() { return base.price() + 9000; }
    }
    public class WinterTire : CarDecorator
    {
        public WinterTire(Car car) : base(car) { }
        public override string info() { return base.info() + " + Winter Tires"; }
        public override int price() { return base.price() + 2000; }
    }
}
