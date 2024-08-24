using UnityEngine;
using System.Collections;

public class PuzzleManager : MonoBehaviour
{
    public float delayBeforeShowingPanel = 1.0f;
    public float fadeDuration = 1.0f;

    private static int totalPieces = 9;
    public static int piecesPlaced = 0;
    public CanvasGroup canvasGroup;


    private void Start()
    {
        canvasGroup.interactable = false;
    }
    public static void PiecePlaced()
    {
        piecesPlaced++;
        Debug.Log(piecesPlaced);

        if (piecesPlaced >= totalPieces)
        {
            FindObjectOfType<PuzzleManager>().StartCoroutine("ShowCompletePanelWithDelay");
        }
    }

    private IEnumerator ShowCompletePanelWithDelay()
    {
        yield return new WaitForSeconds(delayBeforeShowingPanel);
        canvasGroup.interactable = true;
        yield return StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        float startAlpha = canvasGroup.alpha;
        float timeElapsed = 0f;

        while (timeElapsed < fadeDuration)
        {
            // Calculate the new alpha value
            canvasGroup.alpha = Mathf.Lerp(startAlpha, 1f, timeElapsed / fadeDuration);
            timeElapsed += Time.deltaTime;

            // Yield until the next frame
            yield return null;
        }

        // Ensure the alpha is set to exactly 1
        canvasGroup.alpha = 1f;
    }
}
