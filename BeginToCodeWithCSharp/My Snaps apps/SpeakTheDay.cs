using SnapsLibrary;

public class SpeakTheDay
{
    public void StartProgram()
    {
        string myName = SnapsEngine.ReadString("What is your name?");
        string dayName = SnapsEngine.GetDayOfWeekName();
        SnapsEngine.DisplayString("Good day" + myName + "How are you doing on this fine " + dayName);
        SnapsEngine.SpeakString("Good day " +  myName  + " . How are you doing on this fine " + dayName + " ?");
    }
}


