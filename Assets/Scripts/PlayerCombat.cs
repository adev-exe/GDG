using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Describes the Player attack parameters
public class PlayerCombat : MonoBehaviour
{
    // Refrence to the attackPoint obj
    public Transform attackPoint;

    public float attackRange = 1f;
    public float attackSpeed = 1f;
    public LayerMask enemyLayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }
    }
    
    void Attack()
    {
        // Play Attack Annimation
        PlayerMovement.anim.SetTrigger("Attack");

        // Detect enemies in range
        Collider2D[] hitTargets = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);

        // Aplly Dmg to enemies
        foreach(Collider2D target in hitTargets)
        {
            target.GetComponent<TargetInteractions>().IsHit();
        }
    }

    // Makes the attack range a visible circle in unity
    void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
