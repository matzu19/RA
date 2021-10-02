using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class InteractableObjectTallerClase : MonoBehaviour
{

    public static Action PointerEnter;
    public static Action PointerExit;
    public static Action MoveScene;

    public void OnPointerEnter()
    {
        PointerEnter?.Invoke();
    }

    public void OnPointerExit()
    {
        PointerExit?.Invoke();
    }

    public void OnPointerClick()
    {
        SceneManager.LoadScene("Video360");
    }
}
