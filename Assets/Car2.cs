using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : MonoBehaviour
{
    public GameObject EstadoSemaforo;
    public float Speed = 2f;
    public bool Control2;
    // Start is called before the first frame update
    void Start()
    {
        Control2 = false;
        transform.position = new Vector2(11.53f, 0.4f);
        transform.Rotate(0, 0, 90, Space.Self);
        EstadoSemaforo = GameObject.Find("Semaforo2");
    }

    // Update is called once per frame
    void Update()
    {
        if (EstadoSemaforo.GetComponent<Semaforo1>().Semaforo_UnoTres_Verde || Control2)
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

        if (collision.tag == "Control2")
        {
            Control2 = true;
        }
    }
}
