using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] string message;
    
    private void OnTriggerEnter2D(Collider2D other) {
    }
}
