using Microsoft.AspNetCore.Mvc;
using MVCDing.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MVCDing.Controllers
{
    public class BookController : Controller
    {
        private readonly HttpClient _httpClient;

        public BookController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7118/");
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("api/books");
            if (response.IsSuccessStatusCode)
            {
                var books = await response.Content.ReadFromJsonAsync<IEnumerable<Book>>();
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
                var book = await response.Content.ReadFromJsonAsync<Book>();
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
        public async Task<IActionResult> Create(Book book)
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
                var book = await response.Content.ReadFromJsonAsync<Book>();
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
        public async Task<IActionResult> Edit(int id, Book book)
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
                var book = await response.Content.ReadFromJsonAsync<Book>();
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
