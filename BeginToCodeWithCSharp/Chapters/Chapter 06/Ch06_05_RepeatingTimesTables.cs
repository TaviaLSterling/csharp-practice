using SnapsLibrary;

class Ch06_05_RepeatingTimesTables
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Talking Times Tables");
        
        while (true)
        {
            int newValue;
            int count = 1;
            string timesValue = SnapsEngine.ReadString("Pick a number");
            newValue = int.Parse(timesValue);

            while (count < 13)
            {
                int result = count * newValue;

                string message = count.ToString() +
                    " times " + newValue.ToString() +
                    " is " + result.ToString();

                SnapsEngine.DisplayString(message);
                SnapsEngine.SpeakString(message);
                count = count + 1;
            }
            SnapsEngine.WaitForButton("Press to continue");
        }
    }
}