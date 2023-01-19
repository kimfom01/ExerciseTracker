using ExerciseTracker;
using ExerciseTracker.Controller;
using ExerciseTracker.Data;
using ExerciseTracker.Repositories;
using ExerciseTracker.Services;
using ExerciseTracker.UserInput;
using ExerciseTracker.Validations;
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
services.AddTransient<IExerciseController, ExerciseController>();
services.AddTransient<IInput, Input>();
services.AddTransient<IInputValidation, InputValidation>();

var serviceProvider = services.BuildServiceProvider();
var startup = serviceProvider.GetService<Startup>();

startup!.Run();