using System.Linq;

namespace System.Collections.Generic
{
    internal static class EnumerableExtensions_Class {

        public static IEnumerable<T> WhereIsNotNull<T>(this IEnumerable<T?>? This) where T : class {
            return This.EmptyIfNull().OfType<T>();
        }

    }

}
