using System.Net;

namespace Task
{
    public class Program
    {

        //«адание 1
        //—оздайте MVC приложений дл€ сохранени€ текстовых заметок.
        //ѕользователь должен иметь возможностью аутентификации на основе HTTP cookie.
        //ѕосле аутентификации пользователь должен иметь возможность:
        //добавить заметку, заполнив необходимую форму.
        //просмотреть все заметки, которые он добавл€л.
        // аждый пользователь имеет право просматривать только свои заметки. ѕри отсутствии аутентификации, у пользовател€ не должно быть возможности просматривать страницу добавлени€ и просмотра заметок. ƒл€ хранени€ пользователей и заметок можно использовать коллекции объектов в оперативной пам€ти или базу данных на усмотрение студента.

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}