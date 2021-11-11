namespace Class_Method
{
    public class Car
    {
        public int numberofwheel;
        public string brand;
        public string color;
        public Car(int numberofwheel, string brand, string color)
        {
            this.numberofwheel = numberofwheel;
            this.brand = brand;
            this.color = color;
        }

        public Car()
        {
            
        }

        public string horn(string ring)
        {
            return ring + " " + ring + " " + ring;
        }
    }
}