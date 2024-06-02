namespace GA.TradeMarket.Application.Interfaces
{
    public interface Icrud<T,K> where T : class
    {
        Task<IEnumerable<T>> GetAllWithDetailsAsync();
        Task<T> GetByIdAsync(long Id);
        Task AddAsync(K item);
        Task DeleteAsync(long item);
        Task UpdateAsync(K item);
    }

}
