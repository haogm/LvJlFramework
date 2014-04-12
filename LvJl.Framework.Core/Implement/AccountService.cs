using System.ComponentModel.Composition;
using System.Linq;
using LvJl.Component.Tools;
using LvJl.Framework.Core.Data.Repositories.System;
using LvJl.Framework.Core.Models;

namespace LvJl.Framework.Core
{
    public class AccountService:CoreServiceBase,IAccountContract
    {

        #region 属性

        #region 受保护的属性
        /// <summary>
        /// 
        /// </summary>
        [Import]
        protected ISysUserRepository SysUserRepository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Import]
        protected IUserExtendRepository UserExtendRepository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Import]
        protected ILoginLogRepository LoginLogRepository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Import]
        protected ISysRoleRepository SysRoleRepository { get; set; }
        #endregion

        #region 公共属性

        /// <summary>
        /// 
        /// </summary>
        public IQueryable<SysUser> SysUsers { get { return SysUserRepository.Entities; } }

        /// <summary>
        /// 
        /// </summary>
        public IQueryable<UserExtend> UserExtends { get { return UserExtendRepository.Entities; } }

        /// <summary>
        /// 
        /// </summary>
        public IQueryable<SysRole> SysRoles { get { return SysRoleRepository.Entities; } }

        /// <summary>
        /// 
        /// </summary>
        public IQueryable<LoginLog> LoginLogs { get { return LoginLogRepository.Entities; } }

        #endregion

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginInfo"></param>
        /// <returns></returns>
        public OperationResult Login(LoginInfo loginInfo)
        {
            PublicHelper.CheckArgument(loginInfo,"logininfo");
            var user =
                SysUserRepository.Entities.SingleOrDefault(
                    u => u.Account == loginInfo.Account || u.Email == loginInfo.Email);
            if (user==null)
            {
                return new OperationResult(OperationResultType.QueryNull,"指定的账号不存在");
            }
            if (user.Password!=loginInfo.Password)
            {
                return new OperationResult(OperationResultType.Warning,"登录密码不正确");
            }

            var loginLog = new LoginLog
            {
                IpAddress = loginInfo.IpAddress,
                User = user
            };

            LoginLogRepository.Insert(loginLog);

            return new OperationResult(OperationResultType.Success, "登录成功", user);
        }
    }
}
