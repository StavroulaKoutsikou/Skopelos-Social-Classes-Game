using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LanguageChanger : MonoBehaviour
{
    public ChangeLanguage languageData;
    public List<TextMeshProUGUI> textComponents; 
    

    void Start()
    {
        UpdateTexts();
    }

    // when the button is clicked, the language is switched
    public void OnSwitchLanguage()
    {
        languageData.ToggleLanguage();
        UpdateTexts();
    }

    // the texts are updated

    void UpdateTexts()
    {
        for (int i = 0; i < textComponents.Count; i++)
        {
            if (i < languageData.textPairs.Count)
            {
                textComponents[i].text = languageData.GetText(i);
            }
        }
    }
}
