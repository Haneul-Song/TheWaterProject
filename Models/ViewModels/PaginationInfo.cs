﻿namespace TheWaterProject.Models.ViewModels
{
    public class PaginationInfo
    {
        public int TotalItems { get; set; }
        public int ItemPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalNumPages => (int)(Math.Ceiling((decimal) TotalItems / ItemPerPage));
    }
}
