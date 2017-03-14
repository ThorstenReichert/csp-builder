using System.Collections.Generic;
using System.Linq;

namespace BarSpace.CspBuilder.DirectiveBuilder
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
            var directive = name;
            if (Content.Any())
            {
                directive += " " + string.Join(" ", Content);
            }
            directive += ";";

            return directive;
        }
    }
}