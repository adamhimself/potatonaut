﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Potatonaut.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public ICollection<UserTask> UserTasks { get; set; }
    }
}
