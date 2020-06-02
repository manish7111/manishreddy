using Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepos
{
    public interface IProduct
    {
        Task<int> AddItems(Items item);
        Task<Items> FindAsync(int id);
        Task<int> DeleteItem(int id);
        void UpdateItem(Items item, int id);
        Task<int> SaveChangesAsync();
        IEnumerable<Items> GetAllItems();
        string Image(IFormFile file, int id);
        Items GetItemAsync(int id);
        Task<int> AddItemColor(Colors color);
        IList<Colors> GetItemColors(int id);
        Task<int> AddItemSize(Sizes size);
        IList<Sizes> GetItemSizes(int id);
        Task<int> AddItemDescriptions(Description size);
        Description GetDescriptionsById(int id);
        IEnumerable<SelectedItem> GetAllSelectedItems(string email);
        Task<int> AddSelectedItem(SelectedItem items);
        Task<int> DeleteSelectedItem(int id);
        Task<SelectedItem> FindSeletedItemsAsync(int id);
        bool RequestOTP(string email);
        bool VerifyOTP(AuthUser user);
        Task<int> AddAddress(Address address);
        IEnumerable<Address> GetAddress(string email);
    }
}
