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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().ToTable("Event"); // bytar namn på dem i table
            modelBuilder.Entity<Attendee>().ToTable("Attendee");
            modelBuilder.Entity<Organizer>().ToTable("organizer");
        }


        
        public void Seed() // Seeda info
        {
            // this.Event.RemoveRange(this.Event);                    VET EJ

            this.Database.EnsureCreated(); // KAn gå fel... 
            this.Event.RemoveRange(this.Event);

            this.Event.AddRange(new List<Models.Event>() {
                    new Models.Event(){ Title="Gunnars hammar", Adress="Strandgatan 22"},
                    new Models.Event(){ Title= "hejs", Adress="Björkstigen 9"},
                    new Models.Event(){ Title="allt här", Adress="Östig 2"},
                });

            this.SaveChanges();


        }
    }
}


// SqlException: The INSERT statement conflicted with the FOREIGN KEY constraint "FK_Event_organizer_OrganizerId". The conflict occurred in database "EventContext-d7b4be54-29ab-403f-afcf-dd0e80809490", table "dbo.organizer", column 'OrganizerId'.
