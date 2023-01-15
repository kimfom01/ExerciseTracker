using ExerciseTracker.Models;

namespace ExerciseTracker.Services;

public interface IExerciseService
{
    public void RecordNewExercise();
    public void UpdateExistingExercise();
    public List<Exercise> GetAllExercises();
    public Exercise GetExerciseById();
    public void DeleteExercise();
}
