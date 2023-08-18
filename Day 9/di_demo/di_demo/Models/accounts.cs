namespace di_demo.Models
{
    public class accounts
    {
        public int accNo{ get; set; }
        public string accName{ get; set; }
        public string accType{ get; set; }
        public double accBalance{ get; set; }
        public bool accIsActive{ get; set; }


        static List<accounts> accList = new List<accounts>()
        {
            new accounts(){ accNo=101, accName="Nikhil", accBalance=9000, accIsActive=true, accType="Savings"},
            new accounts(){ accNo=102, accName="Nikita", accBalance=9000, accIsActive=true, accType="Savings"},
            new accounts(){ accNo=103, accName="Nirav", accBalance=9000, accIsActive=false, accType="Savings"},
            new accounts(){ accNo=104, accName="Rohan", accBalance=9000, accIsActive=true, accType="Current"},
            new accounts(){ accNo=105, accName="Mohan", accBalance=9000, accIsActive=true, accType="Savings"},
            new accounts(){ accNo=106, accName="Ramesh", accBalance=9000, accIsActive=true, accType="Current"}
        };

        public List<accounts> GetAllAccounts()
        {
            return accList;
        }
    }
}
