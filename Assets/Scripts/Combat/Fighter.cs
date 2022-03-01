using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Movement; 

namespace RPG.Combat 
{
    public class Fighter : MonoBehaviour
{
    [SerializeField] float weaponRange = 2f; 
    Transform target; 

   private void Update()
    {

        if(target!=null && !(Vector3.Distance(transform.position, target.position) < weaponRange))
        {
        GetComponent<Mover>().MoveTo(target.position); 

        }
        else
        {
            GetComponent<Mover>().Stop();

        }
        
    }
    public void Attack(CombatTarget combatTarget) 
    {
        print("attack now"); 

      

        target = combatTarget.transform; 
    }
}


}
