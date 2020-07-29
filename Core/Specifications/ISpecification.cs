using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T,bool>> Critiria {get;}
         List<Expression<Func<T,object>>>  Includes {get;}
    }
}