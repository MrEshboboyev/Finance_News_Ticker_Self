namespace FinanceNewsTicker_Self.IServices
{
    public interface INewsService
    {
        void GetFinanceNews();
    }

    public class NewsService : INewsService
    {
        private readonly IConfiguration _configuration;

        public NewsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void GetFinanceNews()
        {
            string apiKey = _configuration.GetValue<string>("API_KEY");
        }
    }
}
