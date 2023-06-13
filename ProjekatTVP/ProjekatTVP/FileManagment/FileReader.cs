using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjekatTVP.FileManagment
{
    /// <summary>
    /// This is a class that reads data from files and organizes it into Class Lists and string lists for the FileStorage class.
    /// </summary>
    public class FileReader
    {
        
        public static List<Guest> ListGuest()
        {
            if (!File.Exists(Paths.Guest))
            {
                File.Create(Paths.Guest);
            }
            List<Guest> guest = new List<Guest>();
            List<string> lines = File.ReadAllLines(Paths.Guest).ToList();
            foreach (var row in lines)
            {
                Guest g = new Guest();
                string[] parts = row.Split(',');
                g.Id = int.Parse(parts[0].ToString());
                g.FirstName = parts[1];
                g.LastName = parts[2];
                string[] date = parts[3].Split('-');
                g.DateOfBirth = new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));
                g.Phone = parts[4];
                guest.Add(g);
            }
            return guest;
        }
        public static List<Reservations> ListReservations()
        {
            if (!File.Exists(Paths.Reservations))
            {
                File.Create(Paths.Reservations);
            }
            List<Reservations> reservations = new List<Reservations>();
            List<string> lines = File.ReadAllLines(Paths.Reservations).ToList();
            foreach (var row in lines)
            {
                Reservations re = new Reservations();
                string[] parts = row.Split(',');
                re.Id = int.Parse(parts[0]);
                re.IdRoom = int.Parse(parts[1]);
                re.IdGuest = int.Parse(parts[2]);
                string[] dateFrom = parts[3].Split('-');
                re.DateFrom = new DateTime(int.Parse(dateFrom[0]), int.Parse(dateFrom[1]), int.Parse(dateFrom[2]));
                string[] dateTo = parts[4].Split('-');
                re.DateTo = new DateTime(int.Parse(dateTo[0]), int.Parse(dateTo[1]), int.Parse(dateTo[2]));
                re.Price = int.Parse(parts[5]);
                re.Type = parts[6];
                reservations.Add(re);
            }
            return reservations;
        }
        public static List<Room> ListRoom()
        {
            if(!File.Exists(Paths.Room))
            {
                File.Create(Paths.Room);
            }
            List<Room> rooms = new List<Room>();
            List<string> lines = File.ReadAllLines(Paths.Room).ToList();
            foreach (var row in lines)
            {
                Room r = new Room();
                string[] parts = row.Split(',');
                r.Id = int.Parse(parts[0].ToString());
                r.NumberOfRooms = int.Parse(parts[1].ToString());
                r.NumberOfBeds = int.Parse(parts[2].ToString());
                r.Type = parts[3];
                r.Price = int.Parse(parts[4].ToString());
                r.Discount = int.Parse(parts[5].ToString());
                r.MinStayTime = int.Parse(parts[6].ToString());
                rooms.Add(r);
            }
            return rooms;
        }
        
        public static List<User> ListUser()
        {
            if (!File.Exists(Paths.User))
            {
                File.Create(Paths.User);
            }
            List<User> users = new List<User>();
            List<string> lines = File.ReadAllLines(Paths.User).ToList();
            foreach (var row in lines)
            {
                User u = new User();
                string[] celo = row.Split(',');
                u.Id = int.Parse(celo[0].ToString());
                u.FirstName = celo[1];
                u.LastName = celo[2];
                u.Username = celo[3];
                u.Password = celo[4];
                u.Role = celo[5];
                users.Add(u);

            }
            return users;
        }
        public static List<string> StringGuest()
        {
            List<string> lines = File.ReadAllLines(Paths.Guest).ToList();
            return lines;
        }
        public static List<string> StringReservations() 
        {
            List<string> lines = File.ReadAllLines(Paths.Reservations).ToList();
            return lines;
        }
        public static List<string> StringRoom()
        {
            List<string> lines = File.ReadAllLines(Paths.Room).ToList();
            return lines;
        }
        public static List <string> StringUser() 
        {
            List<string> lines = File.ReadAllLines(Paths.User).ToList();
            return lines;
        }
    }
}
