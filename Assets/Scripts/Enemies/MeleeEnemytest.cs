using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class MeleeEnemytest : OriginalEnemytest
{

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void CheckDistance()
    {
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius
            && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            if (currentState == EnemyState.idle || currentState == EnemyState.walk
                && currentState != EnemyState.stagger)
            {
                Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
                ChangeAnim(temp - transform.position);
                myRigidbody.MovePosition(temp);
                ChangeState(EnemyState.walk);
                currentAnimState.AddAnimation(0, "Walk", true, 0);
            }
        }
        else if (Vector3.Distance(target.position, transform.position) <= chaseRadius
            && Vector3.Distance(target.position, transform.position) <= attackRadius)
        {
            if (currentState == EnemyState.walk && currentState != EnemyState.stagger)
            {
                StartCoroutine(AttackCo());
            }
        }
    }

    public IEnumerator AttackCo()
    {
        currentState = EnemyState.attack;
        currentAnimState.SetAnimation(0, "attack", true);
        yield return new WaitForSeconds(1f);
        currentState = EnemyState.walk;
        currentAnimState.SetAnimation(0, "walk", true);
    }
}
