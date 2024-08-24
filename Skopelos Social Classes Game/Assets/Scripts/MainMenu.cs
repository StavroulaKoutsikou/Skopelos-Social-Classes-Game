using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.Playables;

public class MainMenu : MonoBehaviour
{
    public AnimationFadeOut fadeOutAnimation;
    public UISpriteAnimation fadeInAnimation;
    public VideoPlayer videoPlayerController;
    public RenderTexture renderTexture;
    public PlayableDirector playable;

    bool Skip = false;

    [SerializeField] public int sceneNumber;

    public static bool Category_1 = false;
    public static bool Category_2 = false;
    public static bool Category_3 = false;

    // win functions for each category
    public static void WinCategory_1()
    {
        Category_1 = true;
    }

    public static void WinCategory_2()
    {
        Category_2 = true;
    }

    public static void WinCategory_3()
    {
        Category_3 = true;
    }




    // for the video player in StoryTelling scene
    private void Awake()
    {
        if (videoPlayerController != null)
        {
            videoPlayerController.Prepare();
        }
    }

    private void Start()
    {
        if (videoPlayerController != null)
        {
            videoPlayerController.Play();
        }
    }


    // for Quit button
    public void QuitGame()
    {
        //FindAnyObjectByType<AudioSource>().Play();
        Application.Quit();
    }
// in any button with MainMenu script, call this function to load a scene with the sceneNumber
    public void LoadScene(int sceneNumber)
    {
        //FindAnyObjectByType<AudioSource>().Play();

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
