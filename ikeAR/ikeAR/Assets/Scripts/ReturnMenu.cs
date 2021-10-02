using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMenu : MonoBehaviour
{
    [SerializeField] GameObject Colores;
    [SerializeField] GameObject Object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Return()
    {
      if (!Colores.activeInHierarchy)
        {
            Colores.SetActive(true);
            Object.SetActive(false);
        }
        

        
    }
}
