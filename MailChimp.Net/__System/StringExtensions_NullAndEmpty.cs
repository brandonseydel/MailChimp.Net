using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace System
{

    internal static class StringExtensions_NullAndEmpty {
        public static bool IsNullOrEmpty([NotNullWhen(false)] this string? This) {
            return string.IsNullOrEmpty(This);
        }

        public static bool IsNotNullOrEmpty([NotNullWhen(true)] this string? This) {
            return !string.IsNullOrEmpty(This);
        }

        public static bool IsBlank([NotNullWhen(false)] this string? This) {
            return string.IsNullOrWhiteSpace(This);
        }

        public static bool IsNotBlank([NotNullWhen(true)] this string? This) {
            return !string.IsNullOrWhiteSpace(This);
        }

        public static IEnumerable<string?> WhereIsNullOrEmpty(this IEnumerable<string?>? This) {
            return EnumerableExtensions.EmptyIfNull(This)
                .Where(x => x.IsNullOrEmpty())
                ;
        }

        public static IEnumerable<string> WhereIsNotNullOrEmpty(this IEnumerable<string?>? This) {
            return EnumerableExtensions.EmptyIfNull(This)
                .Where(x => x.IsNotNullOrEmpty())
                .OfType<string>()
                ;
        }

        public static IEnumerable<string> WhereIsBlank(this IEnumerable<string?>? This) {
            return EnumerableExtensions.EmptyIfNull(This)
                .Where(x => x.IsBlank())
                .OfType<string>()
                ;
        }

        public static IEnumerable<string> WhereIsNotBlank(this IEnumerable<string?>? This) {
            return EnumerableExtensions.EmptyIfNull(This)
                .Where(x => x.IsNotBlank())
                .OfType<string>()
                ;
        }

    }

}
