﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.Contracts.Commands
{
    public class PostCommandcs : ICommand
    {
        private ISession session;
        private IPostService postService;
        private ICommandFactory commandFactory;

        public PostCommandcs(ISession session, IPostService postService, ICommandFactory commandFactory)
        {
            this.session = session;
            this.postService = postService;
            this.commandFactory = commandFactory;
        }

        public IMenu Execute(params string[] args)
        {
            int userId = this.session.UserId;

            string postTitle = args[0];
            string postCategory = args[1];
            string postContent = args[2];   

            int postId = this.postService.AddPost(userId, postTitle, postCategory, postContent);
            this.session.Back();
            ICommand viewPostCommand = this.commandFactory.CreateCommand("ViewPostMenu");
            return viewPostCommand.Execute(postId.ToString());
        }
    }
}
