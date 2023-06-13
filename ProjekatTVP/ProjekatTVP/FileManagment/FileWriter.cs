using System;
using System.IO;

namespace ProjekatTVP.FileManagment
{
    /// <summary>
    ///  A class to write into files.
    /// </summary>
    public class FileWriter
    {
        public static void FileGuest(string firstName,string lastName, DateTime dateOfBirth, string phone)
        {
            Guest g = new Guest();
            g.Id = FileStorage.ListGuest.Count + 1;
            g.FirstName = firstName;
            g.LastName = lastName;
            g.DateOfBirth = dateOfBirth;
            g.Phone = phone;
            FileStorage.ListGuest.Add(g);

            string line = (FileStorage.ListGuest.Count) + "," + firstName + "," + lastName + "," + dateOfBirth.ToString("yyyy/MM/dd") + "," + phone + Environment.NewLine;
            File.AppendAllText(Paths.Guest, line);
        }
        
        public static void FileReservations(int idRoom, int idGuest, DateTime dateFrom, DateTime dateTo, string type)
        {
            Reservations r = new Reservations();
            r.Id = FileStorage.ListReservations.Count + 1;
            r.IdRoom = idRoom;
            r.IdGuest = idGuest;
            r.DateFrom = dateFrom;
            r.DateTo = dateTo;
            r.Price = FileStorage.ListRoom[idRoom].Price - FileStorage.ListRoom[idRoom].Discount;
            r.Type = type;
            FileStorage.ListReservations.Add(r);
            string line = (FileStorage.ListReservations.Count) + "," + idRoom + "," + idGuest + "," + dateFrom.ToString("yyyy/MM/dd") + "," + dateTo.ToString("yyyy/MM/dd") + "," + (FileStorage.ListRoom[idRoom].Price - FileStorage.ListRoom[idRoom].Discount) + "," + type + Environment.NewLine;
            File.AppendAllText(Paths.Reservations, line);
        }
        public static void FileRoom(int numberOfRooms, int numberOfBeds, string type, int price, int discount, int minStayTime)
        {
            Room s = new Room();
            s.Id = FileStorage.ListRoom.Count + 1;
            s.NumberOfRooms = numberOfRooms;
            s.NumberOfBeds = numberOfBeds;
            s.Type = type;
            s.Price = price;
            s.Discount = discount;
            s.MinStayTime = minStayTime;
            FileStorage.ListRoom.Add(s);

            string line = (FileStorage.ListRoom.Count) + "," + numberOfRooms + "," + numberOfBeds + "," + type + "," + price + "," + discount + "," + minStayTime + Environment.NewLine;
            File.AppendAllText(Paths.Room, line);
        }
        public static void FileKorisnik(string firstName, string lastName, string username,string password, string role)
        {
            User k = new User();
            k.Id = FileStorage.ListUser.Count + 1;
            k.FirstName = firstName;
            k.LastName = lastName;
            k.Username = username;
            k.Password = password;
            k.Role = role;
            FileStorage.ListUser.Add(k);
            string line = (FileStorage.ListUser.Count) + "," + firstName + "," + lastName + "," + username + "," + password + "," + role + Environment.NewLine;
            File.AppendAllText(Paths.User, line);
            
        }
    }
}
