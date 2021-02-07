using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    public void lento()
    {
        Time.timeScale = 0.5f;
    }

    public void Rapido()
    {
        Time.timeScale = 4;
    }


    public void Normal()
    {
        Time.timeScale = 1;
    }
}
