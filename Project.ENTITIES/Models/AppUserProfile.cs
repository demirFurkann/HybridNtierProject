﻿using Project.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AppUserProfile:BaseEntity,IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //RelationalProperties

        public virtual AppUser AppUser { get; set; }

    }
}
