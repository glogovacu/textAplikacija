using System.IO;

namespace ProjekatTVP.FileManagment
{
    /// <summary>
    /// Logic for removing and auto decrementing all the ids, every method has a similiar pattern.
    /// 
    /// Maybe due to the similarity it a method could be extracted for more readabilty?
    /// </summary>
    public class FileRemover
    {
        public static void FileGuest(int id)
        {
            int i;
            int index = id - 1;
            // Remove from list
            FileStorage.StringGuest.RemoveAt(index);
            FileStorage.ListGuest.RemoveAt(index);
            // Decrement all the ids after the index
            for (i = index; i < FileStorage.StringGuest.Count; i++)
            {
                string[] parts = FileStorage.StringGuest[i].Split(',');
                FileStorage.StringGuest[i] = (int.Parse(parts[0]) - 1) + "," + parts[1] + "," + parts[2] + "," + parts[3] + "," + parts[4];
            }
            // Write everything back into the file
            File.WriteAllLines(Paths.Guest, FileStorage.StringGuest);
            for (i = index; i < FileStorage.ListGuest.Count; i++)
            {
                FileStorage.ListGuest[i].Id = FileStorage.ListGuest[i].Id - 1;
            }
        }
        public static void FileReservations(int id)
        {
            int i;
            int index = id - 1;
            FileStorage.StringReservations.RemoveAt(index);
            FileStorage.ListReservations.RemoveAt(index);
            for (i = index; i < FileStorage.StringReservations.Count; i++)
            {
                string[] parts = FileStorage.StringReservations[i].Split(',');
                FileStorage.StringReservations[i] = (int.Parse(parts[0]) - 1) + "," + parts[1] + "," + parts[2] + "," + parts[3] + "," + parts[4] + "," + parts[5] + "," + parts[6];
            }
            File.WriteAllLines(Paths.Reservations, FileStorage.StringReservations);
            for (i = index; i < FileStorage.StringReservations.Count; i++)
            {
                FileStorage.ListReservations[i].Id = FileStorage.ListReservations[i].Id - 1;
            }
        }
        public static void FileRoom(int id)
        {
            int i;
            int index = id - 1;
            FileStorage.StringRoom.RemoveAt(index);
            FileStorage.ListRoom.RemoveAt(index);
            for (i = index; i < FileStorage.StringRoom.Count; i++)
            {
                string[] parts = FileStorage.StringRoom[i].Split(',');
                FileStorage.StringRoom[i] = (int.Parse(parts[0]) - 1) + "," + parts[1] + "," + parts[2] + "," + parts[3] + "," + parts[4] + "," + parts[5] + "," + parts[6];
            }
            File.WriteAllLines(Paths.Room, FileStorage.StringRoom);
            for (i = index; i < FileStorage.StringRoom.Count; i++)
            {
                FileStorage.ListRoom[i].Id = FileStorage.ListRoom[i].Id - 1;
            }
            
        }
        
        public static void FileUser(int id)
        {
            int i;
            int index = id - 1;
            FileStorage.StringUser.RemoveAt(index);
            FileStorage.ListUser.RemoveAt(index);
            for (i = index; i < FileStorage.StringUser.Count; i++)
            {
                string[] parts = FileStorage.StringUser[i].Split(',');
                FileStorage.StringUser[i] = (int.Parse(parts[0]) - 1) + "," + parts[1] + "," + parts[2] + "," + parts[3] + "," + parts[4] + "," + parts[5];
            }
            File.WriteAllLines(Paths.User, FileStorage.StringUser);
            for (i = index; i < FileStorage.StringUser.Count; i++)
            {
                FileStorage.ListUser[i].Id = FileStorage.ListUser[i].Id - 1;
            }
        }
    }
}
