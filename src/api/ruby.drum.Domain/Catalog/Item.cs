namespace Ruby.Drum.Domain.Catalog;

public class Item
{   
    public int ID { get; set;}
    public string Name { get; set;}
    public string Description { get; set;}
    public required string Brand { get; set;}
    public decimal Price { get; set;}
    public List<Rating> Ratings { get; set; } = new List<Rating>();

    public Item(string name, string description, string brand, decimal price)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name is required");
        }

        if(string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException("Description is required");
        }

        if(string.IsNullOrWhiteSpace(brand))
        {
            throw new ArgumentException("Brand is required");
        }

        if(price < 0)
        {
            throw new ArgumentException("Price must be higher than 0");
        }

        Name = name;
        Description = description;
        Brand = brand;
        Price = price;
    }

    public void AddRating(Rating rating)
    {
        Ratings.Add(rating);
    }
}

public class Rating
{
    public int Stars { get; set;}
    public string UserName { get; set;}
    public string? Review { get; set;}

    public Rating(int stars, string userName, string review)
    {
        if(stars < 1 || stars > 5)
        {
            throw new ArgumentException("Stars must be between 1 and 5");
        }

        if(string.IsNullOrWhiteSpace(userName))
        {
            throw new ArgumentException("User name is required");
        }

        Stars = stars;
        UserName = userName;
        Review = review;
    }
}
