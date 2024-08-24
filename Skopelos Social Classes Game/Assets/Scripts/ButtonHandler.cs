using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{

    // Method to record the correct button click
    public void OnCorrectButtonClick(int category)
    {
        PanelStateManager.RecordCorrectButtonClick(category);
    }

    // Method to record the wrong button click
    public void OnWrongButtonClick()
    {
        PanelStateManager.RecordWrongButtonClick();
    }

}
