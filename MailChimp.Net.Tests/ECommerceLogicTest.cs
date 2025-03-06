// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
using Xunit;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The authorized app test.
    /// </summary>
    public class ECommerceLogicTest : MailChimpTest
    {
        private const string ListName = "TestListEccommerce";
        private const string StoreName = "TestStore";
        private const CurrencyCode Currency = CurrencyCode.GBP;
        private const decimal TestProductPrice = 1m;

        private string _storeId = string.Empty;
        private string _customerId = string.Empty;
    

        internal override async Task RunBeforeTestFixture()
        {
            var list = await ClearAndGetNewList();
            var store = await ClearAndGetNewStore(list.Id);
            _storeId = store.Id;
            var customer = await AddCustomerToStore(_storeId);
            _customerId = customer.Id;
        }

        [Fact]
        public async Task Should_Create_Product()
        {
            var product = await this.MailChimpManager.ECommerceStores.Products(_storeId).AddAsync(GetTestProduct());
            Assert.NotNull(product);
        }

        [Fact]
        public async Task Should_Update_Product()
        {    
            var product = await this.MailChimpManager.ECommerceStores.Products(_storeId).AddAsync(GetTestProduct());
            var newProductTitle = product.Title + "1";
            product.Title = newProductTitle;
            product = await this.MailChimpManager.ECommerceStores.Products(_storeId).UpdateAsync(product.Id, product);
            Assert.NotNull(product);
            Assert.Equal(newProductTitle, product.Title);
        }

        /// <summary>
        /// The should_ return_ app_ information.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_App_Information()
        {
            var product = await this.MailChimpManager.ECommerceStores.Products(_storeId).AddAsync(GetTestProduct());
            var variant = product.Variants.FirstOrDefault();        

            var testCart = await this.MailChimpManager.ECommerceStores.Carts(_storeId).AddAsync(new Cart
            {
                Id = "1",
                Customer = new Customer {Id = _customerId },
                CurrencyCode = Currency,
                OrderTotal = TestProductPrice,
                Lines = new List<Line>()
                {
                    new Line
                    {
                        Id="1",
                        ProductId = product.Id,
                        ProductVariantId = variant.Id,
                        Quantity = 1,
                        Price = (decimal)variant.Price
                    }
                }
            });
            Assert.NotNull(testCart);
      
            //await this._mailChimpManager.ECommerceStores.Products("storeId").Variances("productId");
        }


        private async Task<List> ClearAndGetNewList()
        {
            await ClearLists().ConfigureAwait(false);
            return await this.MailChimpManager.Lists.AddOrUpdateAsync(GetMailChimpList(ListName)).ConfigureAwait(false);        
        }

        private async Task<Store> ClearAndGetNewStore(string listId)
        {
            var stores = await this.MailChimpManager.ECommerceStores.GetAllAsync();
            await Task.WhenAll(stores.Select(x => this.MailChimpManager.ECommerceStores.DeleteAsync(x.Id)));
            var storeToCreate = new Store
            {
                Id = StoreName,
                ListId = listId,
                CurrencyCode = Currency,
                Name = StoreName
            };

            return await this.MailChimpManager.ECommerceStores.AddAsync(storeToCreate);
        }

        private async Task<Customer> AddCustomerToStore(string storeId)
        {
            var customer = new Customer
            {
                Id = "1",
                EmailAddress = "test@test.com",
                OptInStatus = false
            };

            return await this.MailChimpManager.ECommerceStores.Customers(storeId).AddAsync(customer).ConfigureAwait(false);
        }

        private Product GetTestProduct() => new Product
        {
            Id = "1",
            Title = "Test",
            Variants = new List<Variant>
            {
                new Variant
                {
                    Id="1",
                    Title ="Test",
                    Sku="1",
                    Price=TestProductPrice
                }
            }
        };
    }
}