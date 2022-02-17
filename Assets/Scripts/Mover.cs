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

    if(Input.GetMouseButtonDown(0))
    { //if(Input.GetKey(KeyCode.Mouse0)){
        
       MoveToCursor();

    }
       
        
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

       
            
}
