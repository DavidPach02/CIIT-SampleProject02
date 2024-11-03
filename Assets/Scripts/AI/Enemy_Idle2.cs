using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Idle2 : StateMachineBehaviour
{
    TestEnemy testEnemyRef;
    Transform targetTransform;
    int index = 0;

    public float speed = 1f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        testEnemyRef = animator.GetComponent<TestEnemy>();

        targetTransform = testEnemyRef.positions[index];
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log(animator.gameObject.name + " update");

        Vector3 moveDirection = targetTransform.position - animator.transform.position;
        Vector3 normalizedDir = moveDirection.normalized;
        animator.gameObject.transform.position += normalizedDir * speed * Time.deltaTime;

        Debug.Log(normalizedDir);
        animator.GetComponent<SpriteRenderer>().flipX = normalizedDir.x > 0;

        if (Vector3.Distance(animator.transform.position, targetTransform.position) <= 0.5f)
        {
            index++;
            if (index >= testEnemyRef.positions.Count)
            {
                index = 0;
            }

            targetTransform = testEnemyRef.positions[index];
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log(animator.gameObject.name + " exit");
    }
}
