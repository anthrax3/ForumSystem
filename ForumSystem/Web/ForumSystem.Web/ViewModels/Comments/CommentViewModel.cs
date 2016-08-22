﻿namespace ForumSystem.Web.ViewModels.Comments
{
    using System;
    using System.Linq;

    using AutoMapper;

    using ForumSystem.Data.Models;
    using ForumSystem.Web.Infrastructure.Mapping;

    public class CommentViewModel : IMapFrom<Comment>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string Post { get; set; }

        public int AnswerId { get; set; }

        public string AuthorId { get; set; }

        public string AuthorPictureUrl { get; set; }

        public string Author { get; set; }

        public int ReportsCount { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int LikesCount { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentViewModel>()
                .ForMember(c => c.Author, config => config.MapFrom(c => c.Author.UserName));
            configuration.CreateMap<Comment, CommentViewModel>()
                .ForMember(c => c.AuthorPictureUrl, config => config.MapFrom(c => c.Author.PictureUrl));
            configuration.CreateMap<Comment, CommentViewModel>()
                .ForMember(c => c.ReportsCount, config => config.MapFrom(c => c.Reports.Count(r => !r.IsDeleted)));
            configuration.CreateMap<Comment, CommentViewModel>()
                .ForMember(c => c.LikesCount, config => config.MapFrom(c => c.Likes.Count(l => !l.IsDeleted)));
            configuration.CreateMap<Comment, CommentViewModel>()
                .ForMember(c => c.Post, config => config.MapFrom(c => c.Answer.Post.Title));
        }
    }
}