using BarSpace.CspBuilder.Constants;

namespace BarSpace.CspBuilder.DirectiveBuilder
{
    /// <summary>
    /// Content security policy builder for sandbox directive.
    /// </summary>
    public class Sandbox : ValueDirective
    {
        public Sandbox(CspBuilderRegister register) : base(register)
        {
        }

        private Sandbox Add(string value)
        {
            Content.Add(value);
            return this;
        }

        /// <summary>
        /// Add 'allow-forms' to directive
        /// </summary>
        public Sandbox AllowForms()
        {
            return Add(CspSandboxDirectiveValues.AllowForms);
        }

        /// <summary>
        /// Add 'allow-modals' to directive
        /// </summary>
        public Sandbox AllowModals()
        {
            return Add(CspSandboxDirectiveValues.AllowModals);
        }

        /// <summary>
        /// Add 'allow-orientation-lock' to directive
        /// </summary>
        public Sandbox AllowOrientationLock()
        {
            return Add(CspSandboxDirectiveValues.AllowOrientationLock);
        }

        /// <summary>
        /// Add 'allow-pointer-lock' to directive
        /// </summary>
        public Sandbox AllowPointerLock()
        {
            return Add(CspSandboxDirectiveValues.AllowPointerLock);
        }

        /// <summary>
        /// Add 'allow-popups' to directive
        /// </summary>
        public Sandbox AllowPopups()
        {
            return Add(CspSandboxDirectiveValues.AllowPopups);
        }

        /// <summary>
        /// Add 'allow-popups-to-escape-sandbox' to directive
        /// </summary>
        public Sandbox AllowPopupsToEscapeSandbox()
        {
            return Add(CspSandboxDirectiveValues.AllowPopupsToEscapeSandbox);
        }

        /// <summary>
        /// Add 'allow-presentation' to directive
        /// </summary>
        public Sandbox AllowPresentation()
        {
            return Add(CspSandboxDirectiveValues.AllowPresentation);
        }

        /// <summary>
        /// Add 'allow-same-origin' to directive
        /// </summary>
        public Sandbox AllowSameOrigin()
        {
            return Add(CspSandboxDirectiveValues.AllowSameOrigin);
        }

        /// <summary>
        /// Add 'allow-scripts' to directive
        /// </summary>
        public Sandbox AllowScripts()
        {
            return Add(CspSandboxDirectiveValues.AllowScripts);
        }

        /// <summary>
        /// Add 'allow-top-navigation' to directive
        /// </summary>
        public Sandbox AllowTopNavigation()
        {
            return Add(CspSandboxDirectiveValues.AllowTopNavigation);
        }
    }
}