using Arnkels.Wishlists.Shared.Domain;

namespace Arnkels.Wishlists.WebUI.Services;

public interface IWishlistDataService
{
    Task<IEnumerable<Wishlist>> GetAllWishlists();
    Task<Wishlist> GetWishlistDetails(int wishlistId);
    Task<Wishlist> AddWishlist(Wishlist wishlist);
    Task UpdateWishlist(Wishlist wishlist);
    Task DeleteWishlist();

    Task AddItemToWishlist(WishlistItem wishlistItem, int wishlistId);
}