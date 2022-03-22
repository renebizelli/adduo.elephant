namespace adduo.elephant.domain.entities.debts_template
{
    public class RecurrentTemplate : DebtTemplate
    {
        public RecurrentTemplate()
        {
            Type = enums.DebtType.recurrent;
        }
    }
}
