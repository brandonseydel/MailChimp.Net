using System.Collections.Generic;

namespace System
{
    internal static class StringExtensions_Join {
        private const string Join_DefaultSeparator = "";
        public static string Join<T>(this IEnumerable<T>? This, string Separator = Join_DefaultSeparator, int RepeatSeparator = 1) {
            var NewSeparator = Strings.Empty;
            for (var i = 0; i < RepeatSeparator; i++) {
                NewSeparator += Separator;
            }

            var ret = string.Join(NewSeparator, This.EmptyIfNull());

            return ret;
        }


        public static string JoinSpace<T>(this IEnumerable<T>? This, int RepeatSeparator = 1) {
            return This.Join(Strings.Space, RepeatSeparator);
        }

        public static string JoinSeparator<T>(this IEnumerable<T>? This, int RepeatSeparator = 1) {
            return This.Join(Strings.Separator, RepeatSeparator);
        }

      



    }
}
