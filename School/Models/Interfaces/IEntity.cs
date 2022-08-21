namespace School.Models.Interfaces
{
    public interface IEntity<Tid>
    {
        Tid Id { get; set; }
    }
}
