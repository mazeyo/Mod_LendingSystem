
namespace Mod_LendingSystem
{
    internal class LoanTransaction
    {
        internal string txtCustID;

        public DateTime TransactionDate { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string ContactNo { get; internal set; }
        public char? MiddleInitial { get; internal set; }
        public decimal Amount { get; internal set; }
        public double InterestRatePercent { get; internal set; }
        public string PaymentSchedule { get; internal set; }
        public DateTime DueDate { get; internal set; }
        public object InterestAmount { get; internal set; }
        public object TotalDue { get; internal set; }

        internal void FinalizeTransaction()
        {
            throw new NotImplementedException();
        }
    }
}