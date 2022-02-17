using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class Mover : MonoBehaviour
{
    [SerializeField] Transform target; 
    Vector3 destination;
    NavMeshAgent agent; 
    [SerializeField] float speed= 10f; 

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {//
       
            GetComponent<NavMeshAgent>().destination = target.position; 
        
        
    }
}
