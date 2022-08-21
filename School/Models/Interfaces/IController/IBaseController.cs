using Microsoft.AspNetCore.Mvc;

namespace School.Models.Interfaces.IController
{
    public interface IBaseController<TModel, TModelDto, TModelAddDto, TModelUpdateDto>
    {
        Task<IActionResult> IndexAsync();
        Task<IActionResult> EditAsync(Guid id);
        IActionResult CreateAsync();
        Task<IActionResult> CreateAsync(TModelAddDto model);
        Task<IActionResult> EditAsync(Guid id, TModelUpdateDto model);

        Task<IActionResult> DetailsAsync(Guid id);
        Task<IActionResult> DeleteAsync(Guid id);
    }
}
