using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimationFadeIn : MonoBehaviour
{
    [SerializeField] private UISpriteAnimation FadeAnimation;

    // for the fade in animation to start. if this script is in a scene, the animation fade in will start in the scene
    public void Start()
    {
        if(FadeAnimation != null)
        {
            FadeAnimation.playAnimation();
        }
    }
}
