using GraphQL.Language.AST.Extensions.Context;
using GraphQL.Language.AST.Extensions.Interfaces;

namespace GraphQL.Language.AST.Extensions
{
    public class EntityMapper<TEntityType> :
        IEntityMapper<TEntityType>
        where TEntityType : class
    {
        public virtual TEntityType Map(EntityMapContext context)
        {
            var entity = context.Start<TEntityType>();
            return entity;
        }
    }
}
