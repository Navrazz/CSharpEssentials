
namespace Creational.Builder.Article
{
    public class Director
    {
        private IArticleBuilder _articleBuilder;

        public IArticleBuilder ArticleBuilder { set => _articleBuilder = value; }


        //Director can construct several variants of article
        public void BuildSimpleArticle()
        {
            _articleBuilder.CreateTitle();
            _articleBuilder.CreateParagraph();
        }

        public void BuildArticleWithTable()
        {
            _articleBuilder.CreateTitle();
            _articleBuilder.CreateParagraph();
            _articleBuilder.CreateTable();
        }

        public void BuildArticleWithPicture()
        {
            _articleBuilder.CreateTitle();
            _articleBuilder.CreateParagraph();
            _articleBuilder.CreatePicture();
        }

        public void BuildFullArticle()
        {
            _articleBuilder.CreateTitle();
            _articleBuilder.CreateParagraph();
            _articleBuilder.CreatePicture();
            _articleBuilder.CreateTable();
        }
    }
}
