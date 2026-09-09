using UnityEngine;

public class driver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Rotate(0, 0, 45);
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 0.5f);
        transform.Translate(0 , .05f, 0);
    }
}
