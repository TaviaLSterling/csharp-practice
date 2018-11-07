using SnapsLibrary;

class Ch04_06_TimeDisplay
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Is it time to get up?");

        if (SnapsEngine.GetHourValue() > 6)
            SnapsEngine.DisplayString("It Is Time To Get Up");
        else SnapsEngine.DisplayString("Go Back To Sleep");
    }
}