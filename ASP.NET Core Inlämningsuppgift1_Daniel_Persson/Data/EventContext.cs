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
        public DbSet<organizer> Organizers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Attendee>().ToTable("Attendee");
            modelBuilder.Entity<organizer>().ToTable("organizer");
        }

        public void Seed()
        {
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
