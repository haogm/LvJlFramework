using System.Linq;
using LvJl.Component.Tools;
using LvJl.Framework.Core.Models;

namespace LvJl.Framework.Core
{
    public class AccountService:CoreServiceBase,IAccountContract
    {

        #region 属性

        #region 受保护的属性

        #endregion

        #region 公共属性

        #endregion

        #endregion

        public IQueryable<SysUser> Users { get; private set; }
        public IQueryable<UserExtend> UserExtends { get; private set; }
        public IQueryable<LoginLog> LoginLogs { get; private set; }
        public IQueryable<SysRole> Roles { get; private set; }
        public OperationResult Login(LoginInfo loginInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}
