using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public enum EnemyState2
{
    idle,
    walk,
    attack,
    stagger,
    death
}


public class Enemytest : MonoBehaviour
{
    public Spine.AnimationState currentAnimState;
    public EnemyState currentState;
    public FloatValue maxHealth;
    public float health;
    public int baseAttack;
    public float moveSpeed;

    private void Awake()
    {
        health = maxHealth.initialValue;
    }

    private void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            currentAnimState.SetAnimation(0,"Death", true);
            currentState = EnemyState.death;
            this.gameObject.SetActive(false);
        }
    }

    public void Knock(Rigidbody2D myRigidbody, float knockTime, float damage)
    {
        StartCoroutine(KnockCo(myRigidbody, knockTime));
        TakeDamage(damage);
    }


    private IEnumerator KnockCo(Rigidbody2D myRigidbody, float knockTime)
    {
        if(myRigidbody != null)
        {
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            currentAnimState.SetAnimation(0, "Idle", true);
            currentState = EnemyState.idle;
            myRigidbody.velocity = Vector2.zero;
        }
    }
}
