class MovieCollection
{
    private List<string> movies = new List<string>();
    private List<string> watchlist = new List<string>();
    private Dictionary<string, int> ratings = new Dictionary<string, int>();
    private List<string> watchHistory = new List<string>();

    // Method to browse available movies
    public List<string> BrowseMovies()
    {
        return movies;
    }

    // Method to add a movie to the watchlist
    public void AddToWatchlist(string movie)
    {
        if (movies.Contains(movie) && !watchlist.Contains(movie))
        {
            watchlist.Add(movie);
        }
    }

    // Method to rate a movie
    public void RateMovie(string movie, int rating)
    {
        if (movies.Contains(movie))
        {
            ratings[movie] = rating;
        }
    }

    // Method to track watch history
    public void AddToWatchHistory(string movie)
    {
        if (movies.Contains(movie))
        {
            watchHistory.Add(movie);
        }
    }

    // Method to get recommendations based on watch history
    public List<string> GetRecommendations()
    {
        // Placeholder for recommendation logic
        return new List<string>(); // Return an empty list for now
    }
}