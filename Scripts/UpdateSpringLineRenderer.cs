using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class UpdateSpringLineRenderer : MonoBehaviour
{
    public GameObject anchor;
    public GameObject anchorPoint;

    private Vector3 localScale;
    
    void Start()
    {
        localScale = transform.localScale;
    }
    
    void Update()
    {
        // transform.position = // position au milieu entre anchor et anchorPoint
        transform.position = anchor.transform.position + anchorPoint.transform.position / 2;

        Vector3 diff = anchor.transform.position - anchorPoint.transform.position;
        float distance = Vector3.Distance(anchor.transform.position, anchorPoint.transform.position);
        
        transform.localScale = new Vector3(localScale.x, distance, localScale.z);
        
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }
}
