using AutoMapper;
using LocalTaste.Domain.POCO;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace LocalTaste.Mvc.Models
{
    public class MapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<User, CustomIdentityUser>()
                .IgnoreAllNonExisting()
                .ReverseMap()
                .IgnoreAllNonExisting();
        }
    }

    public static class MapperExtensions
    {
        public static IMappingExpression<TSource, TDestination> IgnoreMember<TSource, TDestination>(this IMappingExpression<TSource, TDestination> mapping, Expression<Func<TDestination, object>> destinationMember)
        {
            return mapping.ForMember(destinationMember, m => m.Ignore());
        }

        public static IMappingExpression<TSource, TDestination> IgnoreAllNonExisting<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression)
        {
            if (expression == null)
            {
                return null;
            }

            var sourceType = typeof(TSource);
            var destinationType = typeof(TDestination);
            var existingMaps = Mapper.GetAllTypeMaps().First(x => x.SourceType.Equals(sourceType) && x.DestinationType.Equals(destinationType));

            foreach (var property in existingMaps.GetUnmappedPropertyNames())
            {
                expression.ForMember(property, opt => opt.Ignore());
            }

            return expression;
        }
    }
}