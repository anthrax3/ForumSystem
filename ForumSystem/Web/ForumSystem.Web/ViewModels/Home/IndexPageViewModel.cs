﻿namespace ForumSystem.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using ForumSystem.Web.ViewModels.Section;

    public class IndexPageViewModel
    {
        public IEnumerable<SectionViewModel> Sections { get; set; }
    }
}