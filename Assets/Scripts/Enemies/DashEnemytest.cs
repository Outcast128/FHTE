using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashEnemy : OriginalEnemytest
{
    private bool canDash;
    private bool isDashing;
    public float dashAmount;

    // Update is called once per frame
    void Update()
    {
    }
}

    /*public override void CheckDistance()
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
                anim.SetBool("moving", true);
            }
        }
        else if (Vector3.Distance(target.position, transform.position) <= chaseRadius
            && Vector3.Distance(target.position, transform.position) <= attackRadius)
        {
            if (currentState == EnemyState.idle || currentState == EnemyState.walk
                && currentState != EnemyState.stagger)
            {
                if (canDash)
                {
                    anim.SetBool("moving", false);
                    currentState = EnemyState.attack;
                    StartCoroutine(DashCo());
                }
                if (isDashing)
                {
                    //ignore input
                }
                else 
                {
                    //ignore input
                }
            }
        }
        else
        {
            anim.SetBool("moving", false);
        }
    }

    public IEnumerator DashCo()
    {
        canDash = false;
        isDashing = true;
        //perform the dash
        myRigidbody.MovePosition(transform.position + target.position * dashAmount);
        yield return new WaitForSeconds(2f);
        isDashing = false;
        canDash = true;
    }
}
    */