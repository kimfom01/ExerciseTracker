using ExerciseTracker;
using ExerciseTracker.Data.DataContext;
using ExerciseTracker.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddDbContext<ExerciseContext>();
services.AddTransient<IExerciseRepository, ExerciseRepository>();

var serviceProvider = services.BuildServiceProvider();
var startup = serviceProvider.GetService<Startup>();

startup!.Run();