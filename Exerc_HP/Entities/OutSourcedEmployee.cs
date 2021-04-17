namespace Exerc_HP.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee()
        {
            
        }

        public OutSourcedEmployee(string name, int hours, double valueHours, double additionalCharge)
            : base (name, hours, valueHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
