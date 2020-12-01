
namespace Creational.Builder.Article
{
    public interface IArticleBuilder
    {
        void CreateTitle();
        void CreateParagraph();
        void CreateTable();
        void CreatePicture();
    }
}