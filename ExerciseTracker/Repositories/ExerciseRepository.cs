using ExerciseTracker.Data;

namespace ExerciseTracker.Repositories;

public class ExerciseRepository : Repository, IExerciseRepository
{
    public ExerciseRepository(ExerciseContext exerciseContext) : base(exerciseContext)
    {
    }
}