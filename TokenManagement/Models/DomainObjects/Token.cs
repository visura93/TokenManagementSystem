namespace TokenManagement.Models.DomainObjects
{
    public class Token
    {
        public string TokenID { get; set; }
        public string CustomerID { get; set; }
        public string ResolutionStatus { get; set; }
        public string CategoryID { get; set; } 
        public DateTime CreatedAt { get; set; }
    }
}
