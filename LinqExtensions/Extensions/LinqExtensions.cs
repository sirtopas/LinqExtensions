using System.Collections.Generic;
using System.Linq;

namespace LinqExtensions.Extensions
{
    public static class LinqExtensions
    {
        public static IEnumerable<MyObject> SortBy(this IEnumerable<MyObject> objects, string sortBy)
        {
            switch (sortBy)
            {
                case "name":
                    return objects.OrderBy(o => o.ObjectName);
                case "id":
                    return objects.OrderBy(o => o.ObjectId);
                case "start_date":
                    return objects.OrderBy(o => o.StartDate);
                case "end_date":
                    return objects.OrderBy(o => o.EndDate);
                default:
                    return objects.OrderBy(o => o.ObjectName);
            }
        }
    }
}
