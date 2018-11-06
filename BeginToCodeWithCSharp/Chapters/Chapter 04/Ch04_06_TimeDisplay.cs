using SnapsLibrary;

class Ch04_06_TimeDisplay
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Current Time");
        int hourValue = SnapsEngine.GetHourValue();
        int minuteValue = SnapsEngine.GetMinuteValue();
        bool ItIsTimeToGetUp = hourValue > 6;
        SnapsEngine.SetDisplayStringSize(20);
        if(ItIsTimeToGetUp)
        SnapsEngine.DisplayString("The time is " + hourValue + ":" + minuteValue);
        SnapsEngine.Delay(4);
        SnapsEngine.DisplayString("It is time to get up");
    }
}