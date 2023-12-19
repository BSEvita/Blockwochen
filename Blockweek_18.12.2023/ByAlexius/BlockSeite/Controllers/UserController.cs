using BlockSeite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlockSeite.Controllers
{
    public class UserController : Controller
    {
        private readonly MyDbContext dbCtx;

        public UserController(MyDbContext dbCtx)
        {
            this.dbCtx = dbCtx;
        }

        // GET: UserController
        public async Task<IActionResult> Index()
        {
            return View(await dbCtx.Users.ToListAsync());
        }

        // GET: UserController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            return View(await dbCtx.Users.FindAsync(id));
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] string UserName, [FromForm] string email)
        {
            try
            {
                User user = new User();
                user.UserName = UserName;
                user.email = email;
                
                dbCtx.Users.Add(user);
                dbCtx.SaveChanges();

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
            return View(await dbCtx.Users.FindAsync(id));
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [FromForm] string UserName, [FromForm] string email)
        {
            try
            {
				User user = await dbCtx.Users.FindAsync(id);

                if (user == null)
                {
                    return NotFound();
                }

                user.UserName = UserName;
                user.email = email;

                dbCtx.Users.Update(user);
                dbCtx.SaveChanges();

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
            return View(await dbCtx.Users.FindAsync(id));
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                dbCtx.Users.Remove(await dbCtx.Users.FindAsync(id));
                dbCtx.SaveChanges();

				return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
