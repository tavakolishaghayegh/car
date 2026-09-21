using UnityEngine;
using UnityEngine.InputSystem;

public class driver : MonoBehaviour
{ 
    [SerializeField]float CurrentSpeed = 6f;

    [SerializeField]float steerSpeed = 200f;
    [SerializeField] float boostSpeed =10f;
    [SerializeField] float regularSpeed=5f;

     void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("boost"))
        {CurrentSpeed= boostSpeed;
        Destroy(collision.gameObject);
        }
        
    }
     void OnCollisionEnter2D(Collision2D collision) {
        CurrentSpeed=regularSpeed;
        
    }

   
    void Update()
    {
        float move=0f;
        float steer=0f;
       


        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
            }

        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }

        else if (Keyboard.current.dKey.isPressed)
        {
            steer= -1f;
        }

        
        float moveAmount = move * CurrentSpeed * Time.deltaTime;
        float steerAmount=steer * steerSpeed * Time.deltaTime;
         
        transform.Translate(0 ,moveAmount, 0);
        transform.Rotate(0, 0, steerAmount);
        
    }
}
