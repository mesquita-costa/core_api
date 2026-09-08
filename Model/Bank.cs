namespace core_api.Model
{
    public class Bank
    {
        public int BankId { get;  set; } = 0;
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get;  set; } = true;
        public DateTime CreatedAt { get;  set; }
        public DateTime? UpdatedAt { get;  set; } = null;
        public Bank() { }


    }
}
