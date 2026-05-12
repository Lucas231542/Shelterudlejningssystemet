using ShelterudlejningssystemetLib;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

bool TestData = true;
List<Blog_opslag> Blog_opslagListe = new List<Blog_opslag>();
if (TestData)
{
    Blog_opslag opslag1 = new Blog_opslag(1, "Blog opslag 1", "Dette er det første blog opslag",new DateTime(2026, 8, 8), "path/to/image1.jpg");
    Blog_opslag opslag2 = new Blog_opslag(2, "Blog opslag 2", "Dette er det andet blog opslag", new DateTime(2027, 3, 20), "path/to/image2.jpg");
    Blog_opslag opslag3 = new Blog_opslag(3, "Blog opslag 3", "Dette er det tredje blog opslag", DateTime.Now, "path/to/image3.jpg");

    Blog_opslagListe.Add(opslag1);
    Blog_opslagListe.Add(opslag2);
    Blog_opslagListe.Add(opslag3);
}


builder.Services.AddSingleton<BlogListe>(new BlogListe(Blog_opslagListe));






bool TestData2 = true;
List<SpejderKreds> SpejderKredsListe = new List<SpejderKreds>();
if (TestData2)
{
    SpejderKreds kreds1 = new SpejderKreds(1, "Kreds 1", 100);
    SpejderKreds kreds2 = new SpejderKreds(2, "Kreds 2", 150);
    SpejderKreds kreds3 = new SpejderKreds(3, "Kreds 3", 200);
    SpejderKredsListe.Add(kreds1);
    SpejderKredsListe.Add(kreds2);
    SpejderKredsListe.Add(kreds3);
}


builder.Services.AddSingleton<ISpejderKredsService, SpejderKredsServiceFiles>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
