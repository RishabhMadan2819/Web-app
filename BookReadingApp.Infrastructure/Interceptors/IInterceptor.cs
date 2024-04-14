using System.Threading.Tasks;

namespace BookReadingApp.Infrastructure.Interceptors
{
    public interface IInterceptor
    {
        Task InterceptAsync();
    }
}
