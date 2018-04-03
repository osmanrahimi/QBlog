namespace QBlog.Core.Entities
{
    public class CommentEntity : BaseEntity
    {
        public string Body { get; set; }
        public bool IsApproved { get; set; }
        public string BrowserName { get; set; }
        public string ClientIP { get; set; }
        public string Email { get; set; }
        public PostEntity Post { get; set; }
        public int PostId { get; set; }
    }
}