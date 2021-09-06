namespace DL.Contract.Model
{
    public class MarkdownPage
    {
        public int    Id                 { get; set; }
        public int    MarkdownDocumentId { get; set; }
        public int    PageNo             { get; set; }
        public string Content            { get; set; }
    }
}