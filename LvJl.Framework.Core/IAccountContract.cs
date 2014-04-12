using System.Linq;
using LvJl.Component.Tools;
using LvJl.Framework.Core.Models;

namespace LvJl.Framework.Core
{
    /// <summary>
    /// 账户模块核心业务契约
    /// </summary>
    public interface IAccountContract
    {
        /// <summary>
        /// 获取 用户信息查询数据集
        /// </summary>
        IQueryable<SysUser> SysUsers { get; }

        /// <summary>
        /// 获取用户扩展信息查询数据集
        /// </summary>
        IQueryable<UserExtend> UserExtends { get; }

        /// <summary>
        /// 获取 登录信息查询数据集
        /// </summary>
        IQueryable<LoginLog> LoginLogs { get; }

        /// <summary>
        /// 获取 角色信息查询数据集
        /// </summary>
        IQueryable<SysRole> SysRoles { get; } 
        
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        OperationResult Login(LoginInfo loginInfo);
    }
}
