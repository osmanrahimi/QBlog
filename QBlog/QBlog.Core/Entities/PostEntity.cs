using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QBlog.Core.Entities
{
    public class PostEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public string Tags { get; set; }
        public bool IsPublished { get; set; }
        public virtual ICollection<CommentEntity> Comments { get; set; }

        public PostEntity()
        {
            Comments = new Collection<CommentEntity>();
        }
    }
}