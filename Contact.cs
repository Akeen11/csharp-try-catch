namespace try_catch {
    public class Contact {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public object FullName { get 
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}