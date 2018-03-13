﻿using System.Threading.Tasks;
using PagedList.Core;
using VirtoCommerce.Storefront.Model.Lists;

namespace VirtoCommerce.Storefront.Model.Lists.Services
{
    public interface IWishlistService
    {
        Task<IPagedList<Wishlist>> SearchWishlistsAsync(WishlistSearchCriteria criteria);

        Task DeleteListsByIdsAsync(string[] ids);
    }
}