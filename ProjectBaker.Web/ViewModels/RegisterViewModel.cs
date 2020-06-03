using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBaker.Web.ViewModels
{
	public class RegisterViewModel
	{
		[Required]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
