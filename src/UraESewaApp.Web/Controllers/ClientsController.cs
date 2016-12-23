using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UraEsewaApp.Models.ViewModels;
using UraEsewaApp.Services.Abstract;
using UraEsewaApp.Services.Impl;
using UraEsewaApp.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UraESewaApp.Web.Controllers
{
    public class ClientsController : Controller
    {

        private readonly IClientService _clientService;

        public ClientsController(IClientService context)
        {
            _clientService = context;
        }

        // GET: Clients
        public IActionResult Index()
        {
            return View(_clientService.GetAll().ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Address,ClientCode,ClientGLCode,ClientName,ContactNo,ContactPersonName,Description,EmaildId,OutstandingBalance")] Client client)
        {
            if (ModelState.IsValid)
            {
                _clientService.Add(client);
                return RedirectToAction("Index");
            }
            return View(client);

        }

        // GET: Clients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _clientService.GetById(id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Clients/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _clientService.GetById(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Address,ClientCode,ClientGLCode,ClientName,ContactNo,ContactPersonName,Description,EmaildId,OutstandingBalance")] Client client)
        {
            if (id != client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _clientService.Update(client);

                }
                catch (Exception ex)
                {
                    if (_clientService.GetById(id) != null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(client);
        }

    }
}
