namespace PrincipioDaResponsabilidadeUnica_Solid
{
    public abstract class Cargo
    {
        public IRegraDeSalario Regra { get; private set; }
        public Cargo(IRegraDeSalario regra)
        {
            this.Regra = regra;
        }

    }
}
