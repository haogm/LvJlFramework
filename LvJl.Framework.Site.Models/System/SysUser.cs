using System.Collections.Generic;
using LvJl.Component.Tools;

namespace LvJl.Framework.Site.Models
{
    public class SysUser:EntityBase<int>
    {
        public string Name { get; set; }

        public string Account { get; set; }


        public string Password { get; set; }


        public string NickName { get; set; }


        public string Email { get; set; }

        public virtual UserExtend Extend { get; set; }


        public virtual ICollection<SysRole> Roles { get; set; }


        public virtual ICollection<LoginLog> LoginLogs { get; set; } 
    }
}
