using System;
using BarSpace.CspBuilder.Constants;

namespace BarSpace.CspBuilder.DirectiveBuilder
{
    /// <summary>
    /// Content security policy builder for source-type directives
    /// </summary>
    public class SourceDirective : ValueDirective
    {
        private bool _isNone;

        public SourceDirective(CspBuilderRegister register) : base(register)
        {
        }

        private SourceDirective Add(string uri)
        {
            if (_isNone)
            {
                throw new InvalidOperationException("Cannot add to content security policy that is none");
            }

            Content.Add(uri);
            return this;
        }

        private SourceDirective AddHash(string type, string hash)
        {
            return Add(type + "-" + hash);
        }

        /// <summary>
        /// Add uri to content security police directive.
        /// </summary>
        /// <param name="uri">uri of the source</param>
        /// <exception cref="InvalidOperationException">Attempted to add source to none policy</exception>
        /// <exception cref="ArgumentException">Invalid URI</exception>
        public SourceDirective AddUri(string uri)
        {
            if (string.IsNullOrWhiteSpace(uri))
            {
                throw new ArgumentException("URI must not be null or whitespace");
            }

            return Add(uri);
        }

        /// <summary>
        /// Refers to the origin from which the protected document is being served, including the same URL scheme and port number.
        /// Some browsers specifically exclude blob and filesystem from source directives.
        /// Sites needing to allow these content types can specify them using the Data attribute.
        /// </summary>
        /// <exception cref="InvalidOperationException">Attempted to add source to none policy</exception>
        /// <see cref="Add"/>
        public SourceDirective AddSelf()
        {
            return Add(CspSourceDirectiveValues.Self);
        }

        /// <summary>
        /// A sha256 of inline scripts or styles.
        /// When generating the hash, don't include the &lt;script&gt; or &lt;style&gt; tags and note that capitalization and whitespace matter, including leading or trailing whitespace.
        /// </summary>
        /// <param name="hash">SHA256 value</param>
        /// <exception cref="InvalidOperationException">Attempted to add source to none policy</exception>
        public SourceDirective AddSha256(string hash)
        {
            return AddHash(CspHashAlgorithms.Sha256, hash);
        }

        /// <summary>
        /// A sha384 of inline scripts or styles.
        /// When generating the hash, don't include the &lt;script&gt; or &lt;style&gt; tags and note that capitalization and whitespace matter, including leading or trailing whitespace.
        /// </summary>
        /// <param name="hash">SHA384 value</param>
        /// <exception cref="InvalidOperationException">Attempted to add source to none policy</exception>
        public SourceDirective AddSha384(string hash)
        {
            return AddHash(CspHashAlgorithms.Sha384, hash);
        }

        /// <summary>
        /// A sha512 of inline scripts or styles.
        /// When generating the hash, don't include the &lt;script&gt; or &lt;style&gt; tags and note that capitalization and whitespace matter, including leading or trailing whitespace.
        /// </summary>
        /// <param name="hash">SHA512 value</param>
        /// <exception cref="InvalidOperationException">Attempted to add source to none policy</exception>
        public SourceDirective AddSha512(string hash)
        {
            return AddHash(CspHashAlgorithms.Sha512, hash);
        }

        /// <summary>
        /// Allows the use of eval() and similar methods for creating code from strings.
        /// </summary>
        /// <exception cref="InvalidOperationException">Attempted to add source to none policy</exception>
        /// <see cref="Add"/>
        public SourceDirective AddUnsafeEval()
        {
            return Add(CspSourceDirectiveValues.UnsafeEval);
        }

        /// <summary>
        /// Allows the use of inline resources, such as inline &lt;script&gt; elements, javascript: URLs, inline event handlers, and inline &lt;style&gt; elements.
        /// </summary>
        /// <exception cref="InvalidOperationException">Attempted to add source to none policy</exception>
        /// <see cref="Add"/>
        public SourceDirective AddUnsafeInline()
        {
            return Add(CspSourceDirectiveValues.UnsafeInline);
        }

        /// <summary>
        /// A whitelist for specific inline scripts using a cryptographic nonce (number used once).
        /// The server must generate a unique nonce value each time it transmits a policy.
        /// It is critical to provide an unguessable nonce, as bypassing a resource’s policy is otherwise trivial.
        /// </summary>
        /// <param name="nonce">Guid of the nonce</param>
        /// <returns></returns>
        public SourceDirective GetNonce(out Guid nonce)
        {
            nonce = Guid.NewGuid();
            return Add($"'nonce-{nonce}'");
        }

        /// <summary>
        /// The strict-dynamic source expression specifies that the trust explicitly given to a script present in the markup, by accompanying it with a nonce or a hash, shall be propagated to all the scripts loaded by that root script.
        /// At the same time, any whitelist or source expressions such as 'self' or 'unsafe-inline' will be ignored.
        /// </summary>
        public SourceDirective StrictDynamic()
        {
            return Add(CspSourceDirectiveValues.StrictDynamic);
        }

        /// <summary>
        /// Set directive to 'none'.
        /// </summary>
        /// <see cref="Add"/>
        public SourceDirective None()
        {
            Content.Clear();
            _isNone = true;
            return Add(CspSourceDirectiveValues.None);
        }
    }
}