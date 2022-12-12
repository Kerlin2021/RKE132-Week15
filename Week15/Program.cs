List<Movie> myMovies = new List<Movie>();

string[] data = GetDataFromMyFile();
//ReadDataFromArray (data);

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]); tempArray[3]);
    myMovies.Add(newMovie);
}
foreach(Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}. Raiting: {movie.Rating}");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Users\siimk\Downloads\movies.txt";
    return File.ReadAllLines(filePath);                    
}
static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}
class Movie
{
    string title;
    string year;
    string Rating;
    public string Title
    {
        get { return title; }
    }
    public string Year
    {
        get { return year; }
    }
    public string Rating
    {
        get { return Rating; }
    }
    public Movie(string _title, string _year, string _rating)
    {
        title = _title;
        year = _year;
        Rating = _rating;
    }
}