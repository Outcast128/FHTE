using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class MeleeEnemy : GeneralEnemy
{
    // Variables to control enemy behavior
    public float attackDistance;
    public int damage;
    public float attackCooldown;
    public float lastAttackTime;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        // Call start method from parent script
        //base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        // Call update method from parent script
        //base.Update();

        // Check if player is within attack distance
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPlayer < attackDistance && Time.time > lastAttackTime + attackCooldown)
        {
            lastAttackTime = Time.time;

            // Play attack animation
            //skeletonAnimation.AnimationState.SetAnimation(0, "Attack", false);
        }
    }
}