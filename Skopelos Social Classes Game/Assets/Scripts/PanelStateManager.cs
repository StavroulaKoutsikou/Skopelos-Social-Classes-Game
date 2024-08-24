using UnityEngine;
using UnityEngine.UI;

public class PanelStateManager : MonoBehaviour
{
    public static int CorrectButtonClickCount_1 { get; private set; }
    public static int CorrectButtonClickCount_2 { get; private set; }
    public static int CorrectButtonClickCount_3 { get; private set; }
    public static bool WrongButtonHit { get; set; }

    // Method to record the wrong button click
    public static void RecordWrongButtonClick()
    {
        WrongButtonHit = true;
        if(!(CorrectButtonClickCount_1 >= 3))
        {
            CorrectButtonClickCount_1 = 0;
        }
        if(!(CorrectButtonClickCount_2 >= 3))
        {
            CorrectButtonClickCount_2 = 0;
        }
        if(!(CorrectButtonClickCount_3 >= 3))
        {
            CorrectButtonClickCount_3 = 0;
        }
    }

    // Method to record the correct button click
    public static void RecordCorrectButtonClick(int category)
    {
        switch (category)
        {
            case 1:
                CorrectButtonClickCount_1++;
                Debug.Log("Correct button clicked. Count: " + CorrectButtonClickCount_1);
                break;
            case 2:
                CorrectButtonClickCount_2++;
                Debug.Log("Correct button clicked. Count: " + CorrectButtonClickCount_2);
                break;
            case 3:
                CorrectButtonClickCount_3++;
                Debug.Log("Correct button clicked. Count: " + CorrectButtonClickCount_3);
                break;
        }
    }

    // Method to check if the correct amount of buttons are clicked
    public static bool IsCorrectClicks(int category)
    {
        switch (category)
        {
            case 1:
                return CorrectButtonClickCount_1 >= 3;
            case 2:
                return CorrectButtonClickCount_2 >= 3;
            case 3:
                return CorrectButtonClickCount_3 >= 3;
            default:
                return false;
        }
    }

    // Method to reset the correct button click count
    public static void ResetCorrectButtonClickCounts()
    {
        CorrectButtonClickCount_1 = 0;
        CorrectButtonClickCount_2 = 0;
        CorrectButtonClickCount_3 = 0;
    }
}
