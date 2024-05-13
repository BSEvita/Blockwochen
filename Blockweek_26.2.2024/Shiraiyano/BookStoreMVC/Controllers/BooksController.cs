using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStoreMVC.Data;
using BookStoreMVC.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace BookStoreMVC.Controllers
{
    public class BooksController : Controller
    {
        private readonly HttpClient _httpClient;

        public BooksController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:5153/");
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("api/books");
            if (response.IsSuccessStatusCode)
            {
                var books = await response.Content.ReadFromJsonAsync<IEnumerable<Books>>();
                return View(books);
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            var response = await _httpClient.GetAsync($"api/books/{id}");
            if (response.IsSuccessStatusCode)
            {
                var book = await response.Content.ReadFromJsonAsync<Books>();
                return View(book);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound();
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Books book)
        {
            var response = await _httpClient.PostAsJsonAsync("api/books", book);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var response = await _httpClient.GetAsync($"api/books/{id}");
            if (response.IsSuccessStatusCode)
            {
                var book = await response.Content.ReadFromJsonAsync<Books>();
                return View(book);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound();
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Books book)
        {
            if (ModelState.IsValid)
            {
                var response = await _httpClient.PutAsJsonAsync($"api/books/{id}", book);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return StatusCode((int)response.StatusCode);
                }
            }
            else
            {
                // If ModelState is not valid, return the view with the invalid model
                return View(book);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpClient.GetAsync($"api/books/{id}");
            if (response.IsSuccessStatusCode)
            {
                var book = await response.Content.ReadFromJsonAsync<Books>();
                return View(book);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound();
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/books/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }
        }
    }
}

