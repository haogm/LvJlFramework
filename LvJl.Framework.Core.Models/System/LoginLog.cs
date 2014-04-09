using System;
using LvJl.Component.Tools;

namespace LvJl.Framework.Core.Models
{
    public class LoginLog:EntityBase<Guid>
    {
        public LoginLog()
        {
            Id = CombHelper.NewComb();
        }

        /// <summary>
        /// 
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual SysUser User { get; set; }
    }
}
