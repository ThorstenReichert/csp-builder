namespace BarSpace.CspBuilder.Constants
{
    public static class CspDirectives
    {
        // missing: sandbox, plugin-types

        /// <summary>
        /// The default-src is the default policy for loading content such as JavaScript, Images, CSS, Font's, AJAX requests, Frames, HTML5 Media. See the Source List Reference for possible values.
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public static readonly string DefaultSrc = "default-src";

        /// <summary>
        /// Defines valid sources of JavaScript. 
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public static readonly string ScriptSrc = "script-src";

        /// <summary>
        /// Defines valid sources of stylesheets. 
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public static readonly string StyleSrc = "style-src";

        /// <summary>
        /// Defines valid sources of images.
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public static readonly string ImgSrc = "img-src";

        /// <summary>
        /// Applies to XMLHttpRequest (AJAX), WebSocket or EventSource. If not allowed the browser emulates a 400 HTTP status code. 
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public static readonly string ConnectSrc = "connect-src";

        /// <summary>
        /// Defines valid sources of fonts. 
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public static readonly string FontSrc = "font-src";

        /// <summary>
        /// Defines valid sources of plugins, eg &lt;object&gt;, &lt;embed&gt; or &lt;applet&gt;.
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public static readonly string ObjectSrc = "object-src";

        /// <summary>
        /// Defines valid sources of audio and video, eg HTML5 &lt;audio&gt;, &lt;video&gt; elements.
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public static readonly string MediaSrc = "media-src";

        /// <summary>
        /// Defines valid sources for loading frames. child-src is preferred over this deprecated directive.
        /// </summary>
        /// <remarks>Deprecated</remarks>
        public static readonly string FrameSrc = "frame-src";

        /// <summary>
        /// Enables a sandbox for the requested resource similar to the iframe sandbox attribute.The sandbox applies a same origin policy, prevents popups, plugins and script execution is blocked. You can keep the sandbox value empty to keep all restrictions in place, or add values: allow-forms allow-same-origin allow-scripts allow-popups, allow-modals, allow-orientation-lock, allow-pointer-lock, allow-presentation, allow-popups-to-escape-sandbox, and allow-top-navigation
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public static readonly string Sandbox = "sandbox";

        /// <summary>
        /// Instructs the browser to POST a reports of policy failures to this URI. You can also append -Report-Only to the HTTP header name to instruct the browser to only send reports (does not block anything). 
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public static readonly string ReportUri = "report-uri";

        /// <summary>
        /// Defines valid sources for web workers and nested browsing contexts loaded using elements such as &lt;frame&gt; and &lt;iframe&gt; 
        /// </summary>
        /// <remarks>CSP Level 2</remarks>
        public static readonly string ChildSrc = "child-src";

        /// <summary>
        /// Defines valid sources that can be used as a HTML &lt;form&gt; action. 
        /// </summary>
        /// <remarks>CSP Level 2</remarks>
        public static readonly string FormAction = "form-action";

        /// <summary>
        /// Defines valid sources for embedding the resource using &lt;frame&gt; &lt;iframe&gt; &lt;object&gt; &lt;embed&gt; &lt;applet&gt;. Setting this directive to 'none' should be roughly equivalent to X-Frame-Options: DENY
        /// </summary>
        /// <remarks>CSP Level 2</remarks>
        public static readonly string FrameAncestors = "frame-ancestors";

        /// <summary>
        /// Defines valid MIME types for plugins invoked via &lt;object&gt; and &lt;embed&gt;. To load an &lt;applet&gt; you must specify application/x-java-applet.
        /// </summary>
        /// <remarks>CSP Level 2</remarks>
        public static readonly string PluginTypes = "plugin-types";

        /// <summary>
        /// All mixed content resource requests are blocked, including both active and passive mixed content.
        /// This also applies to &lt;iframe&gt; documents, ensuring the entire page is mixed content free.
        /// </summary>
        /// <remarks>CR</remarks>
        public static readonly string BlockAllMixedContent = "block-all-mixed-content";

        /// <summary>
        /// instructs user agents to treat all of a site's insecure URLs (those served over HTTP) as though they have been replaced with secure URLs (those served over HTTPS).
        /// This directive is intended for web sites with large numbers of insecure legacy URLs that need to be rewritten.
        ///
        /// The upgrade-insecure-requests directive is evaluated before block-all-mixed-content and if it is set, the latter is effectively a no-op.
        /// It is recommended to set one directive or the other, but not both.
        /// </summary>
        /// <remarks>CR</remarks>
        public static readonly string UpgradeInsecureRequests = "upgrade-insecure-requests";
    }
}
