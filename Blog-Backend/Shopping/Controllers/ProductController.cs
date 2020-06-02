using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Manager.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        public readonly IProductManager manager;
        public ProductController(IProductManager product)
        {
            this.manager = product;
        }
       
        [Route("addItems")]
        [HttpPost]
        public async Task<IActionResult> AddProduct(Items item)
        {
            var result= await this.manager.AddItems(item);
            if (result == 1)
            {
                return this.Ok(item);
            }
            else
            {
                return this.BadRequest();
            }
        }
        [Route("deleteItems")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await this.manager.DeleteItems(id);
            if (result == 1)
            {
                return this.Ok("deleted" +""+ id); 
            }
            else
            {
                return this.BadRequest();
            }
        }
        [Route("updateItems")]
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Items items)
        {
            try
            {
                await this.manager.UpdateItems(items, items.ItemId);
                return this.Ok(items);
            }catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        [Route("getItems")]
        [HttpGet]
        public IEnumerable<Items> GetAllProducts()
        {
            return this.manager.GetAllItemsAsync();
        }
        [HttpGet]
        [Route("getItemsById")]
        public IActionResult GetByItemId(int id)
        {
            Items items = this.manager.GetItems(id);
            if (items == null)
            {
                return this.BadRequest();
            }
            return this.Ok(items);
        }
        [Route("image")]
        [HttpPost]
        public IActionResult Image(IFormFile file,int id)
        {
            try
            {
                var result = this.manager.ImageUpload(file, id);
                return this.Ok(result);
            }catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
            
        }

        ////For Color

        [HttpGet]
        [Route("getColorById")]
        public IActionResult GetColorByItemId(int id)
        {
            IList<Colors> color = this.manager.GetItemColor(id);
            if (color == null)
            {
                return this.BadRequest();
            }
            return this.Ok(color);
        }
        [Route("addColors")]
        [HttpPost]
        public async Task<IActionResult> AddColors(Colors colors)
        {
            var result = await this.manager.AddItemColor(colors);
            if (result == 1)
            {
                return this.Ok(colors);
            }
            else
            {
                return this.BadRequest();
            }
        }


        ////For Size

        [HttpGet]
        [Route("getSizeById")]
        public IActionResult GetSizeByItemId(int id)
        {
            IList<Sizes> size = this.manager.GetItemSize(id);
            if (size == null)
            {
                return this.BadRequest();
            }
            return this.Ok(size);
        }
        [Route("addSizes")]
        [HttpPost]
        public async Task<IActionResult> AddSizes(Sizes sizes)
        {
            var result = await this.manager.AddItemSize(sizes);
            if (result == 1)
            {
                return this.Ok(sizes);
            }
            else
            {
                return this.BadRequest();
            }
        }


        ////for description

        [Route("addDesc")]
        [HttpPost]
        public async Task<IActionResult> AddDescriptions(Description description)
        {
            var result = await this.manager.AddItemDescriptionAsync(description);
            if (result == 1)
            {
                return this.Ok(description);
            }
            else
            {
                return this.BadRequest();
            }
        }
        [HttpGet]
        [Route("getDescriptionById")]
        public IActionResult GetDescriptionById(int id)
        {
            Description size = this.manager.GetDescription(id);
            if (size == null)
            {
                return this.BadRequest();
            }
            return this.Ok(size);
        }

        //// get all items in cart

        [Route("getselected")]
        [HttpGet]
        public IEnumerable<SelectedItem> GetAllSelectedItems(string email)
        {
            return this.manager.GetAllSelectedItemsAsync(email);
        }

        [Route("addSelected")]
        [HttpPost]
        public async Task<IActionResult> AddSelected(SelectedItem selected)
        {
            var result = await this.manager.AddSelectedItemAsync(selected);
            if (result == 1)
            {
                return this.Ok(selected);
            }
            else
            {
                return this.BadRequest();
            }
        }
        [Route("deleteSelected")]
        [HttpDelete]
        public async Task<IActionResult> DeleteSelectedItem(int id)
        {
            var result = await this.manager.DeleteSelectedItems(id);
            if (result == 1)
            {
                return this.Ok("deleted" + "" + id);
            }
            else
            {
                return this.BadRequest();
            }
        }
        ////otp
        [HttpPost]
        [Route("requestOTP")]
        public IActionResult RequestOTP([FromQuery] string email)
        {
            var result = this.manager.RequestOtp(email);
            if (result)
            {
                return this.Ok(email);
            }
            else
                return this.BadRequest();
        }

        [HttpPost]
        [Route("verifyOTP")]
        public IActionResult VerifyOTP(AuthUser user)
        {
            var result = this.manager.VerifyOtp(user);
            if (result)
            {
                return this.Ok(user);
            }
            else
                return this.BadRequest();
        }

        ////Address
        
        [HttpPost]
        [Route("addAddress")]
        public async Task<IActionResult> AddAddress(Address address)
        {
            var result = await this.manager.AddAddress(address);
            if (result == 1)
            {
                return this.Ok(address);
            }
            else
            {
                return this.BadRequest();
            }
        }

        [Route("getAddress")]
        [HttpGet]
        public IEnumerable<Address> GetAddress(string email)
        {
            return this.manager.GetAddress(email);
        }

    }
}