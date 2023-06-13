using System;
using System.IO;

namespace ProjekatTVP.FileManagment
{
    /// <summary>
    /// Chaning files by id.
    /// </summary>
    public class FileChanger
    {
        public static void FileGuest(int id, string firstName, string lastName, DateTime dateOfBirth, string phone)
        {
            int ajdi = id - 1;
            FileStorage.ListGuest[ajdi].FirstName = firstName;
            FileStorage.ListGuest[ajdi].LastName = lastName;
            FileStorage.ListGuest[ajdi].DateOfBirth = dateOfBirth;
            FileStorage.ListGuest[ajdi].Phone = phone;

            string[] parts = FileStorage.StringGuest[ajdi].Split(',');
            FileStorage.StringGuest[ajdi] = (int.Parse(parts[0])) + "," + firstName + "," + lastName + "," + dateOfBirth.ToString("yyyy/MM/dd") + "," + phone;
            File.WriteAllLines(Paths.Guest, FileStorage.StringGuest);
        }
        
        public static void FileReservations(int id , int idGuest, int idRoom, DateTime dateFrom, DateTime dateTo, string type)
        {
            int ajdi = id - 1;
            FileStorage.ListReservations[ajdi].IdGuest = idGuest;
            FileStorage.ListReservations[ajdi].IdRoom = idRoom;
            FileStorage.ListReservations[ajdi].DateFrom = dateFrom;
            FileStorage.ListReservations[ajdi].DateTo = dateTo;
            FileStorage.ListReservations[ajdi].Price = FileStorage.ListRoom[idRoom].Price - FileStorage.ListRoom[idRoom].Discount;
            FileStorage.ListReservations[ajdi].Type = type;

            string[] parts = FileStorage.StringReservations[ajdi].Split(',');
            FileStorage.StringReservations[ajdi] = (int.Parse(parts[0])) + "," + idGuest + "," + idRoom + "," + dateFrom.ToString("yyyy/MM/dd") + "," + dateTo.ToString("yyyy/MM/dd") + "," + (FileStorage.ListRoom[idRoom].Price - FileStorage.ListRoom[idRoom].Discount) + "," + type;
            File.WriteAllLines(Paths.Reservations, FileStorage.StringReservations);
        }
        public static void FileRoom(int id, int numerOfRooms, int numberOfBeds, string type, int price, int discount, int minStayTime)
        {
            int ajdi = id - 1;
            FileStorage.ListRoom[ajdi].NumberOfRooms = numerOfRooms;
            FileStorage.ListRoom[ajdi].NumberOfBeds = numberOfBeds;
            FileStorage.ListRoom[ajdi].Type = type;
            FileStorage.ListRoom[ajdi].Price = price;
            FileStorage.ListRoom[ajdi].Discount = discount;
            FileStorage.ListRoom[ajdi].MinStayTime = minStayTime;

            string[] parts = FileStorage.StringRoom[ajdi].Split(',');
            FileStorage.StringRoom[ajdi] = (int.Parse(parts[0])) + "," + numerOfRooms + "," + numberOfBeds + "," + type + "," + price + "," + discount + "," + minStayTime;
            File.WriteAllLines(Paths.Room, FileStorage.StringRoom);
        }
        public static void FileUser(int id, string firstName, string secondName, string username, string password, string role)
        {
            int ajdi = id - 1;
            FileStorage.ListUser[ajdi].FirstName = firstName;
            FileStorage.ListUser[ajdi].LastName = secondName;
            FileStorage.ListUser[ajdi].Username = username;
            FileStorage.ListUser[ajdi].Password = password;
            FileStorage.ListUser[ajdi].Role = role;

            string[] parts = FileStorage.StringUser[ajdi].Split(',');
            FileStorage.StringUser[ajdi] = (int.Parse(parts[0])) + "," + firstName + "," + secondName + "," + username + "," + password + "," + role;
            File.WriteAllLines(Paths.User, FileStorage.StringUser);
        }
    }
}
