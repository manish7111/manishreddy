using Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface IProductManager
    {
        Task<int> AddItems(Items items);
        Task<int> DeleteItems(int id);
        Task UpdateItems(Items items, int id);
        IEnumerable<Items> GetAllItemsAsync();
        string ImageUpload(IFormFile file, int id);
        Items GetItems(int id);
        Task<int> AddItemColor(Colors color);
        IList<Colors> GetItemColor(int id);
        Task<int> AddItemSize(Sizes size);
        IList<Sizes> GetItemSize(int id);
        Task<int> AddItemDescriptionAsync(Description size);
        Description GetDescription(int id);
        IEnumerable<SelectedItem> GetAllSelectedItemsAsync(string email);
        Task<int> AddSelectedItemAsync(SelectedItem size);
        Task<int> DeleteSelectedItems(int id);
        bool RequestOtp(string email);
        bool VerifyOtp(AuthUser user);
        Task<int> AddAddress(Address address);
        IEnumerable<Address> GetAddress(string email);
    }
}
