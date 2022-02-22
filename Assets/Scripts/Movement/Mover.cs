using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class Mover : MonoBehaviour
{
    [SerializeField] Transform target; 
    Vector3 destination;
    NavMeshAgent agent; 
   

    void Update()
    {//

    if(Input.GetMouseButton(0))
    { 
        
       MoveToCursor();
     

    }

    UpdateAnimator(); 
       
        
    }

    private void MoveToCursor () 
    {
     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
     RaycastHit hit; 

     bool hasHit = Physics.Raycast(ray, out hit);
     if(hasHit) 
     {
          GetComponent<NavMeshAgent>().destination = hit.point; 
     }
    }

    private void UpdateAnimator ()
    {
        Vector3 velocity = GetComponent<NavMeshAgent>().velocity;//global values
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);//tells the animation to move in what direction 

        float speed = localVelocity.z; 
        GetComponent<Animator>().SetFloat("ForwardSpeed", speed); 




        

    }

       
            
}
