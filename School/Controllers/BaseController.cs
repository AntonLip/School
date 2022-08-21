using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Models.Interfaces;
using School.Models.Interfaces.IController;
using School.Models.Interfaces.IService;

namespace School.Controllers
{
    public abstract class BaseController<TModel, TModelDto, TModelAddDto, TModelUpdateDto> : Controller, IBaseController<TModel, TModelDto, TModelAddDto, TModelUpdateDto>
       where TModel : IEntity<Guid>
           where TModelDto : IEntity<Guid>
           where TModelAddDto : IEntity<Guid>
           where TModelUpdateDto : IEntity<Guid>
    {
        private readonly IService<TModel, TModelDto, TModelAddDto, TModelUpdateDto, Guid> _service;
        public BaseController(IService<TModel, TModelDto, TModelAddDto, TModelUpdateDto, Guid> service)
        {
            _service = service;
        }
        [HttpGet]
        public virtual IActionResult CreateAsync()
        {
            return View();
        }

        public virtual async Task<IActionResult> CreateAsync(TModelAddDto model)
        {
            try
            {
                var newModel = await _service.AddAsync(model);
                if (newModel is null)
                    throw new ArgumentException();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ErrorViewModel modelError = new ErrorViewModel();
                modelError.Messadge = ex.Message;
                return RedirectToAction("Error", "Home", modelError);
            }
        }

        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            try
            {
                var model = await _service.RemoveAsync(id);
                if (model is null)
                    throw new ArgumentException();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ErrorViewModel modelError = new ErrorViewModel();
                modelError.Messadge = ex.Message;
                return RedirectToAction("Error", "Home", modelError);
            }
        }

        public async Task<IActionResult> DetailsAsync(Guid id)
        {
            try
            {
                var model = await _service.GetByIdAsync(id);
                if (model is null)
                    throw new ArgumentException();
                return View(model);
            }
            catch (Exception ex)
            {
                ErrorViewModel modelError = new ErrorViewModel();
                modelError.Messadge = ex.Message;
                return RedirectToAction("Error", "Home", modelError);
            }
        }
        [HttpGet]
        public virtual async Task<IActionResult> EditAsync(Guid id)
        {
            try
            {
                var model = await _service.GetByIdAsync(id);
                if (model is null)
                    throw new ArgumentException();
                return View(model);
            }
            catch (Exception ex)
            {
                ErrorViewModel modelError = new ErrorViewModel();
                modelError.Messadge = ex.Message;
                return RedirectToAction("Error", "Home", modelError);
            }
        }

        public async Task<IActionResult> EditAsync(Guid id, TModelUpdateDto model)
        {
            try
            {
                var newModel = await _service.UpdateAsync(id, model);
                if (newModel is null)
                    throw new ArgumentException();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ErrorViewModel modelError = new ErrorViewModel();
                modelError.Messadge = ex.Message;
                return RedirectToAction("Error", "Home", modelError);
            }
        }

        public virtual async Task<IActionResult> IndexAsync()
        {
            try
            {
                var models = await _service.GetAllAsync();
                return View(models);

            }
            catch (Exception ex)
            {
                ErrorViewModel model = new ErrorViewModel();
                model.Messadge = ex.Message;
                return RedirectToAction("Error", "Home", model);
            }
        }


    }
}
