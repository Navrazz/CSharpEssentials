using Creational.Builder.Article;
using System;

namespace Creational.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var articleBuilder = new ArticleBuilder();

            director.ArticleBuilder = articleBuilder;

            Console.WriteLine("Simple article");
            director.BuildSimpleArticle();
            Console.WriteLine(articleBuilder.GetArticle().GetArticleParts());

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Article with picture");
            director.BuildArticleWithPicture();
            Console.WriteLine(articleBuilder.GetArticle().GetArticleParts());

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Full article");
            director.BuildFullArticle();
            Console.WriteLine(articleBuilder.GetArticle().GetArticleParts());

            Console.WriteLine("-----------------------------------------------------------");

            //Builder can be used without Director class
            Console.WriteLine("Custom Article");
            articleBuilder.CreateTitle();
            articleBuilder.CreatePicture();

            Console.WriteLine(articleBuilder.GetArticle().GetArticleParts());
        }
    }
}
