using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject playerTarget;
    [SerializeField] Vector3 distance;
    [SerializeField] float camSpeed=3;



    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, playerTarget.transform.position + distance, Time.deltaTime * camSpeed);
        
    }
}
