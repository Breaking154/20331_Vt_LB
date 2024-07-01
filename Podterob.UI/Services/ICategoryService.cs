using Podterob.Domain.Entities;
using Podterob.Domain.Models;

namespace Podterob.UI.Services
{
	public interface ICategoryService
	{
		/// <summary>
		/// Получение списка всех категорий
		/// </summary>
		/// <returns></returns>
		public Task<ResponseData<List<Category>>> GetCategoryListAsync();
	}
}
