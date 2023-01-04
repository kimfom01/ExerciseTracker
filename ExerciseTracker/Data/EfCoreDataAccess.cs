using ExerciseTracker.DataContext;
using ExerciseTracker.Models;

namespace ExerciseTracker.Data;

public class EfCoreDataAccess : IDataAccess
{
    private readonly ExerciseContext _exerciseContext;

    public EfCoreDataAccess(ExerciseContext exerciseContext)
    {
        _exerciseContext = exerciseContext;
    }

    public IEnumerable<Exercise> GetExercises()
    {
        return _exerciseContext.Exercises;
    }

    public Exercise GetExerciseById(int id)
    {
        return _exerciseContext.Exercises.FirstOrDefault(x => x.Id == id);
    }

    public void AddExercise(Exercise exercise)
    {
        _exerciseContext.Add(exercise);
    }

    public void UpdateExercise(int id, Exercise exercise)
    {
        var exerciseToBeUpdated = GetExerciseById(id);
        exerciseToBeUpdated.StartDate = exercise.StartDate;
        exerciseToBeUpdated.EndDate = exercise.EndDate;
        exerciseToBeUpdated.Comments = exercise.Comments;
    }

    public void DeleteExercise(int id)
    {
        var exerciseToBeDeleted = GetExerciseById(id);
        _exerciseContext.Remove(exerciseToBeDeleted);
    }

    public int SaveChanges()
    {
        return _exerciseContext.SaveChanges();
    }
}