using UnityEngine;

public class delivery : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision) 
    {
        // if (the tag is Package)
        // then (print picked up Package to console)
        if(collision.CompareTag("Package"))
        {
             Debug.Log("picked up Package");
        }

        if(collision.CompareTag("customer"))
        {
             Debug.Log("Deliverd package");
        }
       

    }

    
        
    



}
