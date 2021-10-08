using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMenu : MonoBehaviour
{
    [SerializeField] GameObject Colores;
    [SerializeField] GameObject Object;
    [SerializeField] GameObject ObjectChild;
    private Vector3 xl = new Vector3(10f, 10f, 10f), xd = new Vector3(0, 0, -15f), Ol, Od;

    public void Start()
    {
        Debug.Log("sdas");
        Ol = this.ObjectChild.transform.localScale;
        Od = this.ObjectChild.transform.rotation.eulerAngles;
    }
    public void Return()
    {
      if (!Colores.activeInHierarchy)
        {
            Colores.SetActive(true);
            Object.SetActive(false);
        }
        this.ObjectChild.transform.localScale = Ol;
        this.ObjectChild.transform.rotation = Quaternion.Euler(Od);
    }
    public void TurnRight()
    {
        this.ObjectChild.transform.Rotate(-xd, Space.Self);
    }
    public void TurnLeft()
    {
        this.ObjectChild.transform.Rotate(xd, Space.Self);
    }
    public void ZoomIn()
    {
        this.ObjectChild.transform.localScale += xl;
    }
    public void ZoomOut()
    {
        this.ObjectChild.transform.localScale -= xl;
    }
}
