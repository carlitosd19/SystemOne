namespace Vidly.ViewModels
{
    using System.Collections.Generic;
    using Vidly.Models;

    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}