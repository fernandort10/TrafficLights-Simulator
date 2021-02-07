using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo1 : MonoBehaviour
{
    public GameObject semaforoUnoTres_verde;
    public GameObject semaforoUnoTres_amarillo;
    public GameObject semaforoUnoTres_rojo;
    public bool Semaforo_UnoTres_Verde;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrafficLights());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SemaforoUnoTresVerde()
    {
        semaforoUnoTres_verde.SetActive(true);
        semaforoUnoTres_rojo.SetActive(false);
        semaforoUnoTres_amarillo.SetActive(false);
        Semaforo_UnoTres_Verde = true;
    }
    void SemaforoUnoTresAmarillo()
    {
        semaforoUnoTres_verde.SetActive(false);
        semaforoUnoTres_rojo.SetActive(false);
        semaforoUnoTres_amarillo.SetActive(true);
        Semaforo_UnoTres_Verde = true;
    }
    void SemaforoUnoTresRojo()
    {
        semaforoUnoTres_verde.SetActive(false);
        semaforoUnoTres_rojo.SetActive(true);
        semaforoUnoTres_amarillo.SetActive(false);
        Semaforo_UnoTres_Verde = false;
    }

    IEnumerator TrafficLights() 
    {
        while (true)
        {
            SemaforoUnoTresVerde();
            yield return new WaitForSeconds(1);
            SemaforoUnoTresAmarillo();
            yield return new WaitForSeconds(1);
            SemaforoUnoTresRojo();
            yield return new WaitForSeconds(2);
        }
    }
}
