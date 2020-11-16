using EFDBFirstExample.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace EFDBFirstExample.ConsoleApp
{
    class Program
    {
        public static DbContextOptions<ChinookContext> s_dbContextOptions;
        static void Main(string[] args)
        {
            using var s_logStream = new StreamWriter("ef-logs.txt", true);
            var optionsBuilder = new DbContextOptionsBuilder<ChinookContext>();
            optionsBuilder.UseSqlServer(GetConnectionString());
            optionsBuilder.LogTo(s_logStream.WriteLine, LogLevel.Information);
            s_dbContextOptions = optionsBuilder.Options;
            using var context = new ChinookContext(s_dbContextOptions);
            DisplayNTracks(context, 5);
            EditOneOfThoseTracks(context);
            InsertANewTrack(context);
            DeleteThatTrack(context);
        }

        private static void DeleteThatTrack(ChinookContext db)
        {
            IQueryable<Track> track = db.Tracks.Where(i => i.Name=="New Item");
            foreach (Track t in track)
            {
                db.Tracks.Remove(t);
            }
            db.SaveChanges();
        }

        private static void InsertANewTrack(ChinookContext db)
        {
            Track newTrack = new Track { 
                Bytes = 6262, 
                TrackId = 99999, 
                AlbumId = 14, 
                Composer = "Something", 
                GenreId = 6, 
                MediaTypeId = 5, 
                Milliseconds = 4856, 
                Name = "New Item", 
                UnitPrice = 8 };

            db.Tracks.Add(newTrack);
            db.SaveChanges();
        }

        private static void EditOneOfThoseTracks(ChinookContext db)
        {
            IQueryable<Track> tracks = DisplayNTracks(db,5);
            var validTrack = tracks.Where(t => t.TrackId == 2918);
            foreach(Track t in validTrack)
            {
                t.Name = "\"? I've changed the name!\"";
            }
            db.SaveChanges();
            DisplayNTracks(db, 5);
        }

        static string GetConnectionString()
        {
            string path = "../../../../../chinook-connection-string.json";
            string json;
            try
            {
                json = File.ReadAllText(path);
            }
            catch
            {
                throw;
            }
            string connectionString = JsonSerializer.Deserialize<string>(json);
            return connectionString;
        }

        static IQueryable<Track> DisplayNTracks(ChinookContext context, int n)
        {

            IQueryable<Track> tracks = context.Tracks.OrderBy(t => t.Name).Take(n);
            foreach (var track in tracks)
            {
                Console.WriteLine($"ID: {track.TrackId}\tName: {track.Name}");
            }
            return tracks;
        }
    }
}
