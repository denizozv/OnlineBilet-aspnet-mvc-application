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
    public class DirectorsController : Controller
    {
        private readonly IDirectorsService _service;
        public DirectorsController(IDirectorsService service) //cons
        {
            _service = service; 
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allDirectors = await _service.GetAllAsync(); //asenkron bu yanı beklerken diğer işlemler oluyor
            return View(allDirectors);
        }
        //GET / DETAİLS
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var directorDetails = await _service.GetByIdAsync(id);
            if (directorDetails == null) return View("Bulunamadı");
            return View(directorDetails);
        }

        //get crate
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureUrl,FullName,Bio")]Director director)
        {
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    var errorMessage = error.ErrorMessage;
                    // Log the error message or handle it appropriately.
                }
                return View(director);
            }
            await _service.AddAsync(director);
            return RedirectToAction(nameof(Index));
        }

        //GET: directors/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Bulunamadı");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Bio")] Director director)
        {
            if (!ModelState.IsValid) return View(director);

            if (id == director.Id)
            {
                await _service.UpdateAsync(id, director);
                return RedirectToAction(nameof(Index));
            }
            return View(director);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Bulunamadı");
            return View(producerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Bulunamadı");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}

//asenkron bir işlem olduğunu ve sonucunun gelmesini await ile beklediğini gösterir. Bu şekilde, veriler geldiğinde onları işleyebilir veya olası hataları yakalayabiliriz.
