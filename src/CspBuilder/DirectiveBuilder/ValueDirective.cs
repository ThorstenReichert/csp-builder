using System.Collections.Generic;
using System.Linq;

namespace CspBuilder.DirectiveBuilder
{
    /// <summary>
    /// Base-type for directive-specific content security policy builder.
    /// </summary>
    public abstract class ValueDirective : Directive
    {
        protected readonly HashSet<string> Content = new HashSet<string>();

        protected ValueDirective(CspBuilderRegister register) : base(register)
        {
        }

        public override string BuildFromName(string name)
        {
            if (Content.Any())
            {
                var policy = string.Join(" ", Content);
                return $"{name} {policy};";
            }

            return null;
        }
    }
}