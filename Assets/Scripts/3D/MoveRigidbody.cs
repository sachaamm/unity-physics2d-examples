using UnityEngine;

public class MoveRigidbody : MonoBehaviour
{
    private Rigidbody rg;
    public float speed = 1;
    
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rg.MovePosition(transform.position + transform.forward * (speed * Time.deltaTime));
    }
}
