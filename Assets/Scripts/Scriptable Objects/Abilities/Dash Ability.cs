using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[CreateAssetMenu(menuName = "Scriptable Objects/Abilities/Dash Ability", fileName = "Dash Ability")]
public class DashAbility : GenericAbility
{
    public float dashForce;

    public override void Ability(Vector2 playerPosition, Vector2 playerFacingDirection,
                    Animator playerAnimator = null, Rigidbody2D playerRigidbody = null)
    {
        // MAke sure the player can dash

        // If not then just exit method (return)

        if (playerRigidbody)
        {
            Vector3 dashVector = playerRigidbody.transform.position +
                (Vector3)playerFacingDirection.normalized * dashForce;
            playerRigidbody.DOMove(dashVector, duration);
        }
    }
}
