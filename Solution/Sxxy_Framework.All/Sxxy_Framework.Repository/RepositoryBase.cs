using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Sxxy_Framework.DataAccess;
using Sxxy_Framework.Model;

namespace Sxxy_Framework.Repository
{

    public abstract class RepositoryBase<TEntity> : RepositoryBase<TEntity, Guid> where TEntity : BaseEntity
    {
        protected RepositoryBase(DataContent dataContent) : base(dataContent)
        {
        }
    }
    public class RepositoryBase<TEntity, TPrimaryKey> : Model.IRepository<TEntity, TPrimaryKey> where TEntity : BaseEntity<TPrimaryKey>
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
        List<TEntity> Model.IRepository<TEntity, TPrimaryKey>.GetAllList()
        {
            return _dataContent.Set<TEntity>().ToList();
        }
        /// <summary>
        /// 根据lambda表达式获取实体集合
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        List<TEntity> Model.IRepository<TEntity, TPrimaryKey>.GetAllList(Expression<Func<TEntity, bool>> predicate)
        {
            return _dataContent.Set<TEntity>().Where(predicate).ToList();
        }
        /// <summary>
        /// 根据主键获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Model.IRepository<TEntity, TPrimaryKey>.Get(TPrimaryKey id)
        {
            return _dataContent.Set<TEntity>().FirstOrDefault(CreateEqualityExpressionForId(id));
        }
        bool Model.IRepository<TEntity, TPrimaryKey>.Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        bool Model.IRepository<TEntity, TPrimaryKey>.Delete(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        TEntity Model.IRepository<TEntity, TPrimaryKey>.FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        TEntity Model.IRepository<TEntity, TPrimaryKey>.Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        TEntity Model.IRepository<TEntity, TPrimaryKey>.InsertOrUpdate(TEntity entity)
        {
            throw new NotImplementedException();
        }

        TEntity Model.IRepository<TEntity, TPrimaryKey>.Update(TEntity entity)
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
    }
}
