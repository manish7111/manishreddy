using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Common;
using Manager.Interface;
using Microsoft.AspNetCore.Http;
using Repository.IRepos;

namespace Manager.ProductManager
{
    public class ItemsProductManager : IProductManager
    {
        public readonly IProduct product;
    
        public ItemsProductManager(IProduct pro)
        {
            this.product = pro;
        }
        public Task<int> AddItems(Items items)
        {
            var result=this.product.AddItems(items);
            return result;
        }
        public Task<int> DeleteItems(int id)
        {
            var result = this.product.DeleteItem(id);
            return result;
        }
        public Task UpdateItems(Items items,int id)
        {
            this.product.UpdateItem(items, id);
            var result = this.product.SaveChangesAsync();
            return result;
        }
        public IEnumerable<Items> GetAllItemsAsync()
        {
            var list = new List<Items>();
            var result = this.product.GetAllItems();
            foreach(var item in result)
            {
                list.Add(item);
            }
            return list;
        }
        public string ImageUpload(IFormFile file,int id)
        {
            var result = this.product.Image(file, id);
            return result;
        }
        public Items GetItems(int id)
        {
            return this.product.GetItemAsync(id);
        }
        public Task<int> AddItemColor(Colors color)
        {
            var result = this.product.AddItemColor(color);
            return result;
        }
        public IList<Colors> GetItemColor(int id)
        {
            return this.product.GetItemColors(id);
        }
        public Task<int> AddItemSize(Sizes size)
        {
            var result = this.product.AddItemSize(size);
            return result;
        }
        public IList<Sizes> GetItemSize(int id)
        {
            return this.product.GetItemSizes(id);
        }
        public Task<int> AddItemDescriptionAsync(Description size)
        {
            var result = this.product.AddItemDescriptions(size);
            return result;
        }
        public Description GetDescription(int id)
        {
            return this.product.GetDescriptionsById(id);
        }
        public IEnumerable<SelectedItem> GetAllSelectedItemsAsync(string email)
        {
            var list = new List<SelectedItem>();
            var result = this.product.GetAllSelectedItems(email);
            foreach (var item in result)
            {
                list.Add(item);
            }
            return list;
        }
        public Task<int> AddSelectedItemAsync(SelectedItem size)
        {
            var result = this.product.AddSelectedItem(size);
            return result;
        }
        public Task<int> DeleteSelectedItems(int id)
        {
            var result = this.product.DeleteSelectedItem(id);
            return result;
        }
        public  bool RequestOtp(string email)
        {
            var result =  this.product.RequestOTP(email);
            return result;
        }
        public bool VerifyOtp(AuthUser user)
        {
            var result = this.product.VerifyOTP(user);
            return result;
        }

        public Task<int> AddAddress(Address address)
        {
            var result = this.product.AddAddress(address);
            return result;
        }

        public IEnumerable<Address> GetAddress(string email)
        {
            return this.product.GetAddress(email);
        }
    }
}
