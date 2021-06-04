using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash : MonoBehaviour
{
    public GameObject Hexgon;
    Transform hexgon_transform;
    // Start is called before the first frame update
    void Start()
    {
        hexgon_transform = Hexgon.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        hexgon_transform.Translate(0,0,1);
    }
}
