namespace Business.Responses.Models
{
    public class GetAllModelResponse
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; } //Brand içerisinde sadece BrandName olduğu için sadece bu propertyi ekledik.
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
