using QBlog.Core.Dto;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QBlog.DataAccess.Services
{
    public interface IPostService
    {
        Task<IEnumerable<PostDto>> Get(int page);
        Task<PostDto> GetItem(int id);

    }
}