namespace Business.Requests.Cars
{
    public class CreateCarRequest
    {
        public int ModelId { get; set; }
        public int ModelYear { get; set; }
        public string Plate { get; set; }
        public int State { get; set; }
        public double DailyPrice { get; set; }
    }
}
