namespace Arnkels.Wishlists.Shared.Domain;

public class WishlistItem
{
    public int Id { get; set; }
    public int WishlistId { get; set; }
    public Wishlist Wishlist { get; set; }
    public string Name { get; set; }
}