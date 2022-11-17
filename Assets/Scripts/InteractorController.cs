using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractorController : MonoBehaviour
{
    private PlayerController parent;

    private void Start() {
        parent = transform.parent.GetComponent<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        parent.InteractableTriggerEnter(other.tag);
    }
    private void OnTriggerExit2D(Collider2D other) {
        parent.InteractableTriggerExit();
    }
}
