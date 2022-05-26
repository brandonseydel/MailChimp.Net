namespace System.Diagnostics {
    internal interface IGetDebuggerDisplayBuilder : IGetDebuggerDisplay {
        DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder);
    }


}
