using CspBuilder.Constants;
using CspBuilder.DirectiveBuilder;

namespace CspBuilder
{
    public class CspBuilder
    {
        private readonly CspBuilderRegister _register;

        public CspBuilder()
        {
            _register = new CspBuilderRegister();
        }

        protected CspBuilder(CspBuilderRegister register)
        {
            _register = register;
        }

        /// <summary>
        /// Returns the string representation of the content security policy.
        /// </summary>
        public string Build()
        {
            return _register.ToString();
        }

        /// <summary>
        /// The default-src is the default policy for loading content such as JavaScript, Images, CSS, Font's, AJAX requests, Frames, HTML5 Media. See the Source List Reference for possible values.
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public SourceDirective DefaultSrc 
            => _register.GetOrCreate(CspDirectives.DefaultSrc, register => new SourceDirective(register));

        /// <summary>
        /// Defines valid sources of JavaScript. 
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public SourceDirective ScriptSrc 
            => _register.GetOrCreate(CspDirectives.ScriptSrc, register => new SourceDirective(register));

        /// <summary>
        /// Defines valid sources of stylesheets. 
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public SourceDirective StyleSrc
            => _register.GetOrCreate(CspDirectives.StyleSrc, register => new SourceDirective(register));

        /// <summary>
        /// Defines valid sources of images.
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public SourceDirective ImgSrc
            => _register.GetOrCreate(CspDirectives.ImgSrc, register => new SourceDirective(register));

        /// <summary>
        /// Applies to XMLHttpRequest (AJAX), WebSocket or EventSource. If not allowed the browser emulates a 400 HTTP status code. 
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public SourceDirective ConnectSrc
            => _register.GetOrCreate(CspDirectives.ConnectSrc, register => new SourceDirective(register));

        /// <summary>
        /// Defines valid sources of fonts. 
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public SourceDirective FontSrc
            => _register.GetOrCreate(CspDirectives.FontSrc, register => new SourceDirective(register));

        /// <summary>
        /// Defines valid sources of plugins, eg &lt;object&gt;, &lt;embed&gt; or &lt;applet&gt;.
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public SourceDirective ObjectSrc
            => _register.GetOrCreate(CspDirectives.ObjectSrc, register => new SourceDirective(register));

        /// <summary>
        /// Defines valid sources of audio and video, eg HTML5 &lt;audio&gt;, &lt;video&gt; elements.
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public SourceDirective MediaSrc
            => _register.GetOrCreate(CspDirectives.MediaSrc, register => new SourceDirective(register));

        /// <summary>
        /// Defines valid sources for loading frames. child-src is preferred over this deprecated directive.
        /// </summary>
        /// <remarks>Deprecated</remarks>
        public SourceDirective FrameSrc
            => _register.GetOrCreate(CspDirectives.FrameSrc, register => new SourceDirective(register));

        /// <summary>
        /// Enables a sandbox for the requested resource similar to the iframe sandbox attribute.The sandbox applies a same origin policy, prevents popups, plugins and script execution is blocked. You can keep the sandbox value empty to keep all restrictions in place, or add values: allow-forms allow-same-origin allow-scripts allow-popups, allow-modals, allow-orientation-lock, allow-pointer-lock, allow-presentation, allow-popups-to-escape-sandbox, and allow-top-navigation
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public Sandbox Sandbox 
            => _register.GetOrCreate(CspDirectives.Sandbox, register => new Sandbox(register));

        /// <summary>
        /// Instructs the browser to POST a reports of policy failures to this URI. You can also append -Report-Only to the HTTP header name to instruct the browser to only send reports (does not block anything). 
        /// </summary>
        /// <remarks>CSP Level 1</remarks>
        public ReportUri ReportUri
            => _register.GetOrCreate(CspDirectives.ReportUri, register => new ReportUri(register));

        /// <summary>
        /// Defines valid sources for web workers and nested browsing contexts loaded using elements such as &lt;frame&gt; and &lt;iframe&gt; 
        /// </summary>
        /// <remarks>CSP Level 2</remarks>
        public SourceDirective ChildSrc
            => _register.GetOrCreate(CspDirectives.ChildSrc, register => new SourceDirective(register));

        /// <summary>
        /// Defines valid sources that can be used as a HTML &lt;form&gt; action. 
        /// </summary>
        /// <remarks>CSP Level 2</remarks>
        public SourceDirective FormAction
            => _register.GetOrCreate(CspDirectives.FormAction, register => new SourceDirective(register));

        /// <summary>
        /// Defines valid sources for embedding the resource using &lt;frame&gt; &lt;iframe&gt; &lt;object&gt; &lt;embed&gt; &lt;applet&gt;. Setting this directive to 'none' should be roughly equivalent to X-Frame-Options: DENY
        /// </summary>
        /// <remarks>CSP Level 2</remarks>
        public SourceDirective FrameAncestors
            => _register.GetOrCreate(CspDirectives.FrameAncestors, register => new SourceDirective(register));

        /// <summary>
        /// Defines valid MIME types for plugins invoked via &lt;object&gt; and &lt;embed&gt;. To load an &lt;applet&gt; you must specify application/x-java-applet.
        /// </summary>
        /// <remarks>CSP Level 2</remarks>
        public PluginType PluginType 
            => _register.GetOrCreate(CspDirectives.PluginTypes, register => new PluginType(register));

        /// <summary>
        /// All mixed content resource requests are blocked, including both active and passive mixed content.
        /// This also applies to &lt;iframe&gt; documents, ensuring the entire page is mixed content free.
        /// </summary>
        /// <remarks>CR</remarks>
        public DeclarativeDirective BlockAllMixedContent
            => _register.GetOrCreate(CspDirectives.BlockAllMixedContent, register => new DeclarativeDirective(register));

        /// <summary>
        /// instructs user agents to treat all of a site's insecure URLs (those served over HTTP) as though they have been replaced with secure URLs (those served over HTTPS).
        /// This directive is intended for web sites with large numbers of insecure legacy URLs that need to be rewritten.
        ///
        /// The upgrade-insecure-requests directive is evaluated before block-all-mixed-content and if it is set, the latter is effectively a no-op.
        /// It is recommended to set one directive or the other, but not both.
        /// </summary>
        /// <remarks>CR</remarks>
        public DeclarativeDirective UpgradeInsecureRequests
            => _register.GetOrCreate(CspDirectives.UpgradeInsecureRequests, register => new DeclarativeDirective(register));
    }
}
