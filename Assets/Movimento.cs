using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{

    public float velocidade = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moverPersonagem();
    }

    void moverPersonagem(){
        transform.Translate(new Vector3(0, 0, this.velocidade));
    }
}
