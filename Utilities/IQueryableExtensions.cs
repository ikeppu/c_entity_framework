using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace c_sharp_entity_framework.Utilities
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> source,
            int page, int recordsToTake)
        {
            return source
                .Skip((page - 1) * recordsToTake)
                .Take(2);
        }
    }
}

