﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoLot.Dal.Repos.Interfaces;
using AutoLot.Models.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AutoLot.Web.Areas.Admin.Pages.Makes
{
    public class IndexModel : PageModel
    {
        private readonly IMakeRepo _repo;

        public IndexModel(IMakeRepo repo)
        {
            _repo = repo;
        }

        public IList<Make> Makes { get;set; }

        public void OnGet()
        {
            Makes = _repo.GetAll().ToList();
        }
    }
}
