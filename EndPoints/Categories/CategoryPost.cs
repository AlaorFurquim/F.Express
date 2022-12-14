using F.Express.Domain.Products;
using F.Express.Infra.Data;

namespace F.Express.EndPoints.Categories
{
    public class CategoryPost
    {
        public static string template => "/categories"; // Difinindo a rota

        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };

        public static Delegate Handle => Action;

        public static IResult Action(CategoryRequest categoryRequest, ApplicationDbContext context)
        {

            var category = new Category
            {
                Name = categoryRequest.Name
            };
            context.Categories.Add(category);
            context.SaveChanges();

            return Results.Created($"/categories/{category.Id}", category.Id);
        }
    }
}
