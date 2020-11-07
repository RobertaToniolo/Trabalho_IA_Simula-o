using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour
{
    SpawnHunting toSpawn;
    SpawnHunting toSpawnH2;
    SpawnHunting toSpawnH3;
    SpawnHunting toSpawnH4;
    SpawnHunting toSpawnH5;

    //SpawnHunting numhunting;
    public int nH=5;
    public static bool H1attack;
    public static bool H2attack;
    public static bool H3attack;
    public static bool H4attack;
    public static bool H5attack;
    Rigidbody rb;

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "Hunting")
        {
            nH--;
            H1attack=true;

            Debug.Log("Caçador pegou a caça");
            Debug.Log(H1attack);
            
        }

        if (colisao.gameObject.tag == "Hunting2")
        {
            nH--;
            H2attack = true;

            Debug.Log("Caçador pegou a caça");
            Debug.Log(H2attack);

        }
        if (colisao.gameObject.tag == "Hunting3")
        {
            nH--;
            H3attack = true;

            Debug.Log("Caçador pegou a caça");
            Debug.Log(H3attack);

        }
        if (colisao.gameObject.tag == "Hunting4")
        {
            nH--;
            H4attack = true;

            Debug.Log("Caçador pegou a caça");
            Debug.Log(H4attack);

        }
        if (colisao.gameObject.tag == "Hunting5")
        {
            nH--;
            H5attack = true;

            Debug.Log("Caçador pegou a caça");
            Debug.Log(H5attack);

        }




    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
