using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragArea : MonoBehaviour
{
        public Animator animator;
        public bool enters;

    private void OnTriggerEnter2D(Collider2D other) {
        animator.SetBool("IsActive",true);
        enters = true;
    }
    private void OnTriggerStay2D(Collider2D other) {
                enters = true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        animator.SetBool("IsActive",false);
        enters = false;
    }
}
