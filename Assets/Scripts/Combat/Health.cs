using UnityEngine;


namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float health = 100f;
        bool hasFainted = false;

        public void TakeDamage(float damage)
        {

            health = Mathf.Max(health - damage, 0);
            print(health);
            if (health == 0)
            {
                StopFaint();

            }

        }

        private void StopFaint()
        {
            if (hasFainted) return;

            hasFainted = true;
            GetComponent<Animator>().SetTrigger("Faint");

        }
    }

}