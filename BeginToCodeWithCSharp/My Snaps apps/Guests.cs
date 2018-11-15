using SnapsLibrary;

class Guests
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Guest List");

        // Find out how many sales values are being stored
        int noOfGuests = SnapsEngine.ReadInteger("How many guests will there be?");
        int[] guests = new int[noOfGuests];
        string nameOfGuests = SnapsEngine.ReadString("Enter the name for each guest");
        string[] guestNames = new string[nameOfGuests];
        // Loop round and read the sales values
        for (int count = 0; count < guests.Length; count = count + 1)
        {
            // User likes to count from 1, not zero
            int displayCount = count + 1;
            guestNames[count] = SnapsEngine.ReadString("Enter the name for guest " + displayCount);
        }

        // Got the sales figures, now display them

        SnapsEngine.ClearTextDisplay();

        // Add a line to the display for each sales figure
        for (int count = 0; count < guests.Length; count = count + 1)
        {
            SnapsEngine.AddLineToTextDisplay("Name: " + guests[count]);
        }
    }
}
