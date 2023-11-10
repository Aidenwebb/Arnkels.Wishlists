using Arnkels.Wishlists.Shared.Domain;

namespace Arnkels.Wishlists.WebUI.Services;

public class WishlistDataService : IWishlistDataService
{
    public async Task<IEnumerable<Wishlist>> GetAllWishlists()
    {
        throw new NotImplementedException();
    }

    public async Task<Wishlist> GetWishlistDetails(int wishlistId)
    {
        throw new NotImplementedException();
    }

    public async Task<Wishlist> AddWishlist(Wishlist wishlist)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateWishlist(Wishlist wishlist)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteWishlist()
    {
        throw new NotImplementedException();
    }

    public async Task AddItemToWishlist(WishlistItem wishlistItem, int wishlistId)
    {
        throw new NotImplementedException();
    }
}