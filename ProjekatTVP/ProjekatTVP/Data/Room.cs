namespace ProjekatTVP
{
    public class Room
    {
        private int _id;
        private int _numberOfRooms;
        private int _numberOfBeds;
        private string _type;
        private int _price;
        private int _discount;
        private int _minStayTime;

        public int Id { get => _id; set => _id = value; }
        public int NumberOfRooms { get => _numberOfRooms; set => _numberOfRooms = value; }
        public int NumberOfBeds { get => _numberOfBeds; set => _numberOfBeds = value; }
        public string Type { get => _type; set => _type = value; }
        public int Price { get => _price; set => _price = value; }
        public int Discount { get => _discount; set => _discount = value; }
        public int MinStayTime { get => _minStayTime; set => _minStayTime = value; }

        public override string ToString()
        {
            return "ID:|" + _id + "|Number of Rooms:|" + _numberOfRooms + "|Number of beds:|" + _numberOfBeds + "|Room type:|" + _type + "|Price:|" + _price + "$|Discount:|" + _discount + "$|Minimum stay time:|" + _minStayTime;
        }
    }
}
