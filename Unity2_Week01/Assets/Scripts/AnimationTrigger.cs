using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private string stateToPlay;

    private void OnTriggerEnter2D(Collider2D _col)
    {
        anim.Play(stateToPlay, 0);
    }


}
