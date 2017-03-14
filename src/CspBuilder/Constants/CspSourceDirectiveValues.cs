namespace BarSpace.CspBuilder.Constants
{
    /// <summary>
    /// Special values of content security police source directives.
    /// </summary>
    public static class CspSourceDirectiveValues
    { 
        /// <summary>
        /// Allows loading resources from the same origin (same scheme, host and port).
        /// </summary>
        public static readonly string Self = "'self'";

        /// <summary>
        /// Prevents loading resources from any source.
        /// </summary>
        public static readonly string None = "'none'";

        /// <summary>
        /// The strict-dynamic source expression specifies that the trust explicitly given to a script present in the markup, by accompanying it with a nonce or a hash, shall be propagated to all the scripts loaded by that root script.
        /// At the same time, any whitelist or source expressions such as 'self' or 'unsafe-inline' will be ignored.
        /// </summary>
        public static readonly string StrictDynamic = "'strict-dynamic'";

        /// <summary>
        /// Allows use of inline source elements such as style attribute, onclick, or script tag bodies (depends on the context of the source it is applied to).
        /// </summary>
        public static readonly string UnsafeInline = "'unsafe-inline'";

        /// <summary>
        /// Allows unsafe dynamic code evaluation such as JavaScript eval()
        /// </summary>
        public static readonly string UnsafeEval = "'unsafe-eval'";
    }
}
