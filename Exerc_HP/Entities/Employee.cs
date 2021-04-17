namespace Exerc_HP.Entities
{
    class Employee
    {
        public string Name{ get; set; }
        public int Hours{ get; set; }
        public double ValueHours { get; set; }

        public Employee()
        {
            
        }

        public Employee(string name, int hours, double valueHours)
        {
            Name = name;
            Hours = hours;
            ValueHours = valueHours;
        }

        public virtual double Payment()
        {
            return Hours * ValueHours;
        }
    }
}
