using ExerciseTracker;
using ExerciseTracker.Data;
using ExerciseTracker.Repositories;
using ExerciseTracker.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient<Startup>();
services.AddDbContext<ExerciseContext>(options =>
{
    options.UseSqlite("Data Source=ExerciseTracker.db");
});
services.AddTransient<IExerciseRepository, ExerciseRepository>();
services.AddTransient<IExerciseService, ExerciseService>();

var serviceProvider = services.BuildServiceProvider();
var startup = serviceProvider.GetService<Startup>();

startup!.Run();