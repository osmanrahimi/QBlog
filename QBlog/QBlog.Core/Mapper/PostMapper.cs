using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using QBlog.Core.Dto;
using QBlog.Core.Entities;

namespace QBlog.Core.Mapper
{
  public  class PostMapper:Profile
    {
        public PostMapper()
        {
            CreateMap<PostEntity, PostDto>();
        }
    }
}
