using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour
{

    public AnimationFadeOut fadeOutAnimation;
    // Public field to set the scene number in the Inspector
    public int sceneNumber;

    public void RestartGame()
    {
        
        // Reset the counts in PanelStateManager
        PanelStateManager.ResetCorrectButtonClickCounts();
        PanelStateManager.WrongButtonHit = false;

        // Reset image counts in DisplayImageOnCorrectClick
        DisplayImageOnCorrectClick.image_1_count = 0;
        DisplayImageOnCorrectClick.image_2_count = 0;
        DisplayImageOnCorrectClick.image_3_count = 0;

        // reset piece placed
        PuzzleManager.piecesPlaced = 0;

        // Reset the holes
        Hole.ResetHoles();

        // Reload the scene with the specified scene number
        StartCoroutine(LoadSceneCoroutine(sceneNumber));

        
        
    }

    // coroutine for playing fade out animation before changing a scene and going to another
    private IEnumerator LoadSceneCoroutine(int sceneNumber)
    {
        fadeOutAnimation.playAnimation();
        yield return new WaitUntil(() => !fadeOutAnimation.isAnimating);
        SceneManager.LoadSceneAsync(sceneNumber);
    }
}
