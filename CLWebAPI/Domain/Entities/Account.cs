namespace Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}