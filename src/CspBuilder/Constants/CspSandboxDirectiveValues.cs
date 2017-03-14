namespace CspBuilder.Constants
{
    /// <summary>
    /// Valid values for content security policy sandbox directive.
    /// </summary>
    public static class CspSandboxDirectiveValues
    {
        public static readonly string AllowForms = "allow-forms";
        public static readonly string AllowSameOrigin = "allow-same-origin";
        public static readonly string AllowScripts = "allow-scripts";
        public static readonly string AllowPopups = "allow-popups";
        public static readonly string AllowModals = "allow-modals";
        public static readonly string AllowOrientationLock = "allow-orientation-lock";
        public static readonly string AllowPointerLock = "allow-pointer-lock";
        public static readonly string AllowPresentation = "allow-presentation";
        public static readonly string AllowPopupsToEscapeSandbox = "allow-popups-to-escape-sandbox";
        public static readonly string AllowTopNavigation = "allow-top-navigation";
    }
}
