using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "For Translation", fileName = "Data to Translate")]
public class ChangeLanguage : ScriptableObject
{
    [System.Serializable]
    public class TextPair
    {
        public string greekText;
        public string englishText;
    }

    public List<TextPair> textPairs;
    public bool isGreek = true;

    public string GetText(int index)
    {
        if (index < 0 || index >= textPairs.Count) return string.Empty;
        return isGreek ? textPairs[index].greekText : textPairs[index].englishText;
    }

    public void ToggleLanguage()
    {
        isGreek = !isGreek;
    }
}
