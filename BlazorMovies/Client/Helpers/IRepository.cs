using BlazorMovies.Shared;

namespace BlazorMovies.Client.Helpers
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}
