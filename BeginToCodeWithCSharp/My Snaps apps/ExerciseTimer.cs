using SnapsLibrary;

public class ExerciseTimer
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Workout Time!");
        SnapsEngine.DisplayString("Jog in Place");
        SnapsEngine.SpeakString("start Jogging in Place");
        SnapsEngine.Delay(30);
        SnapsEngine.SpeakString("rest");
        SnapsEngine.Delay(10);
        SnapsEngine.DisplayString("Push-ups");
        SnapsEngine.SpeakString("start push ups");
        SnapsEngine.Delay(30);
        SnapsEngine.SpeakString("rest");
        SnapsEngine.Delay(10);
        SnapsEngine.DisplayString("Jumping Jacks");
        SnapsEngine.SpeakString("start Jumping jacks");
        SnapsEngine.Delay(30);
        SnapsEngine.SpeakString("rest");
        SnapsEngine.Delay(10);
        SnapsEngine.DisplayString("Squats");
        SnapsEngine.SpeakString("start squats");
        SnapsEngine.Delay(30);
        SnapsEngine.SpeakString("rest");
        SnapsEngine.Delay(10);
        SnapsEngine.DisplayString("Sit-ups");
        SnapsEngine.SpeakString("start sit ups");
        SnapsEngine.Delay(30);
        SnapsEngine.SpeakString("rest");
        SnapsEngine.Delay(10);
    }
}


