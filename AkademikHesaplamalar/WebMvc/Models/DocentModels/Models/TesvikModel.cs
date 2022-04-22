namespace WebMvc.Models.DocentModels.Models
{
    public class TesvikModel
    {
        public int Id { get; set; } = default!;
        public string? MyUserId { get; set; } = default!;


        #region Proje
        public int[] Proje1 { get; set; } = default!;
        public string[] Proje1hatirlatici { get; set; } = default!;

        public int[] Proje2 { get; set; } = default!;
        public string[] Proje2hatirlatici { get; set; } = default!;

        public int[] Proje3 { get; set; } = default!;
        public string[] Proje3hatirlatici { get; set; } = default!;

        public int[] Proje4 { get; set; } = default!;
        public string[] Proje4hatirlatici { get; set; } = default!;

        public int[] Proje5 { get; set; } = default!;
        public string[] Proje5hatirlatici { get; set; } = default!;

        #endregion
    }
}
