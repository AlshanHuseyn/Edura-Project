namespace Edura.Entity
{
    public class Image
    {
        public int ImageId { get; set; }

        public string ImageName { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
