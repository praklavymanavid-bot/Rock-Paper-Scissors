using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator playerChoiceHandler;
    [SerializeField] private Animator choiceAnimation;

    public void ResetAnimations()
    {
        playerChoiceHandler.SetTrigger("ShowHandler");
        choiceAnimation.SetTrigger("RemoveChoices");
    }

    public void PlayerMadeChoice()
    {
        playerChoiceHandler.SetTrigger("RemoveHandler");
        choiceAnimation.SetTrigger("ShowChoices");
    }
}

