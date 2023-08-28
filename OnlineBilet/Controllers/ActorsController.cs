using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineBilet.Data;
using OnlineBilet.Data.Services;
using OnlineBilet.Data.Static;
using OnlineBilet.Models;

namespace OnlineBilet.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;

        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync(); //bağlantı yapıp tüm aktörleri listeli al
            return View(data);
        }
        // get: ../../Create
        public async Task<IActionResult> Create()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    var errorMessage = error.ErrorMessage;
                    // Log the error message or handle it appropriately.
                }
                return View(actor);
            }
            await _service.AddAsync(actor);

            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("Bulunamadı");
            return View(actorDetails);
        }
        //GET: ../../Edit/IdS
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("Bulunamadı");
            return View(actorDetails);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("FullName,ProfilePictureUrl,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                //foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                //{
                //    var errorMessage = error.ErrorMessage;
                //    // Log the error message or handle it appropriately.
                //}
                return View(actor);
            }
            actor.Id = id;
            await _service.UpdateAsync(id, actor);

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("Bulunamadı");
            return View(actorDetails);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("Bulunamadı");
            await _service.DeleteAsync(id);
            //actor.Id = id;
            return RedirectToAction(nameof(Index));
        }

    }
}   

