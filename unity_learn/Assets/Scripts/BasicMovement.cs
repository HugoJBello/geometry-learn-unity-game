using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public bool isDragging;
    public bool enters;

    private void OnMouseUp() {
        isDragging = false;

    }

    private void OnMouseDown() {
        isDragging = true;
    }

    void Update()
    {
        if (isDragging) {
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(position);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        enters = true;
    }
    private void OnTriggerStay2D(Collider2D other) {
                enters = true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        enters = false;
    }

}
