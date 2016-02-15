namespace ContactManager.Migrations
{
    using System.Data.Entity.Migrations;
    using ContactManager.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactManager.Models.ContactManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContactManager.Models.ContactManagerContext context)
        {
            context.Contacts.AddOrUpdate(p => p.Name,
               new Contact
               {
                   Name = "Justin Aurand",
                   Alias = "Slappy",
                   City = "Manayunk",
                   Likes = "Long walks on the beach and beer",
                   Dislikes = "Lactose"
               },
                new Contact
                {
                    Name = "Tyree Barron",
                    Alias = "C. Pop",
                    City = "Manayunk",
                    Likes = "Volleyball and ditching",
                    Dislikes = "Sleeping in"
                },
                new Contact
                {
                    Name = "Brandon Mock",
                    Alias = "Fuzzy",
                    City = "Drexel Hill",
                    Likes = "Punk rock and being surly",
                    Dislikes = "Dumb people"
                },
                new Contact
                {
                    Name = "Todd George",
                    Alias = "Piss Tiya",
                    City = "Collegeville",
                    Likes = "Basset hounds, Yellowcard, and Taco Bell",
                    Dislikes = "Job hunting"
                },
                new Contact
                {
                    Name = "Daniel Christman",
                    Alias = "Danimal",
                    Likes = "Texicans and the smell of gun powder",
                    Dislikes = "Pullups"
                }
            );
        }
    }
}
