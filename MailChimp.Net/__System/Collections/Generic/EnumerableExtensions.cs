using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Collections.Generic {



    internal static class EnumerableExtensions {


        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T>? source) {
            return Coalesce(source, Enumerable.Empty<T>());
        }


        public static IEnumerable<T> Coalesce<T>(this IEnumerable<T>? source, params T[] Values) {
            return Coalesce(source, Values.AsEnumerable());
        }

        public static IEnumerable<T> Coalesce<T>(this IEnumerable<T>? source, params IEnumerable<T>?[] Values) {
            var ret = source is { } V1
                ? V1
                : Values.CoalesceInternal()
                ;

            return ret;

        }

        private static IEnumerable<T> CoalesceInternal<T>(this IEnumerable<IEnumerable<T>?>? This) {
            var ret = default(IEnumerable<T>?);

            if (This is { } V1) {
                foreach (var item in V1) {
                    if (item is { } V2) {
                        ret = V2;
                        break;
                    }
                }
            }

            ret ??= Enumerable.Empty<T>();

            return ret;
        }

       


    }

}
