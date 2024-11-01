using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        DuckoController controller = other.GetComponent<DuckoController>();
        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destory(gameObject);
        }
        
    }
}