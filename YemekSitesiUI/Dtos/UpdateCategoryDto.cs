namespace YemekSitesiUI.Dtos
{
    public class UpdateCategoryDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; } //?
        public bool Status { get; set; }
    }
}
