using EntityLayer.Entities.Interfaces;
using EntityLayer.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Entities.Concrete
{
    public class AppUser : IdentityUser, IBaseEntity
        //In this row; i used IdentityUser that was built from CoreIdentity.It provides numerous process for my user login in terms of registiration,role vs.
    {
        //In this life time ; i added properties which is not included by Identity.
        public string Occupation { get; set; }
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get ; set; }
        public DateTime? UpdateDate { get ; set ; }
        public DateTime? DeleteDate { get ; set ; }

        private Status _status = Status.active;
        public Status Status { get ; set ; }
    }
}
