﻿using Education.Domain.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Domain.Entities
{
    public class GroupModel
    {
        public Guid Id { get; set; }
        public string GroupName { get; set; }
        //Pasdagi ma'lumotlargaCRUD amali bo'lmaydi
        public UserModel User { get; set; }
        public virtual List<UserModel> Students { get; set; }
        public Guid CourseId { get; set; }
        public virtual CourseModel Course { get; set; }
    }
}