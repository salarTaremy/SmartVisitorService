using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SmartVisitor.Entities.Other;
using SmartVisitor.Entities.ViewModel;
using SmartVisitor.Repositories;


namespace SmartVisitorApi.Controllers
{
    public class FullDataController : BaseControler
    {

        // post object or class
        [Produces("application/json")]
        [HttpPost("[action]")]
        public IActionResult test([FromBody] UpdateRequest value)
        {
            return null;
        }


        // post list or array
        [Produces("application/json")]
        [HttpPost("[action]")]
        public IActionResult test2([FromBody] List<int> value)
        {
            return null;
        }

        //list or array from url
        // url Example :   http://localhost:54448/api/v1/fulldata/test2/13635879/?listOfIds=1&listOfIds=2&listOfIds=3
        [HttpGet("[action]/{IMEI}")]
        public int test2(string IMEI, [FromQuery] int[] listOfIds)
        {
            return listOfIds.Length;
        }


        [Produces("application/json")]
        [HttpPost("[action]/{IMEI}")]
        public IActionResult Get(String IMEI)
        {
            try
            {

                FullDataViewModel fullData =    new FullDataViewModel();

                fullData.Customers =            new CustomerRepository(IMEI).Get();
                fullData.CustomerTypes =        new CustomerTypeRepository().Get();
                fullData.CustomerGroups =       new CustomerGroupRepository().Get();
                fullData.Products =             new ProductRepository(IMEI).Get();
                fullData.ProductBrands =        new ProductBrandRepository().Get();
                fullData.ProductGroups =        new ProductGroupRepository().Get();
                fullData.Warehouses =           new WarehouseRepository(IMEI).Get();
                fullData.inventories =          new InventoryRepository(IMEI).Get();
                fullData.PriceLists =           new PriceListRepository(IMEI).Get();
                fullData.LinkPriceListCustomer =new LinkPriceListCustomerRepository(IMEI).Get();


                return Ok(fullData);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }





        private static void AddEntry(string fileName, byte[] fileContent, ZipArchive archive)
        {
            var entry = archive.CreateEntry(fileName);
            using (var stream = entry.Open())
                stream.Write(fileContent, 0, fileContent.Length);

        }







        [HttpGet("[action]/{IMEI}")]
        public async Task<IActionResult> GetCompress( string IMEI , [FromQuery] int[] listOfIds)
        {
            try
            {
                FullDataViewModel fullData = new FullDataViewModel();


                foreach (var item in listOfIds)
                {
                    if (item ==1 )
                    {
                        fullData.Customers = new CustomerRepository(IMEI).Get();
                        fullData.CustomerTypes = new CustomerTypeRepository().Get();
                        fullData.CustomerGroups = new CustomerGroupRepository().Get();
                        fullData.Products = new ProductRepository(IMEI).Get();
                        fullData.ProductBrands = new ProductBrandRepository().Get();
                        fullData.ProductGroups = new ProductGroupRepository().Get();
                        fullData.Warehouses = new WarehouseRepository(IMEI).Get();
                        fullData.inventories = new InventoryRepository(IMEI).Get();
                        fullData.PriceLists = new PriceListRepository(IMEI).Get();
                        fullData.LinkPriceListCustomer = new LinkPriceListCustomerRepository(IMEI).Get();
                        fullData.LinkVisitorCustomer = new LinkVisitorCustomerRepository(IMEI).Get();

                    }
                    if (item == 2)
                    {
                    }
                    if (item == 3)
                    {
                    }
                }





                //var data = new JsonResult(fullData);
                string json = JsonConvert.SerializeObject(fullData);


                var fileContent = Encoding.UTF8.GetBytes(json);
                var zipContent = new MemoryStream();
                var archive = new ZipArchive(zipContent, ZipArchiveMode.Create);
                AddEntry("Data.json", fileContent, archive);
                archive.Dispose();
                //System.IO.File.WriteAllBytes("testa.zip", zipContent.ToArray());
                FileContentResult file = File(zipContent.ToArray(), "application/zip");
                file.FileDownloadName = "Data.zip";
                return file;
            }
            catch (Exception e)
            {
                return BadRequest();
            }
           


            
        }
    }
}
