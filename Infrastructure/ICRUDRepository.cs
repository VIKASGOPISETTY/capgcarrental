namespace CAPG-CAR-RENTAL-PROJECT.Infrastructure
{
    public interface ICRUDRepository<TEntity, TIdentity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetDetails(TIdentity id);
        void Create(TEntity item);
        void Update(TEntity item);
        void Delete(TIdentity id);
    }
}