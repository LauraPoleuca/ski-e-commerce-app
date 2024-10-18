using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class BaseSpecification<T>(Expression<Func<T, bool>>? criteria) : ISpecification<T>
    {
        protected BaseSpecification() : this(null) { }

        public Expression<Func<T, bool>>? Criteria => criteria;

        public Expression<Func<T, object>>? OrderBy { get; private set;}

        public Expression<Func<T, object>>? OrderByDescending { get; private set;}

        protected void AddOrderBy(Expression<Func<T, object>>? orderByExpression) 
        {
            OrderBy = orderByExpression;
        }

        protected void AddOrderByDescending(Expression<Func<T, object>>? orderByDescExpression)
        {
            OrderByDescending = orderByDescExpression;
        }
    }
}
