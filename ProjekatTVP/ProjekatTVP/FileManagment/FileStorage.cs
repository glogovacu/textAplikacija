using System.Collections.Generic;

namespace ProjekatTVP.FileManagment
{
    /// <summary>
    /// Centrelized place for enitity lists. One for the classes and one for the string representation of
    /// the class(mostly used for writing into files).
    /// </summary>
    public class FileStorage
    {
        public static List<Guest> ListGuest = FileReader.ListGuest();
        public static List<Reservations> ListReservations = FileReader.ListReservations();
        public static List<Room> ListRoom = FileReader.ListRoom();
        public static List<User> ListUser = FileReader.ListUser();
        public static List<string> StringGuest = FileReader.StringGuest();
        public static List<string> StringReservations = FileReader.StringReservations();
        public static List<string> StringRoom = FileReader.StringRoom();
        public static List<string> StringUser = FileReader.StringUser();
    }
}
