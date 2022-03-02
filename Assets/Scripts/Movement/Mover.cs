using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using RPG.Combat; 




namespace RPG.Movement 
{
    public class Mover : MonoBehaviour
{
    [SerializeField] Transform target; 
    NavMeshAgent navMeshAgent;
    Vector3 destination;
    NavMeshAgent agent; 
   

 private void Start()
{
 navMeshAgent = GetComponent<NavMeshAgent>();     
}
    void Update()
    {//

    // if(Input.GetMouseButton(0))
    // { 
        
    //    MoveToCursor();
     

    // }

    UpdateAnimator(); 
       
        
    }

    public void MoveTo(Vector3 destination)
    {
       navMeshAgent.destination = destination;
       navMeshAgent.isStopped = false; 
      
    }
     
     public void StartMoveAction (Vector3 destination) 
     {
        GetComponent<Fighter>().Cancel(); 
        MoveTo(destination); 

     }

     public void Stop()
     {
         navMeshAgent.isStopped = true; 
        //  GetComponent<Fighter>().Cancel(); 
     }
    private void UpdateAnimator ()
    {
        Vector3 velocity = navMeshAgent.velocity;//global values
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);//tells the animation to move in what direction 

        float speed = localVelocity.z; 
        GetComponent<Animator>().SetFloat("ForwardSpeed", speed); 




        

    }

       
            
}


}

