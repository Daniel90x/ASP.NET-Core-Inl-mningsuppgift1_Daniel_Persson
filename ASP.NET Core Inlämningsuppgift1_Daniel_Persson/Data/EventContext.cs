using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Models;


namespace ASP.NET_Core_Inlämningsuppgift1_Daniel_Persson.Data
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Event { get; set; }
        public DbSet<Attendee> Attendees { get; set; } 
        public DbSet<Organizer> Organizers { get; set; }


        public void Seed() // Seeda och Resetar database
        {
            // this.Event.RemoveRange(this.Event);                    VET EJ

            Database.EnsureDeleted();
            Database.EnsureCreated(); // KAn gå fel... 
            // this.Event.RemoveRange(this.Event);


            Attendee[] attendees = new Attendee[] {
                new Attendee()
                {
                    Name = "Hans Hansson",
                    PhoneNumber = "+1 777 47 364",
                    Email = "hanssons@gmail.com",
                },
            };

            Organizer[] organizers = new Organizer[] {
                new Organizer(){
                    Name = "Cool Bois",
                    Email = "CoolBois@gmail.com",
                    PhoneNumber = "+1 509 73 564",
                },
            };



            Event[] events = new Event[] {
                new Event(){
                    
                    Title = "Cool Bois the show",
                    Adress = "Strandgatan 7",
                    Description = "Cool Bois show är den nya coola grejen på stand...",
                    Spots_available = 88,
                    Organizers= organizers[0],
                },
                new Event(){
                    
                    Title = "Varför jag?",
                    Adress = "Stengatan 88",
                    Description = "Varför jag? är en show om livet...",
                    Spots_available = 45,
                    Organizers = organizers[0],
                },
            };





            AddRange(attendees);
            AddRange(organizers);
            AddRange(events);
            SaveChanges();


        }
    }
   
}