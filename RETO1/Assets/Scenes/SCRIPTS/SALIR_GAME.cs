using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SALIR_GAME : MonoBehaviour
{
    public void ExitGame()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }
    //Fin de la funci�n cerrar el juego en Unity
}
