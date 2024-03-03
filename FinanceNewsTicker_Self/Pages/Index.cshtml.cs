using FinanceNewsTicker_Self.IServices;
using FinanceNewsTicker_Self.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinanceNewsTicker_Self.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly INewsService _newsService;
        public FinanceNews news;

        public IndexModel(ILogger<IndexModel> logger,
            INewsService newsService)
        {
            _logger = logger;
            _newsService = newsService;
        }

        public void OnGet()
        {
            news = _newsService.GetFinanceNews();
        }
    }
}
