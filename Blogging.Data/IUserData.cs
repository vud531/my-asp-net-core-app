﻿using Blogging.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blogging.Data
{
    public interface IUserData
    {
        IEnumerable<User> GetAll();
    }
    public class InMemmoryData : IUserData
    {
        readonly List<User> users;
        public InMemmoryData()
        {
            this.users = new List<User>
            {
                new User { Id = 1, Username = "CoolKid", Bio = "I love sports and partying", Role = Role.Member },
                new User { Id = 2, Username = "CaptainAnne", Bio = "Captian of Citadeli", Role = Role.Admin },
                new User { Id = 3, Username = "WickedAndy", Bio = "I do science", Role = Role.Member },
            };
        }
        public IEnumerable<User> GetAll()
        {
            return from user in users orderby user.Username select user;
        }
    }
}
