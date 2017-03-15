using System.Collections.Generic;
using Xunit;

namespace CspBuilder.Tests
{
    public class CspBuilderShould
    {
        private static readonly string _defaultSrc = "default-src";
        private static readonly string _scriptSrc = "script-src";
        private static readonly string _pluginTypes = "plugin-types";
        private static readonly string _blockAllMixedContent = "block-all-mixed-content";

        private static readonly string _uri = "www.google.com";
        private static readonly string _mimeType = "application";
        private static readonly string _mimeSubtype = "pdf";

        public static IEnumerable<object[]> ConstructPoliciesData()
        {
            yield return new object[]
            {
                new CspBuilder().DefaultSrc.AddSelf().Build(),
                $"{_defaultSrc} 'self';"
            };

            yield return new object[]
            {
                new CspBuilder().DefaultSrc.AddUri(_uri).Build(),
                $"{_defaultSrc} {_uri};"
            };

            yield return new object[]
            {
                new CspBuilder().ScriptSrc.AddUnsafeEval().Build(),
                $"{_scriptSrc} 'unsafe-eval';"
            };

            yield return new object[]
            {
                new CspBuilder().ScriptSrc.AddUnsafeInline().Build(),
                $"{_scriptSrc} 'unsafe-inline';"
            };

            yield return new object[]
            {
                new CspBuilder().PluginType.AddMime(_mimeType).Build(),
                $"{_pluginTypes} {_mimeType};"
            };

            yield return new object[]
            {
                new CspBuilder().PluginType.AddMime(_mimeType, _mimeSubtype).Build(),
                $"{_pluginTypes} {_mimeType}/{_mimeSubtype};"
            };

            yield return new object[]
            {
                new CspBuilder().BlockAllMixedContent.Build(),
                $"{_blockAllMixedContent};"
            };
        }

        [Theory]
        [MemberData(nameof(ConstructPoliciesData))]
        public void ConstructPolicies(string actual, string expectation)
        {
            Assert.Equal(expectation, actual);
        }

        [Fact]
        public void NotIncludeEmptyValueDirectives()
        {
            var csp = new CspBuilder().ScriptSrc.Build();
            Assert.Equal("", csp);
        }

        [Fact]
        public void BeChainable()
        {
            var csp = new CspBuilder().DefaultSrc.AddSelf().ScriptSrc.AddSelf().Build();
            Assert.Equal($"{_defaultSrc} 'self'; {_scriptSrc} 'self';", csp);
        }
    }
}
