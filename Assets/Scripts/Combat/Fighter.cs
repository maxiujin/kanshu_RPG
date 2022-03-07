
using UnityEngine;
using RPG.Movement; 
using RPG.Core;



namespace RPG.Combat 
{
    public class Fighter : MonoBehaviour, IAction
{
    [SerializeField] float weaponRange = 2f; 
    [SerializeField] float timeBetweenAttacks =1f;
    
    [SerializeField] float weaponDamage = 5f;

    Transform target; 
    float timeSinceLastAttack = 0; //how long has passed since the last attack

   private void Update()
    {

        timeSinceLastAttack+=Time.deltaTime; 
        if(target==null)return;

        if(!GetIsInRange())
        {
        GetComponent<Mover>().MoveTo(target.position); 
        
        

        }
        else
            {
                GetComponent<Mover>().Cancel();
                AttackBehavior();

            }

        }

        private void AttackBehavior()
        {
            //this will trigger the hit() event
            if(timeSinceLastAttack>timeBetweenAttacks){
            GetComponent<Animator>().SetTrigger("attack");
            timeSinceLastAttack = 0;

            }
           
           
        }

        private bool GetIsInRange ()
    {
        return Vector3.Distance(transform.position, target.position) < weaponRange;
    }
    public void Attack(CombatTarget combatTarget) 
    {
        print("attack now"+timeSinceLastAttack); 
  
        

        GetComponent<ActionScheduler>().StartAction(this); 

        target = combatTarget.transform; 
       
       
     
       
       
    }

    public void Cancel()
    {
        
        target=null;


    }




//this is an Animation Event
    void Hit ()
    {
        
            Health healthComponent = target.GetComponent<Health>();
            healthComponent.TakeDamage(weaponDamage); 

    }
}


}
