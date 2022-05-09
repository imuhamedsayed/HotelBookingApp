namespace BookingApp.Web
{
    public static class SD
    {
        public static string APIBaseUrl = "https://localhost:44309/";
        public static string AccountAPIPath = APIBaseUrl + "api/v1/Users/";
        public static string HotelAPIPath = APIBaseUrl + "api/v1/Hotels/";
        public static string BranchAPIPath = APIBaseUrl + "api/v1/Branches/";
        public static string RoomAPIPath = APIBaseUrl + "api/v1/Rooms/";
        public static string UserRoomAPIPath = APIBaseUrl + "api/v1/UserRooms/";
    }
}
