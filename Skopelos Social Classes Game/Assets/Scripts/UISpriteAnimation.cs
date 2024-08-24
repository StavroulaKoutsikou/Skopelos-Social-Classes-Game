using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UISpriteAnimation : MonoBehaviour
{
    public Image AnimationFadeOutImage;
    public Sprite[] ArrayOfAnimationFadeOut;
    public float speed = .02f;

    private int indexSprite;
    private Coroutine animationCoroutine;
    public bool isAnimating;
    

    public void playAnimation()
    {
        if (isAnimating) return;
        isAnimating = true;
        indexSprite = 0;
        AnimationFadeOutImage.raycastTarget = true;
        animationCoroutine = StartCoroutine(playAnimationCoroutine());
    }


    private IEnumerator playAnimationCoroutine()
    {
        while (isAnimating && indexSprite < ArrayOfAnimationFadeOut.Length)
        {
            AnimationFadeOutImage.sprite = ArrayOfAnimationFadeOut[indexSprite];
            indexSprite++;
            yield return new WaitForSeconds(speed);
        }
        isAnimating = false; 
        AnimationFadeOutImage.raycastTarget = false;
    }
}
