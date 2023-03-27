using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemytest : OriginalEnemytest
{
    public GameObject projectile;
    public float fireDelay;
    private float fireDelaySeconds;
    public bool canFire = true;

    void Update()
    {
        fireDelaySeconds -= Time.deltaTime;
        if(fireDelaySeconds <= 0)
        {
            canFire = true;
            fireDelaySeconds = fireDelay; 
        }
    }

    public override void CheckDistance()
    {
        if(Vector3.Distance(target.position, transform.position) <= chaseRadius
            && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            if (canFire)
            {
                Vector3 tempVector = target.transform.position - transform.position;
                GameObject current = Instantiate(projectile, transform.position, Quaternion.identity);
                current.GetComponent<Projectiles>().Launch(tempVector);
                canFire = false;
                ChangeState(EnemyState.walk);
                currentAnimState.AddAnimation(0, "Walk", true, 0);
            }
            else
            {
                Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
                ChangeAnim(temp - transform.position);
                myRigidbody.MovePosition(temp);
                ChangeState(EnemyState.walk);
                currentAnimState.AddAnimation(0, "Walk", true, 0);

            }
            
        }
    }   
}
