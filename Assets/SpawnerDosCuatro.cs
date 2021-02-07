using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerDosCuatro : MonoBehaviour
{
    public float Randomizer;
    public GameObject Car4;
    public GameObject Car3;
    public Semaforo2y4 semaforo2y4;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarCarroDosCuatro", 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        print(Randomizer);
    }


    void GenerarCarroDosCuatro()
    {

        if (semaforo2y4.Semaforo_DosCuatro_Verde)
        {
            Instantiate(Car3, transform.position, Quaternion.identity);
            Instantiate(Car4, transform.position, Quaternion.identity);
        }



    }
}
