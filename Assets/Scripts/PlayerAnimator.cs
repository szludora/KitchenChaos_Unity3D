using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string IS_WALKING = "IsWalking";
    private Animator anim;
    [SerializeField] private Player player;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        anim.SetBool(IS_WALKING, player.IsWalking());
    }

    private void Update()
    {
        anim.SetBool(IS_WALKING, player.IsWalking());
    }
}
