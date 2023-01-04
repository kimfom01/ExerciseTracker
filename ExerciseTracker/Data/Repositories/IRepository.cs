using ExerciseTracker.Models;

namespace ExerciseTracker.Data.Repositories;

public interface IRepository
{
    public IEnumerable<Exercise> GetExercises();
    public Exercise GetExerciseById(int id);
    public void AddExercise(Exercise exercise);
    public void UpdateExercise(int id, Exercise exercise);
    public void DeleteExercise(int id);
    public int SaveChanges();
}