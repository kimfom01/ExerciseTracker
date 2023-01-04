using ExerciseTracker.Data.DataContext;
using ExerciseTracker.Models;

namespace ExerciseTracker.Data.Repositories;

public abstract class Repository : IRepository
{
    private readonly ExerciseContext _exerciseContext;

    protected Repository(ExerciseContext exerciseContext)
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