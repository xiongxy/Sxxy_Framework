using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Sxxy_Framework.DataAccess;
using Sxxy_Framework.Entitys;

namespace Sxxy_Framework.Repository
{

    public abstract class RepositoryBase<TEntity> : RepositoryBase<TEntity, Guid> where TEntity : BaseEntity
    {
        protected RepositoryBase(DataContent dataContent) : base(dataContent)
        {
        }
    }
    public class RepositoryBase<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : BaseEntity<TPrimaryKey>
    {
        private readonly DataContent _dataContent;
        public RepositoryBase(DataContent dataContent)
        {
            _dataContent = dataContent;
        }
        /// <summary>
        /// 获取实体集合
        /// </summary>
        /// <returns></returns>
        List<TEntity> IRepository<TEntity, TPrimaryKey>.GetAllList()
        {
            return _dataContent.Set<TEntity>().ToList();
        }
        /// <summary>
        /// 根据lambda表达式获取实体集合
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        List<TEntity> IRepository<TEntity, TPrimaryKey>.GetAllList(Expression<Func<TEntity, bool>> predicate)
        {
            return _dataContent.Set<TEntity>().Where(predicate).ToList();
        }
        /// <summary>
        /// 根据主键获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity IRepository<TEntity, TPrimaryKey>.Get(TPrimaryKey id)
        {
            return _dataContent.Set<TEntity>().FirstOrDefault(CreateEqualityExpressionForId(id));
        }
        bool IRepository<TEntity, TPrimaryKey>.Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        bool IRepository<TEntity, TPrimaryKey>.Delete(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        TEntity IRepository<TEntity, TPrimaryKey>.FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        TEntity IRepository<TEntity, TPrimaryKey>.Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        TEntity IRepository<TEntity, TPrimaryKey>.InsertOrUpdate(TEntity entity)
        {
            throw new NotImplementedException();
        }

        TEntity IRepository<TEntity, TPrimaryKey>.Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据主键构建判断表达式
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        protected static Expression<Func<TEntity, bool>> CreateEqualityExpressionForId(TPrimaryKey id)
        {
            var lambdaParam = Expression.Parameter(typeof(TEntity));
            var lambdaBody = Expression.Equal(
                Expression.PropertyOrField(lambdaParam, "Id"),
                Expression.Constant(id, typeof(TPrimaryKey))
            );

            return Expression.Lambda<Func<TEntity, bool>>(lambdaBody, lambdaParam);
        }


        /// <summary>
        /// 根据条件删除实体
        /// </summary>
        /// <param name="where">lambda表达式</param>
        /// <param name="autoSave">是否自动保存</param>
        void IRepository<TEntity, TPrimaryKey>.Delete(Expression<Func<TEntity, bool>> where, bool autoSave = true)
        {
            _dataContent.Set<TEntity>().Where(where).ToList().ForEach(it => _dataContent.Set<TEntity>().Remove(it));
            //if (autoSave)
            //Save();
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="startPage">页码</param>
        /// <param name="pageSize">单页数据数</param>
        /// <param name="rowCount">行数</param>
        /// <param name="where">条件</param>
        /// <param name="order">排序</param>
        /// <returns></returns>
        IQueryable<TEntity> IRepository<TEntity, TPrimaryKey>.LoadPageList(int startPage, int pageSize, out int rowCount, Expression<Func<TEntity, bool>> where = null, Expression<Func<TEntity, object>> order = null)
        {
            var result = from p in _dataContent.Set<TEntity>()
                         select p;
            if (where != null)
                result = result.Where(where);
            if (order != null)
                result = result.OrderBy(order);
            else
                result = result.OrderBy(m => m.Id);
            rowCount = result.Count();
            return result.Skip((startPage - 1) * pageSize).Take(pageSize);
        }
    }
}
