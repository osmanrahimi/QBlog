namespace QBlog.Core.Dto
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public string Tags { get; set; }
        public bool IsPublished { get; set; }
    }
}