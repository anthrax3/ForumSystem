﻿namespace ForumSystem.Web.InputModels.CommentReports
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class CommentReportInputModel
    {
        public int CommentId { get; set; }

        [Required]
        [AllowHtml]
        [DataType(DataType.Html)]
        [UIHint("tinymce_full")]
        [Display(Name = "Description")]
        [StringLength(100000, MinimumLength = 12, ErrorMessage = "{0} must be between {2} and {1} symbols.")]
        public string Description { get; set; }
    }
}