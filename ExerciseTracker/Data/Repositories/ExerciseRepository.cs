using ExerciseTracker.Data.DataContext;

namespace ExerciseTracker.Data.Repositories;

public class ExerciseRepository : Repository, IExerciseRepository
{
    public ExerciseRepository(ExerciseContext exerciseContext) : base(exerciseContext)
    {
    }
}