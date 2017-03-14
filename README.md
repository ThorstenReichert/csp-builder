# csp-builder
FluidAPI-style builder for [content security policies](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy)

# usage
Select the default directive and add 'self' and www.google.com:
```c#
var builder = new CspBuilder().DefaultSrc.AddSelf().AddUri("www.google.com");
```
Get the policy string
```c#
var policy = builder.Build();    // "default-src 'self' www.google.com";
```
or build the complete <meta> tag in cshtml:
```c#
@Html.AddCsp(builder);
  // <meta http-equiv="Content-Security-Policy" content="default-src 'self' www.google.com;" />
```
Directives can easily be chained:
```c#
var builder = new CspBuilder()
                    .DefaultSrc.AddSelf().AddUri("www.google.com")  // default-src 'self' www.google.com;
                    .ScriptSrc.AddSelf().AddUnsafeEval()            // script-src 'self' 'unsafe-eval';
                    .FontSrc.None()                                 // font-src 'none';
                    .PluginType.AddMime("application", "pdf")       // plugin-type application/pdf;
                    .BlockAllMixedContent;                          // block-all-mixed-content;
```
Supports Nonces with tag-helper:
```c#
Guid nonce;
var builder = new CspBuilder().ScriptSrc.GetNonce(out nonce);

@Html.AddCsp(builder);    // <meta ... content="script-src 'nonce-<nonce-value>';" />

<script csp-nonce="nonce">    // <script nonce="<nonce-value>">
  ...
</script>
```
