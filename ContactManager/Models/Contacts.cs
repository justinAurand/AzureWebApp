namespace ContactManager.Models
{
    using System.Globalization;

    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string City { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }
        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
               "api/contacts/{0}", this.ContactId);
            }
        }
    }
}