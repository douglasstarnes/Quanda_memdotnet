using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Quanda.Models;

namespace Quanda.Pages.Questions
{
    public class DetailsModel : PageModel
    {
        private readonly QuandaDbContext context;

        public Question Question { get; set; }

        public DetailsModel(QuandaDbContext context)
        {
            this.context = context;
        }
        public void OnGet(int questionId)
        {
            Question = context.Questions.FirstOrDefault(q => q.QuestionId == questionId);
        }
    }
}