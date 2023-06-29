using System;
using System.ComponentModel.DataAnnotations;

namespace PestControl.Models {
	public class Comment {

		public int Id { get; set; }

		public ApplicationUser Author { get; set; } = null;

		public string Body { get; set; } = "";

		public int BugId { get; set; }

		public Bug Bug { get; set; } = null;
	}
}

