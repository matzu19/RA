using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelection : MonoBehaviour
{
    [SerializeField] GameObject Object1;
    [SerializeField] GameObject Object2;
    
    // Start is called before the first frame update
    void Start()
    {
        Object1.SetActive(true);
        Object2.SetActive(false);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextObject()
    {
        Object1.SetActive(false);
        Object2.SetActive(true);
        
    }
}
