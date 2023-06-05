namespace ZawiyaAPI.Models.Dto
{
    public class ProductCreateDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrentPrice { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Status { get; set; }
        public int StartingPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
