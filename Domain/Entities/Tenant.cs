using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Tenant : Entity<Guid>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime StartedDate { get; set; }
    public DateTime? FinishedDate { get; set; } = null;

    public Tenant()
    {

    }

    public Tenant(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}
