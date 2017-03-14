namespace CspBuilder.DirectiveBuilder
{
    public class DeclarativeDirective: Directive
    {
        public DeclarativeDirective(CspBuilderRegister register): base(register)
        {
        }

        public override string BuildFromName(string name)
        {
            return name + ";";
        }
    }
}
