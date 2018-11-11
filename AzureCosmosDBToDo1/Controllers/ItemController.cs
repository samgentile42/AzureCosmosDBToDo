using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureCosmosDBToDo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureCosmosDBToDo1.Controllers
{
    public class ItemController : Controller
    {
        [ActionName("Index")]
        public async Task<ActionResult> IndexAsync()
        {
            var items = await DocumentDBRepository<Item>.GetItemsAsync(d => !d.Completed);
            return View(items);
        }
    }
}