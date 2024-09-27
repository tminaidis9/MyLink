﻿using MyLink.Data.Repository.IRepository;
using MyLink.Data.Access;
using MyLink.Models;

namespace MyLink.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public IUserRepository User { get; set; }
        public IEducationRepository Education { get; set; }
        public IExperienceRepository Experience { get; set; }
        public IPostRepository Post { get; set; }
        public IJobRepository Job { get; set; }
        public IMessageRepository Message { get; set; }
        public IViewedPostsRepository ViewedPosts { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            User = new UserRepository(context);
            Education = new EducationRepository(context);
            Experience = new ExperienceRepository(context);
            Post = new PostRepository(context);
            Job = new JobRepository(context);
            Message = new MessageRepository(context);
            ViewedPosts = new ViewedPostsRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
