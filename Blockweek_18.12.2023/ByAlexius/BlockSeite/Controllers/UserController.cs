using BlockSeite.Data;
using BlockSeite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlockSeite.Controllers
{
    public class UserController : Controller
    {
        private readonly MyDbContext _ctx;

        public UserController(MyDbContext context)
        {
            this._ctx = context;
        }

        // GET: UserController
        public async Task<IActionResult> Index(string search, int role = -1)
        {
            var users = _ctx.Users.Include(u => u.Role).AsQueryable();

			var roleList = await _ctx.Role.ToListAsync();

            roleList.Insert(0, new Role(-1, "Select Role"));

            SelectList roles = new SelectList(roleList, "RoleId", "RoleName");

			if (!string.IsNullOrEmpty(search))
            {
                users = users.Where(s => s.UserName!.Contains(search));
            }

            if (role > -1)
            {
                Role? _role = await _ctx.Role.FindAsync(role);

                if (_role == null)
                {
                    return NotFound();
                }
                users = users.Where(s => s.Role == _role);
            }

            ViewBag.Roles = roles;

            return View(await users.ToListAsync());
        }

        // GET: UserController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            return View(await _ctx.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.UserId == id));
        }

        // GET: UserController/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.Roles = new SelectList(_ctx.Role, "RoleId", "RoleName"); ;

            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(UserForm form)
        {
            try
            {
                Role? role = await _ctx.Role.FindAsync(form.Role);

                if (role == null)
                {
                    return View(new User(form.UserName, form.Email, null));
                }

                if (!ModelState.IsValid)
				{
					return View(new User(form.UserName, form.Email, role));
				}


				User user = new User();
                user.UserName = form.UserName;
                user.Email = form.Email;
                user.Role = role;
                
                _ctx.Users.Add(user);
                _ctx.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            SelectList list = new SelectList(_ctx.Role, "RoleId", "RoleName");

            foreach (var item in list)
            {
                if (item.Value == id.ToString())
                {
                    item.Selected = true;
                    break;
                }
            }

            ViewBag.Roles = list;

            return View(await _ctx.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.UserId == id));
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, UserForm form)
        {
            try
            {
				User? user = await _ctx.Users.FindAsync(id);

                Role? role = await _ctx.Role.FindAsync(form.Role);

                if (role == null)
                {
                    return View(new User(form.UserName, form.Email, null));
                }

                if (user == null)
                {
                    return View(new User(form.UserName, form.Email, role));
                }

                if (!ModelState.IsValid)
                {
                    user.UserName = form.UserName;
                    user.Email = form.Email;
                    user.Role = role;
                    return View(user);
                }

                user.UserName = form.UserName;
                user.Email = form.Email;
                user.Role = role;

                _ctx.Users.Update(user);
                _ctx.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await _ctx.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.UserId == id));
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                User? user = await _ctx.Users.FindAsync(id);

				if (user == null)
				{
					return NotFound();
				}

				_ctx.Users.Remove(user);
                _ctx.SaveChanges();

				return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
