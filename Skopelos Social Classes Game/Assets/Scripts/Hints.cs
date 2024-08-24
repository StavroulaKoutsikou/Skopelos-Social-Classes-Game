using UnityEngine;
using UnityEngine.UI;

public class Hints : MonoBehaviour
{

    
    public Button showImageButton;
    public GameObject hint;
    public GameObject blackPanel;




// in start, dont activate hint panel
    public void Start()
    {
        hint.gameObject.SetActive(false);
        blackPanel.gameObject.SetActive(false);
    }

// show hint panel
    public void ShowHint()
    {
        hint.gameObject.SetActive(true);
        blackPanel.gameObject.SetActive(true);
    }

// hide hint panel
    public void HideHint(){
        hint.gameObject.SetActive(false);
        blackPanel.gameObject.SetActive(false);
    }

// toggle hint panel with button click

    public void ToggleHint()
    {
        hint.gameObject.SetActive(!hint.gameObject.activeSelf);
        blackPanel.gameObject.SetActive(!blackPanel.gameObject.activeSelf);
    }
    
}
