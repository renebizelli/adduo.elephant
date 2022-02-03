namespace adduo.elephant.utilities.entries
{
    public interface IEntryValidation<T>
    {
        void Set(IEntry<T> entry);
        void Validate();
    }
}
