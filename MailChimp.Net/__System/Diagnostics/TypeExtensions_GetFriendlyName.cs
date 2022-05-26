using System.Collections.Generic;
using System.Linq;

namespace System.Diagnostics
{
    internal static class TypeNameExtensions {

#if NET472_OR_GREATER || NETSTANDARD2_0_OR_GREATER

        public static string GetFriendlyName(this Type This) {
            var ret = "";

            var TypeCode = Type.GetTypeCode(This);

            if (TypeAliases.TryGetValue(TypeCode, out var Value)) {
                ret = Value;

            } else if (This.IsArray && This.GetElementType() is { } ArrayChildType) {
                var Name = ArrayChildType.GetFriendlyName();

                var Rank = new string(',', This.GetArrayRank() - 1);

                Name += $@"[{Rank}]";

                ret = Name;

            } else if (This.IsGenericType && This.GetGenericTypeDefinition() == typeof(Nullable<>) && This.GetGenericArguments().FirstOrDefault() is { } NullableChildType) {
                var Name = NullableChildType.GetFriendlyName() + "?";
                ret = Name;

            } else {
                var Name = This.Name;
                var Backtick = Name.IndexOf("`");
                if (Backtick > 0) {
                    Name = Name.Substring(0, Backtick);
                }

                var ChildArguments = This.GetGenericArguments().Select(x => x.GetFriendlyName()).Join(", ");
                
                if(ChildArguments.Length > 0) {
                    Name += $@"<{ChildArguments}>";
                }

                ret = Name;
            }

            return ret;
        }


        private static readonly Dictionary<TypeCode, string> TypeAliases = new() {
            [TypeCode.Empty] = "void",
            [TypeCode.DBNull] = "DBNull",
            [TypeCode.Boolean] = "bool",
            [TypeCode.Char] = "char",
            [TypeCode.SByte] = "sbyte",
            [TypeCode.Byte] = "byte",
            [TypeCode.Int16] = "short",
            [TypeCode.UInt16] = "ushort",
            [TypeCode.Int32] = "int",
            [TypeCode.UInt32] = "uint",
            [TypeCode.Int64] = "long",
            [TypeCode.UInt64] = "ulong",
            [TypeCode.Single] = "float",
            [TypeCode.Double] = "double",
            [TypeCode.Decimal] = "decimal",
            [TypeCode.String] = "string",
        };
#else
        public static string GetFriendlyName(this Type This) {
            return This.Name;
        }
#endif

        }
}
