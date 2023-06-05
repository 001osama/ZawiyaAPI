namespace ZawiyaAPI.Models.Dto
{
    public class ProductUpdateDTO
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrentPrice { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
        public int StartingPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
