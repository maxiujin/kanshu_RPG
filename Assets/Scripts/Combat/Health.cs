using UnityEngine;


namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
      [SerializeField] float health = 100f;
      bool hasFainted;
      
      public void TakeDamage(float damage)
      {

        health = Mathf.Max(health-damage,0); 
        print(health); 
        if(health==0 && hasFainted)
        {
         
          
           GetComponent<Animator>().SetTrigger("Faint");
           hasFainted= false; 
   SpriteSortPoint 
        }
        
      }
    }

}