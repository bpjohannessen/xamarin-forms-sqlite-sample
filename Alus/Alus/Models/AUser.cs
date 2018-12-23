using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Alus.Helpers;

namespace Alus.Models
{
    [Table("AUser")]
    public class AUser
    {
        [PrimaryKey]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public bool UserIsActive { get; set; }
        public AUser()
        {        
        }
    }

    //[Ignore]
    //public NLUser User
    //{
    //get
    //{
    //    return NLUsers.Get(CommentUserId);
    //}
    //}
}
