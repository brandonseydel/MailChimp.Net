namespace System.Diagnostics {
    internal static class IGetDebuggerDisplayDefaults {
        
        public static string GetDebuggerDisplay(IGetDebuggerDisplayBuilder This) {
            return This.GetDebuggerDisplayBuilder(DisplayBuilder.Create())
                  .GetDebuggerDisplay()
                  ;
        }

        public static DisplayBuilder GetDebuggerDisplayBuilder(IGetDebuggerDisplay This, DisplayBuilder Builder) {
            return Builder
                .Type.Add(This.GetType())
                ;
        }

    }


}
