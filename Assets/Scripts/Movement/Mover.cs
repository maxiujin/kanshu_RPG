
using UnityEngine;
using UnityEngine.AI;
using RPG.Core; 




namespace RPG.Movement 
{
    public class Mover : MonoBehaviour, IAction
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
        GetComponent<ActionScheduler>().StartAction(this); 
       
        MoveTo(destination); 

     }

  
     public void Cancel ()
     {

         navMeshAgent.isStopped = true; 

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

