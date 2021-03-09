using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;

public class Pendule : MonoBehaviour
{
    private Rigidbody2D rg;

    public Transform startPoint;
    public GameObject pendule;

    public Vector2 direction = new Vector2(1, 0);

    public float magnitude = 1.0f;

    public int periode = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        rg = pendule.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        int ratio = 1;

        if (Time.time % periode <= periode / 2)
        {
            ratio = -1;
        }
        
        // rg.AddTorque(magnitude);
        rg.AddForce(direction * (Mathf.Sin(Time.time) * magnitude * ratio));
    }
}
