using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AnimationFadeOut : MonoBehaviour
{
    public Image AnimationFadeInImage;
    public Sprite[] ArrayOfAnimationFadeOut;
    public float speed = .02f;

    private int indexSprite;
    private Coroutine animationCoroutine;
    public bool isAnimating;
    public bool animationComplete;

 // for the fade out animation to start. if this script is in a scene, the animation fade out will start when the user clicks a button to go to another scene
    public void playAnimation()
    {
        if (isAnimating) return;
        isAnimating = true;
        animationComplete = false; 
        indexSprite = 0;
        AnimationFadeInImage.raycastTarget = true; 
        animationCoroutine = StartCoroutine(playAnimationCoroutine());
    }

 // play the animation
    private IEnumerator playAnimationCoroutine()
    {
        while (isAnimating && indexSprite < ArrayOfAnimationFadeOut.Length)
        {
            AnimationFadeInImage.sprite = ArrayOfAnimationFadeOut[indexSprite];
            indexSprite++;
            yield return new WaitForSeconds(speed);
        }
        isAnimating = false;
        AnimationFadeInImage.raycastTarget = false;
        animationComplete = true;
    }
}
