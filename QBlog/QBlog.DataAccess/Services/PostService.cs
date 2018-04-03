using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using QBlog.Core.Dto;
using QBlog.Core.Entities;
using QBlog.DataAccess.Persistence;

namespace QBlog.DataAccess.Services
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly DbSet<PostEntity> _posts;

        public PostService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            _posts = unitOfWork.Set<PostEntity>();
        }

        public async Task<IEnumerable<PostDto>> Get(int page)
        {
            try
            {
                var skipResult = page * 10;
                return await _posts.Where(r => r.IsPublished).OrderByDescending(r => r.Id).Skip(skipResult).Take(10).ProjectTo<PostDto>().ToListAsync();
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        public async Task<PostDto> GetItem(int id)
        {
            var model =await _posts.SingleOrDefaultAsync(p => p.Id == id);
            return Mapper.Map<PostDto>(model);
        }
    }
}