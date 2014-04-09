using System;

namespace LvJl.Component.Tools
{
    /// <summary>
    /// 可持久化到数据库的领域模型的基类
    /// </summary>
    [Serializable]
    public abstract class EntityBase<T>
    {
        protected EntityBase()
        {
            IsDeleted = false;
            CreateTime = DateTime.Now;
        }

        #region 属性

        /// <summary>
        /// 主键
        /// </summary>
        public T Id { get; set; }

        /// <summary>
        /// 获取或设置 获取或设置是否禁用，逻辑上的删除，非物理删除
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 获取或设置 添加时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 获取或设置 版本控制标识
        /// </summary>
        public byte[] Timestamp { get; set; }

        #endregion
    }
}

