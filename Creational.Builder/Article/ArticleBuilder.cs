
namespace Creational.Builder.Article
{
    public class ArticleBuilder : IArticleBuilder
    {
        private Article _article = new Article();

        public ArticleBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            _article = new Article();
        }

        public void CreateParagraph()
        {
            _article.Add("Paragraph");
        }

        public void CreatePicture()
        {
            _article.Add("Picture");
        }

        public void CreateTable()
        {
            _article.Add("Table");
        }

        public void CreateTitle()
        {
            _article.Add("Title");
        }


        //Concrete builders should have their own methods for getting results.
        //After returning result should be ready for creating new one - usual practice is to reset instance at the end of this method (it's not mandatory)
        public Article GetArticle()
        {
            Article article = _article;
            this.Reset();

            return article;
        }
    }
}
