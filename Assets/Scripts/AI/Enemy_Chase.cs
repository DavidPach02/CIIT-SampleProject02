using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Chase : StateMachineBehaviour
{
    TestEnemy testEnemyRef;
    TestPlayer testPlayerRef;

    public float speed = 3f;

    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        testEnemyRef = animator.GetComponent<TestEnemy>();
        testPlayerRef = testEnemyRef.playerRef;
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (testPlayerRef != null)
        {
            Vector3 moveDirection = testPlayerRef.transform.position - animator.transform.position;
            Vector3 normalizedDir = moveDirection.normalized;
            Vector3 finalMoveDir = new Vector3(normalizedDir.x, 0f);
            animator.gameObject.transform.position += finalMoveDir * speed * Time.deltaTime;

            animator.GetComponent<SpriteRenderer>().flipX = normalizedDir.x > 0;
        }
    }

    //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
