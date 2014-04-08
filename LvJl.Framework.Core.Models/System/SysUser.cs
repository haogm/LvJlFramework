using System.Collections.Generic;
using LvJl.Component.Tools;

namespace LvJl.Framework.Core.Models
{
    public sealed class SysUser:EntityBase<int>
    {
        public SysUser()
        {
            Roles=new List<SysRole>();
            LoginLogs=new List<LoginLog>();
        }
        public string Name { get; set; }

        public string Account { get; set; }


        public string Password { get; set; }


        public string NickName { get; set; }


        public string Email { get; set; }

        public UserExtend Extend { get; set; }


        public ICollection<SysRole> Roles { get; set; }


        public ICollection<LoginLog> LoginLogs { get; set; } 
    }
}
