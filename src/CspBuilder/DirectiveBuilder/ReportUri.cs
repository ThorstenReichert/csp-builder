using System;

namespace CspBuilder.DirectiveBuilder
{
    /// <summary>
    /// Content security policy builder for report-uri directive.
    /// </summary>
    public class ReportUri : ValueDirective
    {
        public ReportUri(CspBuilderRegister register): base(register)
        {
        }

        /// <summary>
        /// Adds URI to directive
        /// </summary>
        /// <param name="uri">URI to be added</param>
        /// <exception cref="ArgumentException">Invalid URI</exception>
        public ReportUri AddUri(string uri)
        {
            if (string.IsNullOrWhiteSpace(uri))
            {
                throw new ArgumentException("URI must not be null or whitespace");
            }

            Content.Add(uri);
            return this;
        }
    }
}