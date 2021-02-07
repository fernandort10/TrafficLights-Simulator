using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car3 : MonoBehaviour
{
    public GameObject EstadoSemaforo;
    public float Speed = 4f;
    public bool Control3;
    // Start is called before the first frame update
    void Start()
    {
        Control3 = false;
        transform.position = new Vector2(1.26f, -7.5f);
        transform.Rotate(0, 0, 0, Space.Self);
        EstadoSemaforo = GameObject.Find("Semaforo3");
    }

    // Update is called once per frame
    void Update()
    {
        if (EstadoSemaforo.GetComponent<Semaforo2y4>().Semaforo_DosCuatro_Verde || Control3)
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

        if (collision.tag == "Control3")
        {
            Control3 = true;
        }
    }
}
