using ExerciseTracker;
using ExerciseTracker.Data;
using ExerciseTracker.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient<Startup>();
services.AddDbContext<ExerciseContext>(options =>
{
    options.UseSqlite("Data Source=ExerciseTracker.db");
});
services.AddTransient<IExerciseRepository, ExerciseRepository>();

var serviceProvider = services.BuildServiceProvider();
var startup = serviceProvider.GetService<Startup>();

startup!.Run();