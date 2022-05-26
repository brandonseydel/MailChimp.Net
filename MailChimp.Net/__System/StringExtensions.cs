using System.Collections.Generic;
using System.Linq;

namespace System {


    internal static class StringExtensions {

       


        public static string ToStringSafe(this object? This) {
            var ret = (This?.ToString()).Coalesce();
            
            return ret;
        }

        public static string Coalesce(this IEnumerable<string?>? This) {
            var ret = EnumerableExtensions.EmptyIfNull(This)
                .WhereIsNotNull()
                .FirstOrDefault()
                ?? Strings.Empty
                ;

            return ret;
        }


        public static string Coalesce(this string? This, params string?[] Values) {
            var ret = This is { } V1
                ? V1
                : Values.Coalesce()
                ;

            return ret;
        }

        public static string TrimSafe(this string? This) {
            var ret = This
                .Coalesce()
                .Trim()
                ;

            return ret;
        }


        private delegate bool TrimMethod(string Element, ref string Input);

        private static string TrimInternal(this string? This, IEnumerable<string?>? ItemsToTrim, TrimMethod Method) {
            var ret = This.Coalesce();
            while (true) {
                var Changed = false;

                foreach (var item in ItemsToTrim.EmptyIfNull<string?>().WhereIsNotNullOrEmpty()) {

                    if (Method(item, ref ret)) {
                        Changed = true;
                    }
                }

                if (!Changed) {
                    break;
                }

            }

            return ret;
        }


      


    }

}
