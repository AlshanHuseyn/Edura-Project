namespace Edura.Entity
{
    public class ProductAttribute
    {
        public int ProductAttributeId { get; set; }

        public string Attribute { get; set; }
        public string Value { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
