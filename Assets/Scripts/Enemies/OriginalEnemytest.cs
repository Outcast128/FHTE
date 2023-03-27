using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class OriginalEnemytest : Enemytest
{
    public Rigidbody2D myRigidbody;

    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    public Transform homePosition;

    public SkeletonAnimation anim;
    public Spine.Skeleton skeleton;

    // Start is called before the first frame update
    void Start()
    {
        currentState = EnemyState.idle;
        currentAnimState.SetAnimation(0, "Idle", true);
        myRigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<SkeletonAnimation>();
        skeleton = anim.Skeleton;

        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckDistance();
    }

    public virtual void CheckDistance()
    {
        if(Vector3.Distance(target.position, transform.position) <= chaseRadius
            && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            if (currentState == EnemyState.idle || currentState == EnemyState.walk
                && currentState != EnemyState.stagger)
            {
                Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
                ChangeAnim(temp - transform.position);
                myRigidbody.MovePosition(temp);
                ChangeState(EnemyState.walk);
                currentAnimState.SetAnimation(0, "Walk", true);


            }
            
        }
        else if (Vector3.Distance(target.position, transform.position) > chaseRadius)
        {
            currentAnimState.SetAnimation(0, "Idle", true);
            currentState = EnemyState.idle;
        }
    }

    public void SetAnimFloat(Vector2 setVector)
    {
        if (setVector == Vector2.right)
        {
            skeleton.ScaleX = -1;
            skeleton.ScaleY = -1;
        }
        else if (setVector == Vector2.left)
        {
            skeleton.ScaleX = 1;
            skeleton.ScaleY = 1;
        }
        else if (setVector == Vector2.up)
        {
            skeleton.ScaleX = 0;
            skeleton.ScaleY = 1;
        }
        else if (setVector == Vector2.down)
        {
            skeleton.ScaleX = 0;
            skeleton.ScaleY = -1;
        }
    }


    public void ChangeAnim(Vector2 direction)
    {
        if(Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            if(direction.x > 0)
            {
                SetAnimFloat(Vector2.right);
            }
            else if(direction.x < 0)
            {
                SetAnimFloat(Vector2.left);
            }
        }
        else if(Mathf.Abs(direction.x) < Mathf.Abs(direction.y))
        {
            if(direction.y > 0)
            {
                SetAnimFloat(Vector2.up);
            }
            else if(direction.y < 0)
            {
                SetAnimFloat(Vector2.down);
            }
        }
    }

    public void ChangeState(EnemyState newState)
    {
        if (currentState != newState)
        {
            currentState = newState;
        }
    }
}
