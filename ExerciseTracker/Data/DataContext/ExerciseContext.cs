using ExerciseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.Data.DataContext;

public class ExerciseContext : DbContext
{
    public DbSet<Exercise> Exercises { get; set; }
    
    public ExerciseContext(DbContextOptions<ExerciseContext> options) : base(options)
    {
    }
}