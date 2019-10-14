using System;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFBugGithubSample.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                if (entity.ClrType.GetProperty(DbContextUtility.IsDeletedProperty) != null)
                {
                    modelBuilder.Entity(entity.ClrType)
                        .HasQueryFilter(DbContextUtility.GetIsDeletedRestriction(entity.ClrType));
                }
            }

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }

    public static class DbContextUtility
    {
        public const string IsDeletedProperty = "Deleted";

        public static readonly MethodInfo PropertyMethod = typeof(EF)
            .GetMethod(nameof(EF.Property), BindingFlags.Static | BindingFlags.Public)
            .MakeGenericMethod(typeof(bool));

        public static LambdaExpression GetIsDeletedRestriction(Type type)
        {
            ParameterExpression parm = Expression.Parameter(type, "it");
            MethodCallExpression prop = Expression.Call(PropertyMethod, parm, Expression.Constant(IsDeletedProperty));
            BinaryExpression condition = Expression.MakeBinary(ExpressionType.Equal, prop, Expression.Constant(false));
            LambdaExpression lambda = Expression.Lambda(condition, parm);
            return lambda;
        }
    }
}
