using System;

namespace CspBuilder.DirectiveBuilder
{
    /// <summary>
    /// Content security policy builder for plugin-type directive.
    /// </summary>
    public class PluginType : ValueDirective
    {
        public PluginType(CspBuilderRegister register) : base(register)
        {
        }

        /// <summary>
        /// Add plugin MIME type to directive.
        /// </summary>
        /// <param name="type">MIME type of plugin</param>
        /// <param name="subtype">MIME subtype of plugin</param>
        /// <example>AddMime("application", "pdf")</example>
        /// <exception cref="ArgumentException">Invalid MIME type</exception>
        public PluginType AddMime(string type, string subtype = null)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("MIME type must not be null of whitespace");
            }

            var content = type;
            if (string.IsNullOrWhiteSpace(subtype))
            {
                content += "/" + subtype;
            }

            Content.Add(content);

            return this;
        }
    }
}