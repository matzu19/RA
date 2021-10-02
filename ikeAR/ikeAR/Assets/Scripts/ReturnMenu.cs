using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMenu : MonoBehaviour
{
    [SerializeField] GameObject Colores;
    [SerializeField] GameObject Object;

    public void Return()
    {
      if (!Colores.activeInHierarchy)
        {
            Colores.SetActive(true);
            Object.SetActive(false);
        }
        

        
    }
}
