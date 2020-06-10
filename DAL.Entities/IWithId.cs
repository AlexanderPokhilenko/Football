namespace DAL.Entities
{
    public interface IWithId<TKey>
    {
        TKey Id { get; set; }
    }
}