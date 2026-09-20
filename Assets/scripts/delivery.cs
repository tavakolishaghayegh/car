using UnityEngine;

public class delivery : MonoBehaviour
{
    bool hasPackage;
  



  void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if(collision.CompareTag("Package"))
        {
             Debug.Log("picked up Package");
             hasPackage= true;
        }

        if(collision.CompareTag("customer") && hasPackage)
        {
             Debug.Log("Deliverd package");
             hasPackage= false;
        }
       

    }

    
        
    



}
