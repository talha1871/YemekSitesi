namespace Base_Model.Model.Entities
{
    public class Category
    {
        public int CategoryID { get; set; } 

        public string CategoryName { get; set; } 
        public string CategoryDescription { get; set; }

        public bool Status { get; set; }
        
        public List<Product> Products { get; set; }
    }
}
