using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Common;
using Microsoft.AspNetCore.Http;
using NLog.Fluent;
using Repository.Context;
using Repository.IRepos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ItemsRepos
{
    public class Product : IProduct
    {
        public readonly UserDbContext context;
        public Product(UserDbContext dbContext)
        {
            context = dbContext;
        }
        public Task<int> AddItems(Items item)
        {
            Items items = new Items()
            {
                ItemName = item.ItemName,
                ItemBrandName = item.ItemBrandName,
                ItemImage = item.ItemImage,
                Price = item.Price,
                Status=true,
                Descriptions=item.Descriptions
            };
            Log.Debug("Item Added Successfully");
            this.context.Items.Add(items);
            var result=this.context.SaveChangesAsync();
            return result;
        }

        public Task<Items> FindAsync(int id)
        {
            var result = this.context.Items.FindAsync(id);
            return result;
        }
        public async Task<int> DeleteItem(int id)
        {
            var item = await this.FindAsync(id);
            this.context.Items.Remove(item);
            var result = this.context.SaveChanges();
            return result;
        }
        public void UpdateItem(Items item,int id)
        {
            Items items = this.context.Items.Where<Items>(selectedItem => selectedItem.ItemId == id).FirstOrDefault();
            items.ItemName = item.ItemName;
            items.ItemBrandName = item.ItemBrandName;
            items.ItemImage = item.ItemImage;
            items.Price = item.Price;
            items.Status = true;
            items.Descriptions = item.Descriptions;
        }
        public Task<int> SaveChangesAsync()
        {
            var result = this.context.SaveChangesAsync();
            return result;
        }
        public IEnumerable<Items> GetAllItems()
        {
            var result = this.context.Items.ToList<Items>();
            return result;
        }
        public string Image(IFormFile file,int id)
        {
            if (file == null)
            {
                return "Empty";
            }
            var stream = file.OpenReadStream();
            var name = file.FileName;
            Account account = new Account("bridgelabz", "528399974555442", "Ts5d5Nso2b5SA1OwNPFMIdtutg0");
            Cloudinary cloudinary = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(name,stream)
            };
            ImageUploadResult uploadResult = cloudinary.Upload(uploadParams);
            cloudinary.Api.UrlImgUp.BuildUrl(String.Format("{0}.{1}", uploadResult.PublicId, uploadResult.Format));
            var data = this.context.Items.Where(t => t.ItemId == id).FirstOrDefault();
            data.ItemImage = uploadResult.Uri.ToString();
            try
            {
                var result = this.context.SaveChanges();
                return data.ItemImage;
            }catch(Exception e)
            {
                return e.Message;
            }
        }
        public Items GetItemAsync(int id)
        {
            Items items = this.context.Items.Where<Items>(selectedItem => selectedItem.ItemId == id).FirstOrDefault();
            return items;

        }


        ////Product Color

        public Task<int> AddItemColor(Colors color)
        {
            Colors colors = new Colors()
            {
                ItemId = color.ItemId,
                Color=color.Color

            };
            this.context.Colors.Add(colors);
            var result = this.context.SaveChangesAsync();
            return result;
        }
        public IList<Colors> GetItemColors(int id)
        {
            var list = new List<Colors>();

            var item = from items in this.context.Colors where (items.ItemId == id) select items;
            foreach (var select in item)
            {
                list.Add(select);
            }
            return list;
        }


        ////Product Sizes


        public Task<int> AddItemSize(Sizes size)
        {
            Sizes sizes = new Sizes()
            {
                ItemId = size.ItemId,
                Size = size.Size

            };
            this.context.Sizes.Add(sizes);
            var result = this.context.SaveChangesAsync();
            return result;
        }
        public IList<Sizes> GetItemSizes(int id)
        {
            var list = new List<Sizes>();

            var item = from items in this.context.Sizes where (items.ItemId == id) select items;
            foreach (var select in item)
            {
                list.Add(select);
            }
            return list;
        }

        ////Adding descriptions

        public Task<int> AddItemDescriptions(Description size)
        {
            Description sizes = new Description()
            {
                ItemId = size.ItemId,
                Description1 = size.Description1,
                Description2=size.Description2,
                Advantage=size.Advantage
            };
            this.context.Descriptions.Add(sizes);
            var result = this.context.SaveChangesAsync();
            return result;
        }
        public Description GetDescriptionsById(int id)
        {
            Description items = this.context.Descriptions.Where<Description>(selectedItem => selectedItem.ItemId == id).FirstOrDefault();
            return items;

        }


        ////get all cart item

        public IEnumerable<SelectedItem> GetAllSelectedItems(string email)
        {
            var result =from items in this.context.SelectedItem where(items.Email == email) select items;
            return result;
        }
        public Task<int> AddSelectedItem(SelectedItem items)
        {
            var list = new List<SelectedItem>();
            var search = from data in this.context.SelectedItem where (data.ItemId == items.ItemId && data.Size==items.Size && data.Color==items.Color) select data;
            foreach(var itemsList in search)
            {
                list.Add(itemsList);
            }
            if (list.Count==0)
            {
                SelectedItem item = new SelectedItem()
                {
                    ItemId = items.ItemId,
                    ItemName = items.ItemName,
                    ItemImage = items.ItemImage,
                    Price = items.Price,
                    Color = items.Color,
                    Size = items.Size,
                    NumberOfItems = items.NumberOfItems,
                    Status = items.Status,
                    Email=items.Email

                };
                this.context.SelectedItem.Add(item);
            }
            else
            {
                SelectedItem selected = this.context.SelectedItem.Where<SelectedItem>(selectedItem => selectedItem.ItemId == items.ItemId && selectedItem.Size==items.Size).FirstOrDefault();
                selected.NumberOfItems += 1;
            }
            
           
            var result = this.context.SaveChangesAsync();
            return result;
        }
        public Task<SelectedItem> FindSeletedItemsAsync(int id)
        {
            var result = this.context.SelectedItem.FindAsync(id);
            return result;
        }
        public async Task<int> DeleteSelectedItem(int id)
        {
            var item = await this.FindSeletedItemsAsync(id);
            this.context.SelectedItem.Remove(item);
            var result = this.context.SaveChanges();
            return result;
        }



        ////verification of user

        public bool RequestOTP(string email)
        {

            if (email != null)
            {
                AuthUser authUser = this.context.AuthUsers.Where<AuthUser>(selectedItem => selectedItem.Email == email).FirstOrDefault();
                if (authUser!=null)
                {
                    var fromAddress = new MailAddress("manish.reddy@bridgelabz.com");
                    var fromPassword = "manish7111";
                    var toAddress = new MailAddress(email);
                    string subject = "OTP for Signing In to BAD BOYZ CLUB";
                    string body = "As per the request OTP is" + " " + authUser.OTP;
                    SmtpClient smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                    };

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                        try
                        {
                            smtp.Send(message);
                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }

                }
                else
                {
                    Random random = new Random();
                    var otpGenerate = random.Next(100000, 999999);
                    var fromAddress = new MailAddress("manish.reddy@bridgelabz.com");
                    var fromPassword = "manish7111";
                    var toAddress = new MailAddress(email);
                    string subject = "OTP for Signing In to BAD BOYZ CLUB";
                    string body = "As per the request OTP is" + " " + otpGenerate;
                    SmtpClient smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                    };

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                        try
                        {
                            smtp.Send(message);
                            AuthUser auth = new AuthUser();
                            auth.Email = email;
                            auth.OTP = otpGenerate.ToString();
                            this.context.AuthUsers.Add(auth);
                            this.context.SaveChanges();
                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }
                }
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool VerifyOTP(AuthUser user)
        {
            AuthUser authUser = this.context.AuthUsers.Where<AuthUser>(selectedItem => selectedItem.Email == user.Email && selectedItem.OTP==user.OTP).FirstOrDefault();
            if (authUser != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ////For Address

        public Task<int> AddAddress(Address address)
        {
            Address addresss = this.context.Addresses.Where<Address>(selectedItem => selectedItem.Email == address.Email).FirstOrDefault();
            if (addresss == null)
            {
                Address sizes = new Address()
                {
                    FirstName = address.FirstName,
                    LastName = address.LastName,
                    Email = address.Email,
                    FlatOrHouseNo = address.FlatOrHouseNo,
                    State = address.State,
                    StreetOrLocality = address.StreetOrLocality,
                    City = address.City,
                    ZipCode = address.ZipCode,
                    District=address.District
                };
                this.context.Addresses.Add(sizes);
            }
            else
            {
                addresss.FirstName = address.FirstName;
                addresss.LastName = address.LastName;
                addresss.Email = address.Email;
                addresss.FlatOrHouseNo = address.FlatOrHouseNo;
                addresss.StreetOrLocality = address.StreetOrLocality;
                addresss.City = address.City;
                addresss.State = address.State;
                addresss.ZipCode = address.ZipCode;
                addresss.District = address.District;
                this.context.Addresses.Update(addresss);
            }
            var result = this.context.SaveChangesAsync();
            return result;
        }
        public IEnumerable<Address> GetAddress(string email)
        {
            var result = from items in this.context.Addresses where (items.Email == email) select items;
            return result;
        }
    }
}
