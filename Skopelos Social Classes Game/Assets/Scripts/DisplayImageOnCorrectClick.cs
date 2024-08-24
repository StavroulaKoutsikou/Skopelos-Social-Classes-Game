using UnityEngine;
using UnityEngine.UI;

public class DisplayImageOnCorrectClick : MonoBehaviour
{
    public GameObject imageToShow1;
    public GameObject imageToShow2;
    public GameObject imageToShow3;

    public GameObject imageToHide1;
    public GameObject imageToHide2;
    public GameObject imageToHide3;

    public static int image_1_count = 0;
    public static int image_2_count = 0;
    public static int image_3_count = 0;

   // public GameObject NotificationToShow1;

    private void Start()
    {
        Debug.Log("if_1" + image_1_count);
        Debug.Log("if_2" + image_2_count);
        Debug.Log("if_3" + image_3_count);

        // if the correct amount of buttons are clicked, the images are displayed
        if (PanelStateManager.CorrectButtonClickCount_1 >= 3)
        {
           imageToShow1.SetActive(true);
           imageToHide1.SetActive(false);
        }

        if (PanelStateManager.CorrectButtonClickCount_2 >= 3)
        {
            imageToShow2.SetActive(true);
            imageToHide2.SetActive(false);
        }

        if (PanelStateManager.CorrectButtonClickCount_3 >= 3)
        {
            imageToShow3.SetActive(true);
            imageToHide3.SetActive(false);
        }

        // if the correct amount of buttons are clicked, the notification is displayed
       /* if (PanelStateManager.CorrectButtonClickCount_1 >= 3 && image_1_count == 0)
        {
            NotificationToShow1.SetActive(true);
            image_1_count++;
        }
        if (PanelStateManager.CorrectButtonClickCount_2 >= 3 && image_2_count == 0)
        {
            NotificationToShow1.SetActive(true);
            image_2_count++;
        }
        if (PanelStateManager.CorrectButtonClickCount_3 >= 3 && image_3_count == 0)
        {
            NotificationToShow1.SetActive(true);
            image_3_count++;
        }*/
    }
       
    // method to set the alpha of the image, and make it appear

}
