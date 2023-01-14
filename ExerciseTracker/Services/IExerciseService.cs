using ExerciseTracker.Models;

namespace ExerciseTracker.Services;

public interface IExerciseService
{
    public void RecordNewExercise(Exercise exercise);
    public void UpdateExistingExercise(int id, Exercise exercise);
    public List<Exercise> GetAllExercises();
    public Exercise GetExerciseById(int id);
    public void DeleteExercise(int id);
}
