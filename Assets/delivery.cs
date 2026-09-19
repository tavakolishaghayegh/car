using UnityEngine;

public class collision : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision )
    {
        Debug.Log("akh");
    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
        Debug.Log("what the heck was that?");
    }

    
        
    



}
