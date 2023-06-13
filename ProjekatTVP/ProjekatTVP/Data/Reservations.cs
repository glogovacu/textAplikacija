using System;

namespace ProjekatTVP
{
    public class Reservations
    {
        private int _id;
        private int _idRoom;
        private int _idGuest;
        private DateTime _dateFrom;
        private DateTime _dateTo;
        private int _price;
        private string _type;

        public int Id { get => _id; set => _id = value; }
        public int IdRoom { get => _idRoom; set => _idRoom = value; }
        public int IdGuest { get => _idGuest; set => _idGuest = value; }
        public DateTime DateFrom { get => _dateFrom; set => _dateFrom = value; }
        public DateTime DateTo { get => _dateTo; set => _dateTo = value; }
        public int Price { get => _price; set => _price = value; }
        public string Type { get => _type; set => _type = value; }

        public override string ToString()
        {
            return "ID:|" + _id + "|Room ID:|" + _idRoom + "|Guest ID:|" + _idGuest + "|Date From:|" + _dateFrom.Day + "." + _dateFrom.Month + "." + _dateFrom.Year + "." + "|Date To:|" + _dateTo.Day + "." + _dateTo.Month + "." + _dateTo.Year + "." + "|Price:|" + _price + "$|Type:|" + _type;
        }
    }
}
