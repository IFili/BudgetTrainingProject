using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Budget.Mvc.Models.ViewModels
{
	public class InsertCategoryViewModel
	{

	public int Id { get; set; }

		[Required]
		[Remote("isUnique", "Home")]
		public string Name { get; set; }
	}
}
