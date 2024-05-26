using Task15.Models.Entities;

namespace Task15.Models.DbContexts
{
    public static class DataSeed
    {
        public static IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using(var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DataContext>();

                var list = new[]{
                    new Country {Id=1, Name = "Azerbaijan", Code = "+994" },
                new Country { Id = 2, Name ="Germany", Code="+49" },
                new Country { Id = 3, Name ="Italy", Code="+39"},
                new Country { Id = 4, Name ="Norway", Code="+47"}
                };
                db.Countries.AddRange(list);
                db.SaveChanges();
            }

            return app;
        }
    }
}
