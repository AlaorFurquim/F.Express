using F.Express.EndPoints.Categories;
using F.Express.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace F.Express
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer(builder.Configuration.GetConnectionString("F.ExpressDB")));

            
            builder.Services.AddAuthorization();

            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

           
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapMethods(CategoryPost.template, CategoryPost.Methods, CategoryPost.Handle);

            app.Run();
        }
    }
}