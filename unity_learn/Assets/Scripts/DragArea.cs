using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class DragArea : MonoBehaviour
{
        public Animator animator;
        public bool enters;

    private void OnTriggerEnter2D(Collider2D other) {
        animator.SetBool("IsActive",true);
        enters = true;
    }
    private async void OnTriggerStay2D(Collider2D other) {
                enters = true;
                await WaitOneSecondAsync();
                if (other) {
                Destroy (other.gameObject);
                }
    }

    private void OnTriggerExit2D(Collider2D other) {
        animator.SetBool("IsActive",false);
        enters = false;
    }

   private async Task WaitOneSecondAsync()
    {
        await Task.Delay(1000);
    }

}
