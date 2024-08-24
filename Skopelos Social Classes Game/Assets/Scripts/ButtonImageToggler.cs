using UnityEngine;
using UnityEngine.UI;

public class ButtonImageToggler : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;

    private Image buttonImage;
    private bool isImage1;

    void Start()
    {
        buttonImage = GetComponent<Image>();
        if (buttonImage == null)
        {
            Debug.LogError("ButtonImageToggler script must be attached to a GameObject with an Image component.");
            return;
        }

        if (image1 == null || image2 == null)
        {
            Debug.LogError("Please assign both image1 and image2 in the Inspector.");
            return;
        }
        buttonImage.sprite = image1;
        isImage1 = true;
    }
 
    // Method to toggle between two images
    public void ToggleImage()
    {
        if (buttonImage == null) 
        {
            Debug.LogError("buttonImage is not assigned.");
            return;
        }

        if (isImage1)
        {
            buttonImage.sprite = image2;
        }
        else
        {
            buttonImage.sprite = image1;
        }
        isImage1 = !isImage1;
    }

    // Method to set the color of the button image
    public void SetImageColor(Color newColor)
    {
        if (buttonImage == null) 
        {
            Debug.LogError("buttonImage is not assigned.");
            return;
        }
        buttonImage.color = newColor;
    }

    // Methods to set the color of the button image to red, green, or white. 
    public void SetRedColor()
    {
        SetImageColor(Color.red);
    }

    public void SetGreenColor()
    {
        SetImageColor(Color.green);
    }

    public void SetWhiteColor()
    {
        SetImageColor(new Color(1f, 1f, 1f));
    }




}
