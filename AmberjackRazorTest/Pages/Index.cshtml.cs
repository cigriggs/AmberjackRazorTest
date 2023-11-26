using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AmberjackRazorTest.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        [Display(Name = "Title")]
        public Titles Title { get; set; }

        [BindProperty]
        [Display(Name = "First name")]
        public string? FirstName { get; set; }

        [BindProperty]
        [Display(Name = "Last name")]
        [Required]
        public string LastName { get; set; }

        [BindProperty]
        [Display(Name = "Email address")]
        [Required]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])", ErrorMessage = "The Email address is invalid.")]
        public string Email { get; set; }

        [BindProperty]
        public List<Qualification> Grades { get; set; }

        public enum Titles
        {
            Mr,
            Mrs,
            Miss,
            Dr
        }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                ViewData["greeting"] = $"Hello {Title} {(string.IsNullOrEmpty(FirstName) ? "" : $"{FirstName} ")}{LastName} ({Email})";
            }
        }
    }
}