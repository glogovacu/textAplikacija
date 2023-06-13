using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP.FileManagment
{
    public class Feedback
    {
        public static void SomeFieldsAreEmpty()
        {
            MessageBox.Show("Some fields are empty!");
        }
        public static void SomeFiledsAreNotGood()
        {
            MessageBox.Show("Some fields are not correcty inputed!");
        }
        public static void Success()
        {
            MessageBox.Show("Success!");
        }
        public static void IDFIeldIsEmpty()
        {
            MessageBox.Show("Enter an ID.");
        }
        public static void IDDoesNotExist()
        {
            MessageBox.Show("That id does not exist");
        }
        public static void IDRoomOrGuestDoesntExist()
        {
            MessageBox.Show("ID Room or ID Guest does not exist.");
        }
        public static void MinStayTimeIsAProblem()
        {
            MessageBox.Show("The condition is not met for the given room (minimum stay time).");
        }
        public static void StandardOrLuxIsEmpty()
        {
            MessageBox.Show("Pick a type");
        }
        public static void TheNumberOfBedsForFilteringIsNotValid()
        {
            MessageBox.Show("Insert a valid number of beds");
        }
    }
}
