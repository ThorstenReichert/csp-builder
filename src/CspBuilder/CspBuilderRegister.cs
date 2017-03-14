using System;
using System.Collections.Generic;
using System.Linq;
using CspBuilder.DirectiveBuilder;

namespace CspBuilder
{
    /// <summary>
    /// Register of all used policy builders.
    /// </summary>
    public class CspBuilderRegister
    {
        private readonly IDictionary<string, Directive> _builderRegister = new Dictionary<string, Directive>();

        /// <summary>
        /// Checks, if policy builder for specified directive has already been instanciated in the current policy build process and returns it.
        /// If none exists, a new builder for the directive is created and returned.
        /// </summary>
        /// <typeparam name="TBuilder">Type of the policy builder</typeparam>
        /// <param name="directiveName">Name of the directive</param>
        /// <param name="factory">Factory to create instances of TBuilder</param>
        /// <returns>Policy builder of type TBuilder</returns>
        public TBuilder GetOrCreate<TBuilder>(string directiveName, Func<CspBuilderRegister, TBuilder> factory) where TBuilder: Directive
        {
            Directive builder;
            if (!_builderRegister.TryGetValue(directiveName, out builder))
            {
                builder = factory(this);
                _builderRegister[directiveName] = builder;
            }

            return builder as TBuilder;
        }

        /// <summary>
        /// Returns the string representation of the content security policy.
        /// </summary>
        public override string ToString()
        {
            if (!_builderRegister.Any())
            {
                return null;
            }

            var directives = new List<string>();
            foreach (var keyValuePair in _builderRegister)
            {
                var content = keyValuePair.Value.BuildFromName(keyValuePair.Key);
                directives.Add(content);
            }

            return string.Join(" ", directives);
        }
    }
}
