﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
//	   如存在本生成代码外的新需求，请在相同命名空间下创建同名分部类进行实现。
// </auto-generated>
//
// <copyright file="RoleRepository.generated.cs">
//		Copyright(c)2013 GMFCN.All rights reserved.
//		CLR版本：4.0.30319.239
//		开发组织：郭明锋@中国
//		公司网站：http://www.gmfcn.net
//		所属工程：GMF.Demo.Core.Data
//		生成时间：2013-09-01 16:21
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Composition;
using System.Linq;
using LvJl.Component.Data;
using LvJl.Framework.Core.Data.Repositories.System;
using LvJl.Framework.Core.Models;


namespace LvJl.Framework.Core.Data.Repositories
{
	/// <summary>
    ///   仓储操作层实现——角色信息
    /// </summary>
    [Export(typeof(ISysRoleRepository))]
    public partial class RoleRepository : EFRepositoryBase<SysRole, int>, ISysRoleRepository
    { }
}
