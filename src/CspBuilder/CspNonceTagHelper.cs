using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CspBuilder
{
    [HtmlTargetElement("*", Attributes = CspNonceAttributeName)]
    public class CspNonceTagHelper: TagHelper
    {
        private const string CspNonceAttributeName = "csp-nonce";

        [HtmlAttributeName(CspNonceAttributeName)]
        public Guid CspNonce { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("nonce", CspNonce.ToString());
        }
    }
}
