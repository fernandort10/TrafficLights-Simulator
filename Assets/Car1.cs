using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class Car1 : MonoBehaviour
{
    public GameObject EstadoSemaforo;
    public float Speed = 2f;
    public bool Control1;
    // Start is called before the first frame update
    void Start()
    {
        Control1 = false;
        transform.position = new Vector2(-12, -1.55f);
        transform.Rotate(0,0, -90, Space.Self);
        EstadoSemaforo = GameObject.Find("Semaforo1");
    }

    // Update is called once per frame
    void Update()
    {
        if (EstadoSemaforo.GetComponent<Semaforo1>().Semaforo_UnoTres_Verde || Control1)
        {
            transform.Translate(new Vector2(0, 2f) * Speed * Time.deltaTime);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
         if (collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }

         if(collision.tag == "Control1")
        {
            Control1 = true;
        }
    }

    
}

