using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class human : MonoBehaviour
{
    public GameObject HumanText;
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
        Destroy(HumanText);
    }
}
