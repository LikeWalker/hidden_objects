using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    Transform door_transform;
    // Start is called before the first frame update
    void Start()
    {
        door_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        door_transform.Translate(-3f,0,0);
    }
}
