using UnityEngine;

public class delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delay = 1f ;
  



  void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if(collision.CompareTag("Package") && !hasPackage )
        {
             Debug.Log("picked up Package");
             hasPackage= true;
             GetComponent<ParticleSystem>().Play();
             Destroy(collision.gameObject , delay);
        }

        if(collision.CompareTag("customer") && hasPackage)
        {
             Debug.Log("Deliverd package");
             hasPackage= false;
             GetComponent<ParticleSystem>().Stop();
        }
       

    }

    
        
    



}
