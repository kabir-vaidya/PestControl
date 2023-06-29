using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PestControl.Models {
	public class Bug {

		public int ID{ get; set; }

		public string Title { get; set; } = "";

		public string Description { get; set; } = "";

		public ApplicationUser Owner { get; set; }

		public BugPriority Priority { get; set; }

		public ICollection<Comment> Comments { get; set; } = new List<Comment>();
	}
}
