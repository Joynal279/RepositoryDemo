using System;
using System.ComponentModel.DataAnnotations;

namespace RepositoryDemo.Models
{
	public class Student
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Please enter name")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Please enter email")]
		[EmailAddress(ErrorMessage ="Email should be valid")]
		public string Email { get; set; }
		[Required(ErrorMessage ="Please enter reg no.")]
		public string RegNo { get; set; }

	}
}

