using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo2y4 : MonoBehaviour
{
    public GameObject semaforoDosCuatro_verde;
    public GameObject semaforoDosCuatro_amarillo;
    public GameObject semaforoDosCuatro_rojo;
    public bool Semaforo_DosCuatro_Verde;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrafficLights());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SemaforoDosCuatroRojo()
    {
        semaforoDosCuatro_verde.SetActive(false);
        semaforoDosCuatro_rojo.SetActive(true);
        semaforoDosCuatro_amarillo.SetActive(false);
        Semaforo_DosCuatro_Verde = false;
    }

    void SemaforoDosCuatroVerde()
    {
        semaforoDosCuatro_verde.SetActive(true);
        semaforoDosCuatro_rojo.SetActive(false);
        semaforoDosCuatro_amarillo.SetActive(false);
        Semaforo_DosCuatro_Verde = true;
    }

    void SemaforoDosCuatroAmarillo()
    {
        semaforoDosCuatro_verde.SetActive(false);
        semaforoDosCuatro_rojo.SetActive(false);
        semaforoDosCuatro_amarillo.SetActive(true);
        Semaforo_DosCuatro_Verde = true;
    }

    IEnumerator TrafficLights()
    {
        while (true)
        {
            SemaforoDosCuatroRojo();
            yield return new WaitForSeconds(2);
            SemaforoDosCuatroVerde();
            yield return new WaitForSeconds(1);
            SemaforoDosCuatroAmarillo();
            yield return new WaitForSeconds(1);
            

        }
    }
}
