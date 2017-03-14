namespace CspBuilder.DirectiveBuilder
{
    public abstract class Directive: CspBuilder
    {
        protected Directive(CspBuilderRegister register) : base(register)
        {
        }

        public abstract string BuildFromName(string name);
    }
}
