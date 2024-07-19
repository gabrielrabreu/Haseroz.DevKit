namespace Haseroz.DevKit;

public interface IReadRepository<T> where T : IAggregateRoot
{
    Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
