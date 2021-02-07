using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerUnoTres : MonoBehaviour
{
    public float Randomizer;
    public GameObject[] Car1;
    public GameObject[] Car2;
    public Semaforo1 semaforo1;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("GenerarCarroUnoTres", 0, 1f);
       
    }

    // Update is called once per frame
    void Update()
    {
        print(Randomizer);
    }

    void GenerarCarroUnoTres()
    {
        
        if (semaforo1.Semaforo_UnoTres_Verde)
        {
            Instantiate(Car1[0], transform.position, Quaternion.identity);
            Instantiate(Car2[0], transform.position, Quaternion.identity);
        }
        
        

    }
}
