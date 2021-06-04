using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
     public GameObject DiamondText;
     MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
           mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
         Destroy(gameObject);
         Destroy(DiamondText);
    }
}
