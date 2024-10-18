namespace DemoLibrary
{
    public class BadClass
    {
        private string CreditCardNumber { get; set; }

        public string _CreditCardNumber
        {
            get
            {
                return CreditCardNumber;
            }

            set
            {
                CreditCardNumber = value;
            }
        }

        private int Age;

        public int _Age
        {
            get { return Age; }
            set
            {
                if (value > 0 && value < 60)
                    Age = value;
                else
                    Age = 0;
            }
        }

    }
}
