using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{  
    [SerializeField] float xReturn = 0;
    [SerializeField] float yReturn = 0;
    [SerializeField] float zReturn = 0;

    void Update()
    {
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = new Vector3(xReturn, yReturn, zReturn);
        }
    }
}
