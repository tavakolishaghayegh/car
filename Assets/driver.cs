using UnityEngine;
using UnityEngine.InputSystem;

public class driver : MonoBehaviour
{
    [SerializeField]float steerSpeed = 2f;
    [SerializeField]float moveSpeed = 0.1f;
   
    

   
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("We are pushing forward");
        }

        else if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("We are pushing backwards");
        }

        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("We are pushing left");
        }

        else if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("We are pushing right");
        }

        



        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0 , moveSpeed, 0);
    }
}
