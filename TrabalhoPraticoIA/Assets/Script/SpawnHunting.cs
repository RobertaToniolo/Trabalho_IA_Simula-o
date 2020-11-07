using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpawnHunting : MonoBehaviour
{
    public Text turnotexto;
    //public Text NumHuntingTexto;

    public int turno;
    

    public int numhunting;

    public List<GameObject> sP;
    public List<GameObject> spHunting2;
    public List<GameObject> spHunting3;
    public List<GameObject> spHunting4;
    public List<GameObject> spHunting5;
    public GameObject Cenario;
    public List<GameObject> sPH;

    public Vector2 posAtual1;
    public Vector2 posAtual2;
    public Vector2 posAtual3;
    public Vector2 posAtual4;
    public Vector2 posAtual5;
    public Vector2 posAtualHunter;

    public GameObject toSpawn;
    public GameObject toSpawnH2;
    public GameObject toSpawnH3;
    public GameObject toSpawnH4;
    public GameObject toSpawnH5;

    GameObject toSpawnHunter;

    public GameObject Celula1;

    void Start()
    {
        turno = 0;
        numhunting = 5;
        Spawn();
     
        

    }

    void Update()
    {
        turnotexto.text = "Turno = " + turno;
        //NumHuntingTexto.text = "Caças = " + numhunting;

        if (Input.GetMouseButtonDown(0))
            Debug.Log("Botão principal pressionado.");
    
    }

    public void Spawn()
    {
        
        
        Destruir();
        int randItem = 0;
        int randItem2 = 0;
        int randItem3 = 0;
        int randItem4 = 0;
        int randItem5 = 0;
        int rH=0;
        
      
        
        MeshCollider c = Cenario.GetComponent<MeshCollider>();

        float screenX;
        float screenY;

        Vector2 pos;
        Vector2 pos2;
        Vector2 pos3;
        Vector2 pos4;
        Vector2 pos5;

        Vector2 posHunter;

        bool celula1=false, celula2 = false, celula3 = false, celula4 = false, celula5 = false, celula6 = false, celula7 = false, celula8 = false, celula9 = false, celula10 = false, celula11 = false, celula12 = false, celula13 = false, celula14 = false, celula15 = false, celula16 = false, celula17 = false, celula18 = false, celula19 = false, celula20 = false;
        bool celula21 = false, celula22 = false, celula23 = false, celula24 = false, celula25 = false, celula26 = false, celula27 = false, celula28 = false, celula29 = false, celula30 = false, celula31 = false, celula32 = false, celula33 = false, celula34 = false, celula35 = false, celula36 = false, celula37 = false, celula38 = false, celula39 = false, celula40 = false;
        bool celula41 = false, celula42 = false, celula43 = false, celula44 = false, celula45 = false, celula46 = false, celula47 = false, celula48 = false, celula49 = false, celula50 = false, celula51 = false, celula52 = false, celula53 = false, celula54 = false, celula55 = false, celula56 = false, celula57 = false, celula58 = false, celula59 = false, celula60 = false;
        bool celula61 = false, celula62 = false, celula63 = false, celula64 = false, celula65 = false, celula66 = false, celula67 = false, celula68 = false, celula69 = false, celula70 = false, celula71 = false, celula72 = false, celula73 = false, celula74 = false, celula75 = false, celula76 = false, celula77 = false, celula78 = false, celula79 = false, celula80 = false;
        bool celula81 = false, celula82 = false, celula83 = false, celula84 = false, celula85 = false, celula86 = false, celula87 = false, celula88 = false, celula89 = false, celula90 = false, celula91 = false, celula92 = false, celula93 = false, celula94 = false, celula95 = false, celula96 = false, celula97 = false, celula98 = false, celula99 = false, celula100 = false;


        toSpawn = sP[randItem];
        toSpawnHunter = sPH[rH];
        toSpawnH2 = spHunting2[randItem2];
        toSpawnH3 = spHunting3[randItem3];
        toSpawnH4 = spHunting4[randItem4];
        toSpawnH5 = spHunting5[randItem5];
        int sorteioPos, sorteioPosH2, sorteioPosH3,sorteioPosH4,sorteioPosH5,sorteioPosHunter;

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            
            sorteioPos = Random.Range(1, 101);
        //Sorteio de posição da primeira Caça
        if (sorteioPos == 1)
        {

            pos = new Vector2(-14, 14);
            celula1 = true;

        }
        else if (sorteioPos == 2)
        {
            pos = new Vector2(-11, 14);
            celula2 = true;
        }
        else if (sorteioPos == 3)
        {
            pos = new Vector2(-8, 14);
            celula3 = true;
        }
        else if (sorteioPos == 4)
        {
            pos = new Vector2(-5, 14);
            celula4 = true;
        }
        else if (sorteioPos == 5)
        {
            pos = new Vector2(-2, 14);
            celula5 = true;
        }
        else if (sorteioPos == 6)
        {
            pos = new Vector2(1, 14);
            celula6 = true;
        }
        else if (sorteioPos == 7)
        {
            pos = new Vector2(4, 14);
            celula7 = true;
        }
        else if (sorteioPos == 8)
        {
            pos = new Vector2(7, 14);
            celula8 = true;
        }
        else if (sorteioPos == 9)
        {
            pos = new Vector2(10, 14);
            celula9 = true;
        }
        else if (sorteioPos == 10)
        {
            pos = new Vector2(13, 14);
            celula10 = true;
        }
        else if (sorteioPos == 11)
        {
            pos = new Vector2(-14, 11);
            celula11 = true;
        }
        else if (sorteioPos == 12)
        {
            pos = new Vector2(-11, 11);
            celula12 = true;
        }
        else if (sorteioPos == 13)
        {
            pos = new Vector2(-8, 11);
            celula13 = true;
        }
        else if (sorteioPos == 14)
        {
            pos = new Vector2(-5, 11);
            celula14 = true;
        }
        else if (sorteioPos == 15)
        {
            pos = new Vector2(-2, 11);
            celula15 = true;
        }
        else if (sorteioPos == 16)
        {
            pos = new Vector2(1, 11);
            celula16 = true;
        }
        else if (sorteioPos == 17)
        {
            pos = new Vector2(4, 11);
            celula17 = true;
        }
        else if (sorteioPos == 18)
        {
            pos = new Vector2(7, 11);
            celula18 = true;
        }
        else if (sorteioPos == 19)
        {
            pos = new Vector2(10, 11);
            celula19 = true;
        }
        else if (sorteioPos == 20)
        {
            pos = new Vector2(13, 11);
            celula20 = true;
        }
        else if (sorteioPos == 21)
        {
            pos = new Vector2(-14, 8);
            celula21 = true;
        }
        else if (sorteioPos == 22)
        {
            pos = new Vector2(-11, 8);
            celula22 = true;
        }
        else if (sorteioPos == 23)
        {
            pos = new Vector2(-8, 8);
            celula23 = true;
        }
        else if (sorteioPos == 24)
        {
            pos = new Vector2(-5, 8);
            celula24 = true;
        }
        else if (sorteioPos == 25)
        {
            pos = new Vector2(-2, 8);
            celula25 = true;
        }
        else if (sorteioPos == 26)
        {
            pos = new Vector2(1, 8);
            celula26 = true;
        }
        else if (sorteioPos == 27)
        {
            pos = new Vector2(4, 8);
            celula27 = true;
        }
        else if (sorteioPos == 28)
        {
            pos = new Vector2(7, 8);
            celula28 = true;
        }
        else if (sorteioPos == 29)
        {
            pos = new Vector2(10, 8);
            celula29 = true;
        }
        else if (sorteioPos == 30)
        {
            pos = new Vector2(13, 8);
            celula30 = true;
        }
        else if (sorteioPos == 31)
        {
            pos = new Vector2(-14, 5);
            celula31 = true;
        }
        else if (sorteioPos == 32)
        {
            pos = new Vector2(-11, 5);
            celula32 = true;
        }
        else if (sorteioPos == 33)
        {
            pos = new Vector2(-8, 5);
            celula33 = true;
        }
        else if (sorteioPos == 34)
        {
            pos = new Vector2(-5, 5);
            celula34 = true;
        }
        else if (sorteioPos == 35)
        {
            pos = new Vector2(-2, 5);
            celula35 = true;
        }
        else if (sorteioPos == 36)
        {
            pos = new Vector2(1, 5);
            celula36 = true;
        }
        else if (sorteioPos == 37)
        {
            pos = new Vector2(4, 5);
            celula37 = true;
        }
        else if (sorteioPos == 38)
        {
            pos = new Vector2(7, 5);
            celula38 = true;
        }
        else if (sorteioPos == 39)
        {
            pos = new Vector2(10, 5);
            celula39 = true;
        }
        else if (sorteioPos == 40)
        {
            pos = new Vector2(13, 5);
            celula40 = true;
        }
        else if (sorteioPos == 41)
        {
            pos = new Vector2(-14, 2);
            celula41 = true;
        }
        else if (sorteioPos == 42)
        {
            pos = new Vector2(-11, 2);
            celula42 = true;
        }
        else if (sorteioPos == 43)
        {
            pos = new Vector2(-8, 2);
            celula43 = true;
        }
        else if (sorteioPos == 44)
        {
            pos = new Vector2(-5, 2);
            celula44 = true;
        }
        else if (sorteioPos == 45)
        {
            pos = new Vector2(-2, 2);
            celula45 = true;
        }
        else if (sorteioPos == 46)
        {
            pos = new Vector2(1, 2);
            celula46 = true;
        }
        else if (sorteioPos == 47)
        {
            pos = new Vector2(4, 2);
            celula47 = true;
        }
        else if (sorteioPos == 48)
        {
            pos = new Vector2(7, 2);
            celula48 = true;
        }
        else if (sorteioPos == 49)
        {
            pos = new Vector2(10, 2);
            celula49 = true;
        }
        else if (sorteioPos == 50)
        {
            pos = new Vector2(13, 2);
            celula50=true;
        }
        else if (sorteioPos == 51)
        {
            pos = new Vector2(-14, -1);
            celula51 = true;
        }
        else if (sorteioPos == 52)
        {
            pos = new Vector2(-11, -1);
            celula52 = true;
        }
        else if (sorteioPos == 53)
        {
            pos = new Vector2(-8, -1);
            celula53 = true;
        }
        else if (sorteioPos == 54)
        {
            pos = new Vector2(-5, -1);
            celula54 = true;
        }
        else if (sorteioPos == 55)
        {
            pos = new Vector2(-2, -1);
            celula55 = true;
        }
        else if (sorteioPos == 56)
        {
            pos = new Vector2(1, -1);
            celula56 = true;
        }
        else if (sorteioPos == 57)
        {
            pos = new Vector2(4, -1);
            celula57 = true;
        }
        else if (sorteioPos == 58)
        {
            pos = new Vector2(7, -1);
            celula58 = true;
        }
        else if (sorteioPos == 59)
        {
            pos = new Vector2(10, -1);
            celula59 = true;
        }
        else if (sorteioPos == 60)
        {
            pos = new Vector2(-14, -1);
            celula60 = true;
        }
        else if (sorteioPos == 61)
        {
            pos = new Vector2(-14, -4);
            celula61 = true;
        }
        else if (sorteioPos == 62)
        {
            pos = new Vector2(-11, -4);
            celula62 = true;
        }
        else if (sorteioPos == 63)
        {
            pos = new Vector2(-8, -4);
            celula63 = true;
        }
        else if (sorteioPos == 64)
        {
            pos = new Vector2(-5, -4);
            celula64 = true;
        }
        else if (sorteioPos == 65)
        {
            pos = new Vector2(-2, -4);
            celula65 = true;
        }
        else if (sorteioPos == 66)
        {
            pos = new Vector2(1, -4);
            celula66 = true;
        }
        else if (sorteioPos == 67)
        {
            pos = new Vector2(4, -4);
            celula67 = true;
        }
        else if (sorteioPos == 68)
        {
            pos = new Vector2(7, -4);
            celula68 = true;
        }
        else if (sorteioPos == 69)
        {
            pos = new Vector2(10, -4);
            celula69 = true;
        }
        else if (sorteioPos == 70)
        {
            pos = new Vector2(13, -4);
            celula70 = true;
        }
        else if (sorteioPos == 71)
        {
            pos = new Vector2(-14, -7);
            celula71 = true;
        }
        else if (sorteioPos == 72)
        {
            pos = new Vector2(-11, -7);
            celula72 = true;
        }
        else if (sorteioPos == 73)
        {
            pos = new Vector2(-8, -7);
            celula73 = true;
        }
        else if (sorteioPos == 74)
        {
            pos = new Vector2(-5, -7);
            celula74 = true;
        }
        else if (sorteioPos == 75)
        {
            pos = new Vector2(-2, -7);
            celula75 = true;
        }
        else if (sorteioPos == 76)
        {
            pos = new Vector2(1, -7);
            celula76 = true;
        }
        else if (sorteioPos == 77)
        {
            pos = new Vector2(4, -7);
            celula77 = true;
        }
        else if (sorteioPos == 78)
        {
            pos = new Vector2(7, -7);
            celula78 = true;
        }
        else if (sorteioPos == 79)
        {
            pos = new Vector2(10, -7);
            celula79 = true;
        }
        else if (sorteioPos == 80)
        {
            pos = new Vector2(13, -7);
            celula80 = true;
        }
        else if (sorteioPos == 81)
        {
            pos = new Vector2(-14, -10);
            celula81 = true;
        }
        else if (sorteioPos == 82)
        {
            pos = new Vector2(-11, -10);
            celula82 = true;
        }
        else if (sorteioPos == 83)
        {
            pos = new Vector2(-8, -10);
            celula83 = true;
        }
        else if (sorteioPos == 84)
        {
            pos = new Vector2(-5, -10);
            celula84 = true;
        }
        else if (sorteioPos == 85)
        {
            pos = new Vector2(-2, -10);
            celula85 = true;
        }
        else if (sorteioPos == 86)
        {
            pos = new Vector2(1, -10);
            celula86 = true;
        }
        else if (sorteioPos == 87)
        {
            pos = new Vector2(4, -10);
            celula87 = true;
        }
        else if (sorteioPos == 88)
        {
            pos = new Vector2(7, -10);
            celula88 = true;
        }
        else if (sorteioPos == 89)
        {
            pos = new Vector2(10, -10);
            celula89 = true;
        }
        else if (sorteioPos == 90)
        {
            pos = new Vector2(13, -13);
            celula90 = true;
        }
        else if (sorteioPos == 91)
        {
            pos = new Vector2(-14, -13);
            celula91 = true;
        }
        else if (sorteioPos == 92)
        {
            pos = new Vector2(-11, -13);
            celula92 = true;
        }
        else if (sorteioPos == 93)
        {
            pos = new Vector2(-8, -13);
            celula93 = true;
        }
        else if (sorteioPos == 94)
        {
            pos = new Vector2(-5, -13);
            celula94 = true;
        }
        else if (sorteioPos == 95)
        {
            pos = new Vector2(-2, -13);
            celula95 = true;
        }
        else if (sorteioPos == 96)
        {
            pos = new Vector2(1, -13);
            celula96 = true;
        }
        else if (sorteioPos == 97)
        {
            pos = new Vector2(4, -13);
            celula97=true;
        }
        else if (sorteioPos == 98)
        {
            pos = new Vector2(7, -13);
            celula98 = true;
        }
        else if (sorteioPos == 99)
        {
            pos = new Vector2(10, -13);
            celula99 = true;
        }
        else if (sorteioPos == 100)
        {
            pos = new Vector2(13, -13);
            celula100 = true;
        }
        else
        {
            pos = new Vector2(13, -13);

        }

        //Sorteio da posição da segunda Caça
        sorteioPosH2 = Random.Range(1, 101);
        if (sorteioPosH2 == 1)
        {
            if(celula1==true)
            {
                pos2 = new Vector2(-11, 14);
                celula2 = true;
            }
            
            else
            {
                pos2 = new Vector2(-14, 14);
                celula1 = true;
            }
          

        }
        else if (sorteioPosH2 == 2)
        {
            if (celula2 == true)
            {
                 pos2 = new Vector2(-11, 14);
                 celula3 = true;
            }
          
            else
            {
                pos2 = new Vector2(-8, 14);
                celula2 = true;
            }
           
        }
        else if (sorteioPosH2 == 3)
        {
            if (celula3 == true)
            {
                pos2 = new Vector2(-5, 14);
                celula4 = true;
            }
           
            else {
                pos2 = new Vector2(-8, 14);
                celula3 = true;
            }
           
        }
        else if (sorteioPosH2 == 4)
        {
            if(celula4==true)
            {
                pos2 = new Vector2(-2, 14);
                celula5 = true;
            }
           
            else { 
            pos2 = new Vector2(-5, 14);
            celula4 = true;}
        }
        else if (sorteioPosH2 == 5)
        {
            if (celula5 == true)
            {
                pos2 = new Vector2(1, 14);
                celula6 = true;
            }
           
            else
            {
                pos2 = new Vector2(-2, 14);
                celula5 = true;
            }
        }
        else if (sorteioPosH2 == 6)
        {
            if (celula6 == true)
            {
                pos2 = new Vector2(4, 14);
                celula7 = true;
            }
            
            else {
                pos2 = new Vector2(1, 14);
                celula6 = true;
            }
        }
        else if (sorteioPosH2 == 7)
        {
            if(celula7==true)
            {
                pos2 = new Vector2(7, 14);
                celula8 = true;
            }
            
            else {
                pos2 = new Vector2(4, 14);
                celula7 = true;
            }
        }
        else if (sorteioPosH2 == 8)
        {
            if (celula8 == true)
            {
                pos2 = new Vector2(10, 14);
                celula9 = true;
            }
            
            else {
                pos2 = new Vector2(7, 14);
                celula8 = true;
            }
        }
        else if (sorteioPosH2 == 9)
        {
            if(celula9==true)
            {
                pos2 = new Vector2(13, 14);
                celula10 = true;
            }
            
            else
            {
                pos2 = new Vector2(10, 14);
                celula9 = true;
            }
        }
        else if (sorteioPosH2 == 10)
        {
            if(celula10==true)
            {
                pos2 = new Vector2(-14, 11);
                celula11 = true;
            }
           
            else {
                pos2 = new Vector2(13, 14);
                celula10 = true;
            }
        }
        else if (sorteioPosH2 == 11)
        {
            if(celula11==true)
            {
                pos2 = new Vector2(-11, 11);
                celula12 = true;
            }
            else
            {
                pos2 = new Vector2(-14, 11);
                celula11 = true;
            }
        }
        else if (sorteioPosH2 == 12)
        {
            if(celula12==true)
            {
                pos2 = new Vector2(-8, 11);
                celula13 = true;
            }
            else {
                pos2 = new Vector2(-11, 11);
                celula12 = true;
            }
        }
        else if (sorteioPosH2 == 13)
        {
            if(celula13==true)
            {
                pos2 = new Vector2(-5, 11);
                celula14 = true;
            }
            else { 
            pos2 = new Vector2(-8, 11);
            celula13 = true;}
        }
        else if (sorteioPosH2 == 14)
        {
            if(celula14==true)
            {
                pos2 = new Vector2(-2, 11);
                celula15 = true;
            }
            else
            {

            pos2 = new Vector2(-5, 11);
            celula14 = true;}
        }
        else if (sorteioPosH2 == 15)
        {
            if(celula15==true){
                pos2 = new Vector2(1, 11);
                celula16 = true;
            }
            else { 
            pos2 = new Vector2(-2, 11);
            celula15 = true;}
        }
        else if (sorteioPosH2 == 16)
        {
            if (celula16 == true)
            {
                pos2 = new Vector2(4, 11);
                celula17 = true;
            }
            else { 
            pos2 = new Vector2(1, 11);
            celula16 = true;}
        }
        else if (sorteioPosH2 == 17)
        {
            if (celula17 == true)
            {
                pos2 = new Vector2(7, 11);
                celula18 = true;
            }
            else
            {
            pos2 = new Vector2(4, 11);
            celula17 = true;}
        }
        else if (sorteioPosH2 == 18)
        {
            if(celula18==true)
            {
                pos2 = new Vector2(10, 11);
                celula19 = true;
            }
            else { 
            pos2 = new Vector2(7, 11);
            celula18 = true;}
        }
        else if (sorteioPosH2 == 19)
        {
            if (celula19 == true)
            {
                pos2 = new Vector2(13, 11);
                celula20 = true;
            }
            else { 
            pos2 = new Vector2(10, 11);
            celula19 = true;}
        }
        else if (sorteioPosH2 == 20)
        {
            if(celula20==true)
            {
                pos2 = new Vector2(-14, 8);
                celula21 = true;
            }
            else { 
            pos2 = new Vector2(13, 11);
            celula20 = true;}
        }
        else if (sorteioPosH2 == 21)
        {
            if(celula21==true)
            {
                pos2 = new Vector2(-11, 8);
                celula22 = true;
            }
            else
            {
            pos2 = new Vector2(-14, 8);
            celula21 = true; }
        }
        else if (sorteioPosH2 == 22)
        {
            if(celula22==true)
            {
                pos2 = new Vector2(-8, 8);
                celula23 = true;
            }
            else { 
            pos2 = new Vector2(-11, 8);
            celula22 = true;}
        }
        else if (sorteioPosH2 == 23)
        {
            if(celula23==true)
            {
                pos2 = new Vector2(-5, 8);
                celula24 = true;
            }
            else { 
            pos2 = new Vector2(-8, 8);
            celula23 = true;}
        }
        else if (sorteioPosH2 == 24)
        {
            if (celula24 == true)
            {
                pos2 = new Vector2(-2, 8);
                celula25 = true;
            }
            else {
            pos2 = new Vector2(-5, 8);
            celula24 = true; }
        }
        else if (sorteioPosH2 == 25)
        {
            if(celula25==true)
            {
                pos2 = new Vector2(1, 8);
                celula26 = true;
            }
            else { 
            pos2 = new Vector2(-2, 8);
            celula25 = true;}
        }
        else if (sorteioPosH2 == 26)
        {
            if (celula26 == true) {
                pos2 = new Vector2(4, 8);
                celula27 = true;
            }
            else { 
            pos2 = new Vector2(1, 8);
            celula26 = true;}
        }
        else if (sorteioPosH2 == 27)
        {
            if (celula27 == true) {
                pos2 = new Vector2(7, 8);
                celula28 = true;
            }
            else { 
            pos2 = new Vector2(4, 8);
            celula27 = true;}
        }
        else if (sorteioPosH2 == 28)
        {
            if (celula28 == true) {
                pos2 = new Vector2(10, 8);
                celula29 = true;
            }
            else
            {

            pos2 = new Vector2(7, 8);
            celula28 = true;}
        }
        else if (sorteioPosH2 == 29)
        {
            if (celula29 == true)
            {
                pos2 = new Vector2(13, 8);
                celula30 = true;
            }
            else { 
            pos2 = new Vector2(10, 8);
            celula29 = true;}
        }
        else if (sorteioPosH2 == 30)
        {
            if (celula30 == true)
            {
                pos2 = new Vector2(-14, 5);
                celula31 = true;
            }
            else { 
            pos2 = new Vector2(13, 8);
            celula30 = true;}
        }
        else if (sorteioPosH2 == 31)
        {
            if(celula31==true)
            {
                pos2 = new Vector2(-11, 5);
                celula32 = true;
            }
            else { 
            pos2 = new Vector2(-14, 5);
            celula31 = true;}
        }
        else if (sorteioPosH2 == 32)
        {
            if(celula32==true)
            {
                pos2 = new Vector2(-8, 5);
                celula33 = true;
            }
            else { 
            pos2 = new Vector2(-11, 5);
            celula32 = true;}
        }
        else if (sorteioPosH2 == 33)
        {
            if(celula33==true)
            {
                pos2 = new Vector2(-5, 5);
                celula34 = true;
            }
            else { 
            pos2 = new Vector2(-8, 5);
            celula33 = true;}
        }
        else if (sorteioPosH2 == 34)
        {
            if (celula34 == true)
            {
                pos2 = new Vector2(-2, 5);
                celula35 = true;
            }
            else { 
            pos2 = new Vector2(-5, 5);
            celula34 = true;}
        }
        else if (sorteioPosH2 == 35)
        {
            if (celula35 == true) {
                pos2 = new Vector2(1, 5);
                celula36 = true;
            }
            else { 
            pos2 = new Vector2(-2, 5);
            celula35 = true;}
        }
        else if (sorteioPosH2 == 36)
        {
            if (celula36 == true)
            {
                pos2 = new Vector2(4, 5);
                celula37 = true;
            }
            else { 
            pos2 = new Vector2(1, 5);
            celula36 = true;}
        }
        else if (sorteioPosH2 == 37)
        {
            if(celula37==true)
            {
                pos2 = new Vector2(7, 5);
                celula38 = true;
            }
            else { 
            pos2 = new Vector2(4, 5);
            celula37 = true;}
        }
        else if (sorteioPosH2 == 38)
        {
            if(celula38==true)
            {
                pos2 = new Vector2(10, 5);
                celula39 = true;
            }
            else { 
            pos2 = new Vector2(7, 5);
            celula38 = true;}
        }
        else if (sorteioPosH2 == 39)
        {
            if(celula39==true)
            {
                pos2 = new Vector2(13, 5);
                celula40 = true;
            }
            else { 
            pos2 = new Vector2(10, 5);
            celula39 = true;}
        }
        else if (sorteioPosH2 == 40)
        {
            if (celula40 == true)
            {
                pos2 = new Vector2(-14, 2);
                celula41 = true;
            }
            else { 
            pos2 = new Vector2(13, 5);
            celula40 = true;}
        }
        else if (sorteioPosH2 == 41)
        {
            if(celula41==true)
            {
                pos2 = new Vector2(-11, 2);
                celula42 = true;
            }
            else { 
            pos2 = new Vector2(-14, 2);
            celula41 = true;}
        }
        else if (sorteioPosH2 == 42)
        {
            if (celula42 == true)
            {
                pos2 = new Vector2(-8, 2);
                celula43 = true;
            }
            else { 
            pos2 = new Vector2(-11, 2);
            celula42 = true;}
        }
        else if (sorteioPosH2 == 43)
        {
            if(celula43==true)
            {
                pos2 = new Vector2(-5, 2);
                celula44 = true;
            }
            else { 
            pos2 = new Vector2(-8, 2);
            celula43 = true;}
        }
        else if (sorteioPosH2 == 44)
        {
            if (celula44 == true)
            {
                pos2 = new Vector2(-2, 2);
                celula45 = true;
            }
            else { 
            pos2 = new Vector2(-5, 2);
            celula44 = true;}
        }
        else if (sorteioPosH2 == 45)
        {
            if (celula45 == true) {
                pos2 = new Vector2(1, 2);
                celula46 = true;
            }
            else { 
            pos2 = new Vector2(-2, 2);
            celula45 = true;}
        }
        else if (sorteioPosH2 == 46)
        {
            if(celula46==true)
            {
                pos2 = new Vector2(4, 2);
                celula47 = true;
            }
            else { 
            pos2 = new Vector2(1, 2);
            celula46 = true;}
        }
        else if (sorteioPosH2 == 47)
        {
            if (celula47 == true) {
                pos2 = new Vector2(7, 2);
                celula48 = true;
            }
            else { 
            pos2 = new Vector2(4, 2);
            celula47 = true;}
        }
        else if (sorteioPosH2 == 48)
        {
            if (celula48 == true)
            {
                pos2 = new Vector2(10, 2);
                celula49 = true;
            }
            else { 
            pos2 = new Vector2(7, 2);
            celula48 = true;}
        }
        else if (sorteioPosH2 == 49)
        {
            if(celula49==true)
            {
                pos2 = new Vector2(13, 2);
                celula50 = true;
            }
            else { 
            pos2 = new Vector2(10, 2);
            celula49 = true;}
        }
        else if (sorteioPosH2 == 50)
        {
            if (celula50 == true)
            {
                pos2 = new Vector2(-14, -1);
                celula51 = true;
            }
            else { 
            pos2 = new Vector2(13, 2);
            celula50 = true;}
        }
        else if (sorteioPosH2 == 51)
        {
            if(celula51==true)
            {
                pos2 = new Vector2(-11, -1);
                celula52 = true;
            }
            else { 
            pos2 = new Vector2(-14, -1);
            celula51 = true;}
        }
        else if (sorteioPosH2 == 52)
        {
            if(celula52==true)
            {
                pos2 = new Vector2(-8, -1);
                celula53 = true;
            }
            else { 
            pos2 = new Vector2(-11, -1);
            celula52 = true;}
        }
        else if (sorteioPosH2 == 53)
        {
            if (celula53 == true)
            {
                pos2 = new Vector2(-5, -1);
                celula54 = true;
            }
            else { 
            pos2 = new Vector2(-8, -1);
            celula53 = true;}
        }
        else if (sorteioPosH2 == 54)
        {
            if (celula54 == true)
            {
                pos2 = new Vector2(-2, -1);
                celula55 = true;
            }
            else { 
            pos2 = new Vector2(-5, -1);
            celula54 = true;}
        }
        else if (sorteioPosH2 == 55)
        {
            if (celula55 == true)
            {
                pos2 = new Vector2(1, -1);
                celula56 = true;
            }
            else { 
            pos2 = new Vector2(-2, -1);
            celula55 = true;}
        }
        else if (sorteioPosH2 == 56)
        {
            if(celula56==true)
            {
                pos2 = new Vector2(4, -1);
                celula57 = true;
            }
            else { 
            pos2 = new Vector2(1, -1);
            celula56 = true;}
        }
        else if (sorteioPosH2 == 57)
        {
            if (celula57==true)
            {
                pos2 = new Vector2(7, -1);
                celula58 = true;
            }
            else { 
            pos2 = new Vector2(4, -1);
            celula57 = true;}
        }
        else if (sorteioPosH2 == 58)
        {
            if(celula58==true)
            {
                pos2 = new Vector2(10, -1);
                celula59 = true;
            }
            else { 
            pos2 = new Vector2(7, -1);
            celula58 = true;}
        }
        else if (sorteioPosH2 == 59)
        {
            if(celula59==true)
            {
                pos2 = new Vector2(-13, -1);
                celula60 = true;
            }
            else { 
            pos2 = new Vector2(10, -1);
            celula59 = true;}
        }
        else if (sorteioPosH2 == 60)
        {
            if(celula60==true)
            {
                pos2 = new Vector2(-14, -4);
                celula61 = true;
            }
            else { 
            pos2 = new Vector2(-14, -1);
            celula60 = true;}
        }
        else if (sorteioPosH2 == 61)
        {
            if (celula61 == true)
            {
                pos2 = new Vector2(-11, -4);
                celula62 = true;
            }
            else {
            pos2 = new Vector2(-14, -4);
            celula61 = true; }
        }
        else if (sorteioPosH2 == 62)
        {
            if (celula62 == true)
            {
                pos2 = new Vector2(-8, -4);
                celula63 = true;
            }
            else { 
                pos2 = new Vector2(-11, -4);
            celula62 = true;}
        }
        else if (sorteioPosH2 == 63)
        {
            if (celula63 == true) {
                pos2 = new Vector2(-5, -4);
                celula64 = true;
            }
            else { 
                pos2 = new Vector2(-8, -4);
            celula63 = true;}
        }
        else if (sorteioPosH2 == 64)
        {
            if (celula64 == true)
            {
                pos2 = new Vector2(-2, -4);
                celula65 = true;
            }
            else { 
                pos2 = new Vector2(-5, -4);
            celula64 = true;}
        }
        else if (sorteioPosH2 == 65)
        {
            if (celula65 == true) {
                pos2 = new Vector2(1, -4);
                celula66 = true;
            }
            else { 
                pos2 = new Vector2(-2, -4);
            celula65 = true;}
        }
        else if (sorteioPosH2 == 66)
        {
            if (celula66 == true)
            {
                pos2 = new Vector2(4, -4);
                celula67 = true;
            }
            else { 
                pos2 = new Vector2(1, -4);
            celula66 = true;}
        }
        else if (sorteioPosH2 == 67)
        {
            if (celula67 == true) {
                pos2 = new Vector2(7, -4);
                celula68 = true;
            }
            else
            {
                pos2 = new Vector2(4, -4);
                celula67 = true;
            }
                pos2 = new Vector2(4, -4);
            celula67 = true;
        }
        else if (sorteioPosH2 == 68)
        {
            if (celula68 == true)
            {
                pos2 = new Vector2(10, -4);
                celula69 = true;
            }
            else { 
                pos2 = new Vector2(7, -4);
            celula68 = true;}
        }
        else if (sorteioPosH2 == 69)
        {
            if (celula69 == true)
            {
                pos2 = new Vector2(13, -4);
                celula70 = true;
            }
            else { 
                pos2 = new Vector2(10, -4);
            celula69 = true;}
        }
        else if (sorteioPosH2 == 70)
        {
            if(celula70==true)
            {
                pos2 = new Vector2(-14, -7);
                celula71 = true;
            }
            else { 
            pos2 = new Vector2(13, -4);
            celula70 = true;}
        }
        else if (sorteioPosH2 == 71)
        {
            if (celula71 == true) {
                pos2 = new Vector2(-11, -7);
                celula72 = true;
            }
            else { 
                pos2 = new Vector2(-14, -7);
            celula71 = true;}
        }
        else if (sorteioPosH2 == 72)
        {
            if (celula72 == true)
            {
                pos2 = new Vector2(-8, -7);
                celula73 = true;
            }
            else {
                pos2 = new Vector2(-11, -7);
            celula72 = true; }
        }
        else if (sorteioPosH2 == 73)
        {
            if (celula73 == true)
            {
                pos2 = new Vector2(-5, -7);
                celula74 = true;
            }
            else { 
                pos2 = new Vector2(-8, -7);
            celula73 = true;}
        }
        else if (sorteioPosH2 == 74)
        {
            if (celula74 == true) {
                pos2 = new Vector2(-2, -7);
                celula75 = true;
            }
            else { 
                pos2 = new Vector2(-5, -7);
            celula74 = true;}
        }
        else if (sorteioPosH2 == 75)
        {
            if (celula75 == true)
            {
                pos2 = new Vector2(1, -7);
                celula76 = true;
            }
            else { 
                pos2 = new Vector2(-2, -7);
            celula75 = true;}
        }
        else if (sorteioPosH2 == 76)
        {
            if (celula76 == true)
            {
                pos2 = new Vector2(4, -7);
                celula77 = true;
            }
            else { 
                pos2 = new Vector2(1, -7);
            celula76 = true;}
        }
        else if (sorteioPosH2 == 77)
        {
            if (celula77 == true)
            {
                pos2 = new Vector2(7, -7);
                celula78 = true;
            }
            else { 
                pos2 = new Vector2(4, -7);
            celula77 = true;}
        }
        else if (sorteioPosH2 == 78)
        {
            if (celula78 == true)
            {
                pos2 = new Vector2(10, -7);
                celula79 = true;
            }
            else { 
                pos2 = new Vector2(7, -7);
            celula78 = true;}
        }
        else if (sorteioPosH2 == 79)
        {
            if (celula79 == true)
            {
                pos2 = new Vector2(13, -7);
                celula80 = true;
            }
            else { 
                pos2 = new Vector2(10, -7);
            celula79 = true;}
        }
        else if (sorteioPosH2 == 80)
        {
            if(celula80==true)
            {
                pos2 = new Vector2(-14, -10);
                celula81 = true;
            }
            else { 
            pos2 = new Vector2(13, -7);
            celula80 = true;}
        }
        else if (sorteioPosH2 == 81)
        {
            if(celula81==true)
            {
                pos2 = new Vector2(-11, -10);
                celula82 = true;
            }
            else { 
            pos2 = new Vector2(-14, -10);
            celula81 = true;}
        }
        else if (sorteioPosH2 == 82)
        {
            if(celula82==true)
            {
                pos2 = new Vector2(-8, -10);
                celula83 = true;
            }
            else { 
            pos2 = new Vector2(-11, -10);
            celula82 = true;}
        }
        else if (sorteioPosH2 == 83)
        {
            if(celula83==true)
            {
                pos2 = new Vector2(-5, -10);
                celula84 = true;
            }
            else { 
            pos2 = new Vector2(-8, -10);
            celula83 = true;}
        }
        else if (sorteioPosH2 == 84)
        {
            if(celula84==true)
            {
                pos2 = new Vector2(-2, -10);
                celula85 = true;
            }
            else
            {
            pos2 = new Vector2(-5, -10);
            celula84 = true; }
        }
        else if (sorteioPosH2 == 85)
        {
            if (celula85==true) {
                pos2 = new Vector2(1, -10);
                celula86 = true;
            }
            else { 
            pos2 = new Vector2(-2, -10);
            celula85 = true;}
        }
        else if (sorteioPosH2 == 86)
        {
            if(celula86==true)
            {
                pos2 = new Vector2(4, -10);
                celula87 = true;
            }
            else { 
            pos2 = new Vector2(1, -10);
            celula86 = true;}
        }
        else if (sorteioPosH2 == 87)
        {
            if(celula87==true)
            {
                pos2 = new Vector2(7, -10);
                celula88 = true;
            }
            else { 
            pos2 = new Vector2(4, -10);
            celula87 = true;}
        }
        else if (sorteioPosH2 == 88)
        {
            if (celula88 == true)
            {
                pos2 = new Vector2(10, -10);
                celula89 = true;
            }
            else { 
            pos2 = new Vector2(7, -10);
            celula88 = true;}
        }
        else if (sorteioPosH2 == 89)
        {
            if(celula89==true)
            {
                pos2 = new Vector2(13, -13);
                celula90 = true;
            }
            else { 
            pos2 = new Vector2(10, -10);
            celula89 = true;}
        }
        else if (sorteioPosH2 == 90)
        {
            if(celula90==true)
            {
                pos2 = new Vector2(-14, -13);
                celula91 = true;
            }
            else { 
            pos2 = new Vector2(13, -13);
            celula90 = true;}
        }
        else if (sorteioPosH2 == 91)
        {
            if (celula91 == true)
            {
                pos2 = new Vector2(-11, -13);
                celula92 = true;
            }
            else {
            pos2 = new Vector2(-14, -13);
            celula91 = true; }
        }
        else if (sorteioPosH2 == 92)
        {
            if(celula92==true)
            {
                pos2 = new Vector2(-8, -13);
                celula93 = true;
            }
            else { 
            pos2 = new Vector2(-11, -13);
            celula92 = true;}
        }
        else if (sorteioPosH2 == 93)
        {
            if (celula93 == true)
            {
                pos2 = new Vector2(-5, -13);
                celula94 = true;
            }
            else { 
            pos2 = new Vector2(-8, -13);
            celula93 = true;}
        }
        else if (sorteioPosH2 == 94)
        {
            if (celula94 == true)
            {
                pos2 = new Vector2(-2, -13);
                celula95 = true;
            }
            else { 
            pos2 = new Vector2(-5, -13);
            celula94 = true;}
        }
        else if (sorteioPosH2 == 95)
        {
            if (celula95 == true)
            {
                pos2 = new Vector2(1, -13);
                celula96 = true;
            }
            else { 
            pos2 = new Vector2(-2, -13);
            celula95 = true;}
        }
        else if (sorteioPosH2 == 96)
        {
            if(celula96==true)
            {
                pos2 = new Vector2(4, -13);
                celula97 = true;
            }
            else { 
            pos2 = new Vector2(1, -13);
            celula96 = true;}
        }
        else if (sorteioPosH2 == 97)
        {
            if (celula97 == true)
            {
                pos2 = new Vector2(7, -13);
                celula98 = true;
            }
            else { 
            pos2 = new Vector2(4, -13);
            celula97 = true;}
        }
        else if (sorteioPosH2 == 98)
        {
            if (celula98 == true)
            {
                pos2 = new Vector2(10, -13);
                celula99 = true;
            }
            else { 
            pos2 = new Vector2(7, -13);
            celula98 = true;}
        }
        else if (sorteioPosH2 == 99)
        {
            if (celula99 == true)
            {
                pos2 = new Vector2(13, -13);
                celula100 = true;
            }
            else { 
            pos2 = new Vector2(10, -13);
            celula99 = true;}
        }
        else if (sorteioPosH2 == 100)
        {
            if(celula100==true)
            {
                pos2 = new Vector2(-14, 14);
                celula1 = true;
            }
            else { 
            pos2 = new Vector2(13, -13);
            celula100 = true;}
        }
        else
        {
            pos2 = new Vector2(13, -13);

        }

        //sorteio da posição da caça 3
        sorteioPosH3 = Random.Range(1, 101);
        if (sorteioPosH3 == 1)
        {
            if (celula1 == true)
            {
                pos3 = new Vector2(-11, 14);
                celula2 = true;
            }
            else
            {
                pos3 = new Vector2(-14, 14);
                celula1 = true;

            }


        }
        else if (sorteioPosH3 == 2)
        {
            if (celula2 == true)
            {
                pos3 = new Vector2(-11, 14);
                celula3 = true;
            }
            else
            {
                pos3 = new Vector2(-8, 14);
                celula2 = true;

            }

        }
        else if (sorteioPosH3 == 3)
        {
            if (celula3 == true)
            {
                pos3 = new Vector2(-5, 14);
                celula4 = true;
            }
            else
            {
                pos3 = new Vector2(-8, 14);
                celula3 = true;

            }

        }
        else if (sorteioPosH3 == 4)
        {
            if (celula4 == true)
            {
                pos3 = new Vector2(-2, 14);
                celula5 = true;
            }
            else
            {
                pos3 = new Vector2(-5, 14);
                celula4 = true;
            }
        }
        else if (sorteioPosH3 == 5)
        {
            if (celula5 == true)
            {
                pos3 = new Vector2(1, 14);
                celula6 = true;
            }
            else
            {
                pos3 = new Vector2(-2, 14);
                celula5 = true;
            }
        }
        else if (sorteioPosH3 == 6)
        {
            if (celula6 == true)
            {
                pos3 = new Vector2(4, 14);
                celula7 = true;
            }
            else
            {
                pos3 = new Vector2(1, 14);
                celula6 = true;
            }
        }
        else if (sorteioPosH3 == 7)
        {
            if (celula7 == true)
            {
                pos3 = new Vector2(7, 14);
                celula8 = true;
            }
            else
            {
                pos3 = new Vector2(4, 14);
                celula7 = true;
            }
        }
        else if (sorteioPosH3 == 8)
        {
            if (celula8 == true)
            {
                pos3 = new Vector2(10, 14);
                celula9 = true;
            }
            else
            {
                pos3 = new Vector2(7, 14);
                celula8 = true;
            }
        }
        else if (sorteioPosH3 == 9)
        {
            if (celula9 == true)
            {
                pos3 = new Vector2(13, 14);
                celula10 = true;
            }
            else
            {
                pos3 = new Vector2(10, 14);
                celula9 = true;
            }
        }
        else if (sorteioPosH3 == 10)
        {
            if (celula10 == true)
            {
                pos3 = new Vector2(-14, 11);
                celula11 = true;
            }
            else
            {
                pos3 = new Vector2(13, 14);
                celula10 = true;
            }
        }
        else if (sorteioPosH3 == 11)
        {
            if (celula11 == true)
            {
                pos3 = new Vector2(-11, 11);
                celula12 = true;
            }
            else
            {
                pos3 = new Vector2(-14, 11);
                celula11 = true;
            }
        }
        else if (sorteioPosH3 == 12)
        {
            if (celula12 == true)
            {
                pos3 = new Vector2(-8, 11);
                celula13 = true;
            }
            else
            {
                pos3 = new Vector2(-11, 11);
                celula12 = true;
            }
        }
        else if (sorteioPosH3 == 13)
        {
            if (celula13 == true)
            {
                pos3 = new Vector2(-5, 11);
                celula14 = true;
            }
            else
            {
                pos3 = new Vector2(-8, 11);
                celula13 = true;
            }
        }
        else if (sorteioPosH3 == 14)
        {
            if (celula14 == true)
            {
                pos3 = new Vector2(-2, 11);
                celula15 = true;
            }
            else
            {

                pos3 = new Vector2(-5, 11);
                celula14 = true;
            }
        }
        else if (sorteioPosH3 == 15)
        {
            if (celula15 == true)
            {
                pos3 = new Vector2(1, 11);
                celula16 = true;
            }
            else
            {
                pos3 = new Vector2(-2, 11);
                celula15 = true;
            }
        }
        else if (sorteioPosH3 == 16)
        {
            if (celula16 == true)
            {
                pos3 = new Vector2(4, 11);
                celula17 = true;
            }
            else
            {
                pos3 = new Vector2(1, 11);
                celula16 = true;
            }
        }
        else if (sorteioPosH3 == 17)
        {
            if (celula17 == true)
            {
                pos3 = new Vector2(7, 11);
                celula18 = true;
            }
            else if(celula17=false)
            {
                pos3 = new Vector2(4, 11);
                celula17 = true;
            }
            else
            {
                pos3 = new Vector2(4, 11);
                celula17 = true;
            }
        }
        else if (sorteioPosH3 == 18)
        {
            if (celula13 == true)
            {
                pos3 = new Vector2(10, 11);
                celula19 = true;
            }
            else
            {
                pos3 = new Vector2(7, 11);
                celula18 = true;
            }
        }
        else if (sorteioPosH3 == 19)
        {
            if (celula19 == true)
            {
                pos3 = new Vector2(13, 11);
                celula20 = true;
            }
            else
            {
                pos3 = new Vector2(10, 11);
                celula19 = true;
            }
        }
        else if (sorteioPosH3 == 20)
        {
            if (celula20 == true)
            {
                pos3 = new Vector2(-14, 8);
                celula21 = true;
            }
            else
            {
                pos3 = new Vector2(13, 11);
                celula20 = true;
            }
        }
        else if (sorteioPosH3 == 21)
        {
            if (celula21 == true)
            {
                pos3 = new Vector2(-11, 8);
                celula22 = true;
            }
            else
            {
                pos3 = new Vector2(-14, 8);
                celula21 = true;
            }
        }
        else if (sorteioPosH3 == 22)
        {
            if (celula22 == true)
            {
                pos3 = new Vector2(-8, 8);
                celula23 = true;
            }
            else
            {
                pos3 = new Vector2(-11, 8);
                celula22 = true;
            }
        }
        else if (sorteioPosH3 == 23)
        {
            if (celula23 == true)
            {
                pos3 = new Vector2(-5, 8);
                celula24 = true;
            }
            else
            {
                pos3 = new Vector2(-8, 8);
                celula23 = true;
            }
        }
        else if (sorteioPosH3 == 24)
        {
            if (celula24 == true)
            {
                pos3 = new Vector2(-2, 8);
                celula25 = true;
            }
            else
            {
                pos3 = new Vector2(-5, 8);
                celula24 = true;
            }
        }
        else if (sorteioPosH3 == 25)
        {
            if (celula25 == true)
            {
                pos3 = new Vector2(1, 8);
                celula26 = true;
            }
            else
            {
                pos3 = new Vector2(-2, 8);
                celula25 = true;
            }
        }
        else if (sorteioPosH3 == 26)
        {
            if (celula26 == true)
            {
                pos3 = new Vector2(4, 8);
                celula27 = true;
            }
            else
            {
                pos3 = new Vector2(1, 8);
                celula26 = true;
            }
        }
        else if (sorteioPosH3 == 27)
        {
            if (celula27 == true)
            {
                pos3 = new Vector2(7, 8);
                celula28 = true;
            }
            else
            {
                pos3 = new Vector2(4, 8);
                celula27 = true;
            }
        }
        else if (sorteioPosH3 == 28)
        {
            if (celula28 == true)
            {
                pos3 = new Vector2(10, 8);
                celula29 = true;
            }
            else
            {

                pos3 = new Vector2(7, 8);
                celula28 = true;
            }
        }
        else if (sorteioPosH3 == 29)
        {
            if (celula29 == true)
            {
                pos3 = new Vector2(13, 8);
                celula30 = true;
            }
            else
            {
                pos3 = new Vector2(10, 8);
                celula29 = true;
            }
        }
        else if (sorteioPosH3 == 30)
        {
            if (celula30 == true)
            {
                pos3 = new Vector2(-14, 5);
                celula31 = true;
            }
            else
            {
                pos3 = new Vector2(13, 8);
                celula30 = true;
            }
        }
        else if (sorteioPosH3 == 31)
        {
            if (celula31 == true)
            {
                pos3 = new Vector2(-11, 5);
                celula32 = true;
            }
            else
            {
                pos3 = new Vector2(-14, 5);
                celula31 = true;
            }
        }
        else if (sorteioPosH3 == 32)
        {
            if (celula32 == true)
            {
                pos3 = new Vector2(-8, 5);
                celula33 = true;
            }
            else
            {
                pos3 = new Vector2(-11, 5);
                celula32 = true;
            }
        }
        else if (sorteioPosH3 == 33)
        {
            if (celula33 == true)
            {
                pos3 = new Vector2(-5, 5);
                celula34 = true;
            }
            else
            {
                pos3 = new Vector2(-8, 5);
                celula33 = true;
            }
        }
        else if (sorteioPosH3 == 34)
        {
            if (celula34 == true)
            {
                pos3 = new Vector2(-2, 5);
                celula35 = true;
            }
            else
            {
                pos3 = new Vector2(-5, 5);
                celula34 = true;
            }
        }
        else if (sorteioPosH3 == 35)
        {
            if (celula35 == true)
            {
                pos3 = new Vector2(1, 5);
                celula36 = true;
            }
            else
            {
                pos3 = new Vector2(-2, 5);
                celula35 = true;
            }
        }
        else if (sorteioPosH3 == 36)
        {
            if (celula36 == true)
            {
                pos3 = new Vector2(4, 5);
                celula37 = true;
            }
            else
            {
                pos3 = new Vector2(1, 5);
                celula36 = true;
            }
        }
        else if (sorteioPosH3 == 37)
        {
            if (celula37 == true)
            {
                pos3 = new Vector2(7, 5);
                celula38 = true;
            }
            else
            {
                pos3 = new Vector2(4, 5);
                celula37 = true;
            }
        }
        else if (sorteioPosH3 == 38)
        {
            if (celula38 == true)
            {
                pos3 = new Vector2(10, 5);
                celula39 = true;
            }
            else
            {
                pos3 = new Vector2(7, 5);
                celula38 = true;
            }
        }
        else if (sorteioPosH3 == 39)
        {
            if (celula39 == true)
            {
                pos3 = new Vector2(13, 5);
                celula40 = true;
            }
            else
            {
                pos3 = new Vector2(10, 5);
                celula39 = true;
            }
        }
        else if (sorteioPosH3 == 40)
        {
            if (celula40 == true)
            {
                pos3 = new Vector2(-14, 2);
                celula41 = true;
            }
            else
            {
                pos3 = new Vector2(13, 5);
                celula40 = true;
            }
        }
        else if (sorteioPosH3 == 41)
        {
            if (celula41 == true)
            {
                pos3 = new Vector2(-11, 2);
                celula42 = true;
            }
            else
            {
                pos3 = new Vector2(-14, 2);
                celula41 = true;
            }
        }
        else if (sorteioPosH3 == 42)
        {
            if (celula42 == true)
            {
                pos3 = new Vector2(-8, 2);
                celula43 = true;
            }
            else
            {
                pos3 = new Vector2(-11, 2);
                celula42 = true;
            }
        }
        else if (sorteioPosH3 == 43)
        {
            if (celula43 == true)
            {
                pos3 = new Vector2(-5, 2);
                celula44 = true;
            }
            else
            {
                pos3 = new Vector2(-8, 2);
                celula43 = true;
            }
        }
        else if (sorteioPosH3 == 44)
        {
            if (celula44 == true)
            {
                pos3 = new Vector2(-2, 2);
                celula45 = true;
            }
            else
            {
                pos3 = new Vector2(-5, 2);
                celula44 = true;
            }
        }
        else if (sorteioPosH3 == 45)
        {
            if (celula45 == true)
            {
                pos3 = new Vector2(1, 2);
                celula46 = true;
            }
            else
            {
                pos3 = new Vector2(-2, 2);
                celula45 = true;
            }
        }
        else if (sorteioPosH3 == 46)
        {
            if (celula46 == true)
            {
                pos3 = new Vector2(4, 2);
                celula47 = true;
            }
            else
            {
                pos3 = new Vector2(1, 2);
                celula46 = true;
            }
        }
        else if (sorteioPosH3 == 47)
        {
            if (celula47 == true)
            {
                pos3 = new Vector2(7, 2);
                celula48 = true;
            }
            else
            {
                pos3 = new Vector2(4, 2);
                celula47 = true;
            }
        }
        else if (sorteioPosH3 == 48)
        {
            if (celula48 == true)
            {
                pos3 = new Vector2(10, 2);
                celula49 = true;
            }
            else
            {
                pos3 = new Vector2(7, 2);
                celula48 = true;
            }
        }
        else if (sorteioPosH3 == 49)
        {
            if (celula49 == true)
            {
                pos3 = new Vector2(13, 2);
                celula50 = true;
            }
            else
            {
                pos3 = new Vector2(10, 2);
                celula49 = true;
            }
        }
        else if (sorteioPosH3 == 50)
        {
            if (celula50 == true)
            {
                pos3 = new Vector2(-14, -1);
                celula51 = true;
            }
            else
            {
                pos3 = new Vector2(13, 2);
                celula50 = true;
            }
        }
        else if (sorteioPosH3 == 51)
        {
            if (celula51 == true)
            {
                pos3 = new Vector2(-11, -1);
                celula52 = true;
            }
            else
            {
                pos3 = new Vector2(-14, -1);
                celula51 = true;
            }
        }
        else if (sorteioPosH3 == 52)
        {
            if (celula52 == true)
            {
                pos3 = new Vector2(-8, -1);
                celula53 = true;
            }
            else
            {
                pos3 = new Vector2(-11, -1);
                celula52 = true;
            }
        }
        else if (sorteioPosH3 == 53)
        {
            if (celula53 == true)
            {
                pos3 = new Vector2(-5, -1);
                celula54 = true;
            }
            else
            {
                pos3 = new Vector2(-8, -1);
                celula53 = true;
            }
        }
        else if (sorteioPosH3 == 54)
        {
            if (celula54 == true)
            {
                pos3 = new Vector2(-2, -1);
                celula55 = true;
            }
            else
            {
                pos3 = new Vector2(-5, -1);
                celula54 = true;
            }
        }
        else if (sorteioPosH3 == 55)
        {
            if (celula55 == true)
            {
                pos3 = new Vector2(1, -1);
                celula56 = true;
            }
            else
            {
                pos3 = new Vector2(-2, -1);
                celula55 = true;
            }
        }
        else if (sorteioPosH3 == 56)
        {
            if (celula56 == true)
            {
                pos3 = new Vector2(4, -1);
                celula57 = true;
            }
            else
            {
                pos3 = new Vector2(1, -1);
                celula56 = true;
            }
        }
        else if (sorteioPosH3 == 57)
        {
            if (celula57 == true)
            {
                pos3 = new Vector2(7, -1);
                celula58 = true;
            }
            else
            {
                pos3 = new Vector2(4, -1);
                celula57 = true;
            }
        }
        else if (sorteioPosH3 == 58)
        {
            if (celula58 == true)
            {
                pos3 = new Vector2(10, -1);
                celula59 = true;
            }
            else
            {
                pos3 = new Vector2(7, -1);
                celula58 = true;
            }
        }
        else if (sorteioPosH3 == 59)
        {
            if (celula59 == true)
            {
                pos3 = new Vector2(-13, -1);
                celula60 = true;
            }
            else
            {
                pos3 = new Vector2(10, -1);
                celula59 = true;
            }
        }
        else if (sorteioPosH3 == 60)
        {
            if (celula60 == true)
            {
                pos3 = new Vector2(-14, -4);
                celula61 = true;
            }
            else
            {
                pos3 = new Vector2(-14, -1);
                celula60 = true;
            }
        }
        else if (sorteioPosH3 == 61)
        {
            if (celula61 == true)
            {
                pos3 = new Vector2(-11, -4);
                celula62 = true;
            }
            else
            {
                pos3 = new Vector2(-14, -4);
                celula61 = true;
            }
        }
        else if (sorteioPosH3 == 62)
        {
            if (celula62 == true)
            {
                pos3 = new Vector2(-8, -4);
                celula63 = true;
            }
            else
            {
                pos3 = new Vector2(-11, -4);
                celula62 = true;
            }
        }
        else if (sorteioPosH3 == 63)
        {
            if (celula63 == true)
            {
                pos3 = new Vector2(-5, -4);
                celula64 = true;
            }
            else
            {
                pos3 = new Vector2(-8, -4);
                celula63 = true;
            }
        }
        else if (sorteioPosH3 == 64)
        {
            if (celula64 == true)
            {
                pos3 = new Vector2(-2, -4);
                celula65 = true;
            }
            else
            {
                pos3 = new Vector2(-5, -4);
                celula64 = true;
            }
        }
        else if (sorteioPosH3 == 65)
        {
            if (celula65 == true)
            {
                pos3 = new Vector2(1, -4);
                celula66 = true;
            }
            else
            {
                pos3 = new Vector2(-2, -4);
                celula65 = true;
            }
        }
        else if (sorteioPosH3 == 66)
        {
            if (celula66 == true)
            {
                pos3 = new Vector2(4, -4);
                celula67 = true;
            }
            else
            {
                pos3 = new Vector2(1, -4);
                celula66 = true;
            }
        }
        else if (sorteioPosH3 == 67)
        {
            if (celula67 == true)
            {
                pos3 = new Vector2(7, -4);
                celula68 = true;
            }
            else
            {
                pos3 = new Vector2(4, -4);
                celula67 = true;
            }
           
        }
        else if (sorteioPosH3 == 68)
        {
            if (celula68 == true)
            {
                pos3 = new Vector2(10, -4);
                celula69 = true;
            }
            else
            {
                pos3 = new Vector2(7, -4);
                celula68 = true;
            }
        }
        else if (sorteioPosH3 == 69)
        {
            if (celula69 == true)
            {
                pos3 = new Vector2(13, -4);
                celula70 = true;
            }
            else
            {
                pos3 = new Vector2(10, -4);
                celula69 = true;
            }
        }
        else if (sorteioPosH3 == 70)
        {
            if (celula70 == true)
            {
                pos3 = new Vector2(-14, -7);
                celula71 = true;
            }
            else
            {
                pos3 = new Vector2(13, -4);
                celula70 = true;
            }
        }
        else if (sorteioPosH3 == 71)
        {
            if (celula71 == true)
            {
                pos3 = new Vector2(-11, -7);
                celula72 = true;
            }
            else
            {
                pos3 = new Vector2(-14, -7);
                celula71 = true;
            }
        }
        else if (sorteioPosH3 == 72)
        {
            if (celula72 == true)
            {
                pos3 = new Vector2(-8, -7);
                celula73 = true;
            }
            else
            {
                pos3 = new Vector2(-11, -7);
                celula72 = true;
            }
        }
        else if (sorteioPosH3 == 73)
        {
            if (celula73 == true)
            {
                pos3 = new Vector2(-5, -7);
                celula74 = true;
            }
            else
            {
                pos3 = new Vector2(-8, -7);
                celula73 = true;
            }
        }
        else if (sorteioPosH3 == 74)
        {
            if (celula74 == true)
            {
                pos3 = new Vector2(-2, -7);
                celula75 = true;
            }
            else
            {
                pos3 = new Vector2(-5, -7);
                celula74 = true;
            }
        }
        else if (sorteioPosH3 == 75)
        {
            if (celula75 == true)
            {
                pos3 = new Vector2(1, -7);
                celula76 = true;
            }
            else
            {
                pos3 = new Vector2(-2, -7);
                celula75 = true;
            }
        }
        else if (sorteioPosH3 == 76)
        {
            if (celula76 == true)
            {
                pos3 = new Vector2(4, -7);
                celula77 = true;
            }
            else
            {
                pos3 = new Vector2(1, -7);
                celula76 = true;
            }
        }
        else if (sorteioPosH3 == 77)
        {
            if (celula77 == true)
            {
                pos3 = new Vector2(7, -7);
                celula78 = true;
            }
            else
            {
                pos3 = new Vector2(4, -7);
                celula77 = true;
            }
        }
        else if (sorteioPosH3 == 78)
        {
            if (celula78 == true)
            {
                pos3 = new Vector2(10, -7);
                celula79 = true;
            }
            else
            {
                pos3 = new Vector2(7, -7);
                celula78 = true;
            }
        }
        else if (sorteioPosH3 == 79)
        {
            if (celula79 == true)
            {
                pos3 = new Vector2(13, -7);
                celula80 = true;
            }
            else
            {
                pos3 = new Vector2(10, -7);
                celula79 = true;
            }
        }
        else if (sorteioPosH3 == 80)
        {
            if (celula80 == true)
            {
                pos3 = new Vector2(-14, -10);
                celula81 = true;
            }
            else
            {
                pos3 = new Vector2(13, -7);
                celula80 = true;
            }
        }
        else if (sorteioPosH3 == 81)
        {
            if (celula81 == true)
            {
                pos3 = new Vector2(-11, -10);
                celula82 = true;
            }
            else
            {
                pos3 = new Vector2(-14, -10);
                celula81 = true;
            }
        }
        else if (sorteioPosH3 == 82)
        {
            if (celula82 == true)
            {
                pos3 = new Vector2(-8, -10);
                celula83 = true;
            }
            else
            {
                pos3 = new Vector2(-11, -10);
                celula82 = true;
            }
        }
        else if (sorteioPosH3 == 83)
        {
            if (celula83 == true)
            {
                pos3 = new Vector2(-5, -10);
                celula84 = true;
            }
            else
            {
                pos3 = new Vector2(-8, -10);
                celula83 = true;
            }
        }
        else if (sorteioPosH3 == 84)
        {
            if (celula84 == true)
            {
                pos3 = new Vector2(-2, -10);
                celula85 = true;
            }
            else
            {
                pos3 = new Vector2(-5, -10);
                celula84 = true;
            }
        }
        else if (sorteioPosH3 == 85)
        {
            if (celula85 == true)
            {
                pos3 = new Vector2(1, -10);
                celula86 = true;
            }
            else
            {
                pos3 = new Vector2(-2, -10);
                celula85 = true;
            }
        }
        else if (sorteioPosH3 == 86)
        {
            if (celula86 == true)
            {
                pos3 = new Vector2(4, -10);
                celula87 = true;
            }
            else
            {
                pos3 = new Vector2(1, -10);
                celula86 = true;
            }
        }
        else if (sorteioPosH3 == 87)
        {
            if (celula87 == true)
            {
                pos3 = new Vector2(7, -10);
                celula88 = true;
            }
            else
            {
                pos3 = new Vector2(4, -10);
                celula87 = true;
            }
        }
        else if (sorteioPosH3 == 88)
        {
            if (celula88 == true)
            {
                pos3 = new Vector2(10, -10);
                celula89 = true;
            }
            else
            {
                pos3 = new Vector2(7, -10);
                celula88 = true;
            }
        }
        else if (sorteioPosH3 == 89)
        {
            if (celula89 == true)
            {
                pos3 = new Vector2(13, -13);
                celula90 = true;
            }
            else
            {
                pos3 = new Vector2(10, -10);
                celula89 = true;
            }
        }
        else if (sorteioPosH3 == 90)
        {
            if (celula90 == true)
            {
                pos3 = new Vector2(-14, -13);
                celula91 = true;
            }
            else
            {
                pos3 = new Vector2(13, -13);
                celula90 = true;
            }
        }
        else if (sorteioPosH3 == 91)
        {
            if (celula91 == true)
            {
                pos3 = new Vector2(-11, -13);
                celula92 = true;
            }
            else
            {
                pos3 = new Vector2(-14, -13);
                celula91 = true;
            }
        }
        else if (sorteioPosH3 == 92)
        {
            if (celula92 == true)
            {
                pos3 = new Vector2(-8, -13);
                celula93 = true;
            }
            else
            {
                pos3 = new Vector2(-11, -13);
                celula92 = true;
            }
        }
        else if (sorteioPosH3 == 93)
        {
            if (celula93 == true)
            {
                pos3 = new Vector2(-5, -13);
                celula94 = true;
            }
            else
            {
                pos3 = new Vector2(-8, -13);
                celula93 = true;
            }
        }
        else if (sorteioPosH3 == 94)
        {
            if (celula94 == true)
            {
                pos3 = new Vector2(-2, -13);
                celula95 = true;
            }
            else
            {
                pos3 = new Vector2(-5, -13);
                celula94 = true;
            }
        }
        else if (sorteioPosH3 == 95)
        {
            if (celula95 == true)
            {
                pos3 = new Vector2(1, -13);
                celula96 = true;
            }
            else
            {
                pos3 = new Vector2(-2, -13);
                celula95 = true;
            }
        }
        else if (sorteioPosH3 == 96)
        {
            if (celula96 == true)
            {
                pos3 = new Vector2(4, -13);
                celula97 = true;
            }
            else
            {
                pos3 = new Vector2(1, -13);
                celula96 = true;
            }
        }
        else if (sorteioPosH3 == 97)
        {
            if (celula97 == true)
            {
                pos3 = new Vector2(7, -13);
                celula98 = true;
            }
            else
            {
                pos3 = new Vector2(4, -13);
                celula97 = true;
            }
        }
        else if (sorteioPosH3 == 98)
        {
            if (celula98 == true)
            {
                pos3 = new Vector2(10, -13);
                celula99 = true;
            }
            else
            {
                pos3 = new Vector2(7, -13);
                celula98 = true;
            }
        }
        else if (sorteioPosH3 == 99)
        {
            if (celula99 == true)
            {
                pos3 = new Vector2(13, -13);
                celula100 = true;
            }
            else
            {
                pos3 = new Vector2(10, -13);
                celula99 = true;
            }
        }
        else if (sorteioPosH3 == 100)
        {
            if (celula100 == true)
            {
                pos3 = new Vector2(-14, 14);
                celula1 = true;
            }
            else
            {
                pos3 = new Vector2(13, -13);
                celula100 = true;
            }
        }
        else
        {
            pos3 = new Vector2(13, -13);

        }

        //Sorteio da posição da Caça 4
        sorteioPosH4 = Random.Range(1, 101);

        if (sorteioPosH4 == 1)
        {
            if (celula1 == true)
            {
                pos4 = new Vector2(-11, 14);
                celula2 = true;
            }
            else
            {
                pos4 = new Vector2(-14, 14);
                celula1 = true;

            }


        }
        else if (sorteioPosH4 == 2)
        {
            if (celula2 == true)
            {
                pos4 = new Vector2(-11, 14);
                celula3 = true;
            }
            else
            {
                pos4 = new Vector2(-8, 14);
                celula2 = true;

            }

        }
        else if (sorteioPosH4 == 3)
        {
            if (celula3 == true)
            {
                pos4 = new Vector2(-5, 14);
                celula4 = true;
            }
            else
            {
                pos4 = new Vector2(-8, 14);
                celula3 = true;

            }

        }
        else if (sorteioPosH4 == 4)
        {
            if (celula4 == true)
            {
                pos4 = new Vector2(-2, 14);
                celula5 = true;
            }
            else
            {
                pos4 = new Vector2(-5, 14);
                celula4 = true;
            }
        }
        else if (sorteioPosH4 == 5)
        {
            if (celula5 == true)
            {
                pos4 = new Vector2(1, 14);
                celula6 = true;
            }
            else
            {
                pos4 = new Vector2(-2, 14);
                celula5 = true;
            }
        }
        else if (sorteioPosH4 == 6)
        {
            if (celula6 == true)
            {
                pos4 = new Vector2(4, 14);
                celula7 = true;
            }
            else
            {
                pos4 = new Vector2(1, 14);
                celula6 = true;
            }
        }
        else if (sorteioPosH4 == 7)
        {
            if (celula7 == true)
            {
                pos4 = new Vector2(7, 14);
                celula8 = true;
            }
            else
            {
                pos4 = new Vector2(4, 14);
                celula7 = true;
            }
        }
        else if (sorteioPosH4 == 8)
        {
            if (celula8 == true)
            {
                pos4 = new Vector2(10, 14);
                celula9 = true;
            }
            else
            {
                pos4 = new Vector2(7, 14);
                celula8 = true;
            }
        }
        else if (sorteioPosH4 == 9)
        {
            if (celula9 == true)
            {
                pos4 = new Vector2(13, 14);
                celula10 = true;
            }
            else
            {
                pos4 = new Vector2(10, 14);
                celula9 = true;
            }
        }
        else if (sorteioPosH4 == 10)
        {
            if (celula10 == true)
            {
                pos4 = new Vector2(-14, 11);
                celula11 = true;
            }
            else
            {
                pos4 = new Vector2(13, 14);
                celula10 = true;
            }
        }
        else if (sorteioPosH4 == 11)
        {
            if (celula11 == true)
            {
                pos4 = new Vector2(-11, 11);
                celula12 = true;
            }
            else
            {
                pos4 = new Vector2(-14, 11);
                celula11 = true;
            }
        }
        else if (sorteioPosH4 == 12)
        {
            if (celula12 == true)
            {
                pos4 = new Vector2(-8, 11);
                celula13 = true;
            }
            else
            {
                pos4 = new Vector2(-11, 11);
                celula12 = true;
            }
        }
        else if (sorteioPosH4 == 13)
        {
            if (celula13 == true)
            {
                pos4 = new Vector2(-5, 11);
                celula14 = true;
            }
            else
            {
                pos4 = new Vector2(-8, 11);
                celula13 = true;
            }
        }
        else if (sorteioPosH4 == 14)
        {
            if (celula14 == true)
            {
                pos4 = new Vector2(-2, 11);
                celula15 = true;
            }
            else
            {

                pos4 = new Vector2(-5, 11);
                celula14 = true;
            }
        }
        else if (sorteioPosH4 == 15)
        {
            if (celula15 == true)
            {
                pos4 = new Vector2(1, 11);
                celula16 = true;
            }
            else
            {
                pos4 = new Vector2(-2, 11);
                celula15 = true;
            }
        }
        else if (sorteioPosH4 == 16)
        {
            if (celula16 == true)
            {
                pos4 = new Vector2(4, 11);
                celula17 = true;
            }
            else
            {
                pos4 = new Vector2(1, 11);
                celula16 = true;
            }
        }
        else if (sorteioPosH4 == 17)
        {
            if (celula17 == true)
            {
                pos4 = new Vector2(7, 11);
                celula18 = true;
            }
          
            else
            {
                pos4 = new Vector2(4, 11);
                celula17 = true;
            }
        }
        else if (sorteioPosH4 == 18)
        {
            if (celula13 == true)
            {
                pos4 = new Vector2(10, 11);
                celula19 = true;
            }
            else
            {
                pos4 = new Vector2(7, 11);
                celula18 = true;
            }
        }
        else if (sorteioPosH4 == 19)
        {
            if (celula19 == true)
            {
                pos4 = new Vector2(13, 11);
                celula20 = true;
            }
            else
            {
                pos4 = new Vector2(10, 11);
                celula19 = true;
            }
        }
        else if (sorteioPosH4 == 20)
        {
            if (celula20 == true)
            {
                pos4 = new Vector2(-14, 8);
                celula21 = true;
            }
            else
            {
                pos4 = new Vector2(13, 11);
                celula20 = true;
            }
        }
        else if (sorteioPosH4 == 21)
        {
            if (celula21 == true)
            {
                pos4 = new Vector2(-11, 8);
                celula22 = true;
            }
            else
            {
                pos4 = new Vector2(-14, 8);
                celula21 = true;
            }
        }
        else if (sorteioPosH4 == 22)
        {
            if (celula22 == true)
            {
                pos4 = new Vector2(-8, 8);
                celula23 = true;
            }
            else
            {
                pos4 = new Vector2(-11, 8);
                celula22 = true;
            }
        }
        else if (sorteioPosH4 == 23)
        {
            if (celula23 == true)
            {
                pos4 = new Vector2(-5, 8);
                celula24 = true;
            }
            else
            {
                pos4 = new Vector2(-8, 8);
                celula23 = true;
            }
        }
        else if (sorteioPosH4 == 24)
        {
            if (celula24 == true)
            {
                pos4 = new Vector2(-2, 8);
                celula25 = true;
            }
            else
            {
                pos4 = new Vector2(-5, 8);
                celula24 = true;
            }
        }
        else if (sorteioPosH4 == 25)
        {
            if (celula25 == true)
            {
                pos4 = new Vector2(1, 8);
                celula26 = true;
            }
            else
            {
                pos4 = new Vector2(-2, 8);
                celula25 = true;
            }
        }
        else if (sorteioPosH4 == 26)
        {
            if (celula26 == true)
            {
                pos4 = new Vector2(4, 8);
                celula27 = true;
            }
            else
            {
                pos4 = new Vector2(1, 8);
                celula26 = true;
            }
        }
        else if (sorteioPosH4 == 27)
        {
            if (celula27 == true)
            {
                pos4 = new Vector2(7, 8);
                celula28 = true;
            }
            else
            {
                pos4 = new Vector2(4, 8);
                celula27 = true;
            }
        }
        else if (sorteioPosH4 == 28)
        {
            if (celula28 == true)
            {
                pos4 = new Vector2(10, 8);
                celula29 = true;
            }
            else
            {

                pos4 = new Vector2(7, 8);
                celula28 = true;
            }
        }
        else if (sorteioPosH4 == 29)
        {
            if (celula29 == true)
            {
                pos4 = new Vector2(13, 8);
                celula30 = true;
            }
            else
            {
                pos4 = new Vector2(10, 8);
                celula29 = true;
            }
        }
        else if (sorteioPosH4 == 30)
        {
            if (celula30 == true)
            {
                pos4 = new Vector2(-14, 5);
                celula31 = true;
            }
            else
            {
                pos4 = new Vector2(13, 8);
                celula30 = true;
            }
        }
        else if (sorteioPosH4 == 31)
        {
            if (celula31 == true)
            {
                pos4 = new Vector2(-11, 5);
                celula32 = true;
            }
            else
            {
                pos4 = new Vector2(-14, 5);
                celula31 = true;
            }
        }
        else if (sorteioPosH4 == 32)
        {
            if (celula32 == true)
            {
                pos4 = new Vector2(-8, 5);
                celula33 = true;
            }
            else
            {
                pos4 = new Vector2(-11, 5);
                celula32 = true;
            }
        }
        else if (sorteioPosH4 == 33)
        {
            if (celula33 == true)
            {
                pos4 = new Vector2(-5, 5);
                celula34 = true;
            }
            else
            {
                pos4 = new Vector2(-8, 5);
                celula33 = true;
            }
        }
        else if (sorteioPosH4 == 34)
        {
            if (celula34 == true)
            {
                pos4 = new Vector2(-2, 5);
                celula35 = true;
            }
            else
            {
                pos4 = new Vector2(-5, 5);
                celula34 = true;
            }
        }
        else if (sorteioPosH4 == 35)
        {
            if (celula35 == true)
            {
                pos4 = new Vector2(1, 5);
                celula36 = true;
            }
            else
            {
                pos4 = new Vector2(-2, 5);
                celula35 = true;
            }
        }
        else if (sorteioPosH4 == 36)
        {
            if (celula36 == true)
            {
                pos4 = new Vector2(4, 5);
                celula37 = true;
            }
            else
            {
                pos4 = new Vector2(1, 5);
                celula36 = true;
            }
        }
        else if (sorteioPosH4 == 37)
        {
            if (celula37 == true)
            {
                pos4 = new Vector2(7, 5);
                celula38 = true;
            }
            else
            {
                pos4 = new Vector2(4, 5);
                celula37 = true;
            }
        }
        else if (sorteioPosH4 == 38)
        {
            if (celula38 == true)
            {
                pos4 = new Vector2(10, 5);
                celula39 = true;
            }
            else
            {
                pos4 = new Vector2(7, 5);
                celula38 = true;
            }
        }
        else if (sorteioPosH4 == 39)
        {
            if (celula39 == true)
            {
                pos4 = new Vector2(13, 5);
                celula40 = true;
            }
            else
            {
                pos4 = new Vector2(10, 5);
                celula39 = true;
            }
        }
        else if (sorteioPosH4 == 40)
        {
            if (celula40 == true)
            {
                pos4 = new Vector2(-14, 2);
                celula41 = true;
            }
            else
            {
                pos4 = new Vector2(13, 5);
                celula40 = true;
            }
        }
        else if (sorteioPosH4 == 41)
        {
            if (celula41 == true)
            {
                pos4 = new Vector2(-11, 2);
                celula42 = true;
            }
            else
            {
                pos4 = new Vector2(-14, 2);
                celula41 = true;
            }
        }
        else if (sorteioPosH4 == 42)
        {
            if (celula42 == true)
            {
                pos4 = new Vector2(-8, 2);
                celula43 = true;
            }
            else
            {
                pos4 = new Vector2(-11, 2);
                celula42 = true;
            }
        }
        else if (sorteioPosH4 == 43)
        {
            if (celula43 == true)
            {
                pos4 = new Vector2(-5, 2);
                celula44 = true;
            }
            else
            {
                pos4 = new Vector2(-8, 2);
                celula43 = true;
            }
        }
        else if (sorteioPosH4 == 44)
        {
            if (celula44 == true)
            {
                pos4 = new Vector2(-2, 2);
                celula45 = true;
            }
            else
            {
                pos4 = new Vector2(-5, 2);
                celula44 = true;
            }
        }
        else if (sorteioPosH4 == 45)
        {
            if (celula45 == true)
            {
                pos4 = new Vector2(1, 2);
                celula46 = true;
            }
            else
            {
                pos4 = new Vector2(-2, 2);
                celula45 = true;
            }
        }
        else if (sorteioPosH4 == 46)
        {
            if (celula46 == true)
            {
                pos4 = new Vector2(4, 2);
                celula47 = true;
            }
            else
            {
                pos4 = new Vector2(1, 2);
                celula46 = true;
            }
        }
        else if (sorteioPosH4 == 47)
        {
            if (celula47 == true)
            {
                pos4 = new Vector2(7, 2);
                celula48 = true;
            }
            else
            {
                pos4 = new Vector2(4, 2);
                celula47 = true;
            }
        }
        else if (sorteioPosH4 == 48)
        {
            if (celula48 == true)
            {
                pos4 = new Vector2(10, 2);
                celula49 = true;
            }
            else
            {
                pos4 = new Vector2(7, 2);
                celula48 = true;
            }
        }
        else if (sorteioPosH4 == 49)
        {
            if (celula49 == true)
            {
                pos4 = new Vector2(13, 2);
                celula50 = true;
            }
            else
            {
                pos4 = new Vector2(10, 2);
                celula49 = true;
            }
        }
        else if (sorteioPosH4 == 50)
        {
            if (celula50 == true)
            {
                pos4 = new Vector2(-14, -1);
                celula51 = true;
            }
            else
            {
                pos4 = new Vector2(13, 2);
                celula50 = true;
            }
        }
        else if (sorteioPosH4 == 51)
        {
            if (celula51 == true)
            {
                pos4 = new Vector2(-11, -1);
                celula52 = true;
            }
            else
            {
                pos4 = new Vector2(-14, -1);
                celula51 = true;
            }
        }
        else if (sorteioPosH4 == 52)
        {
            if (celula52 == true)
            {
                pos4 = new Vector2(-8, -1);
                celula53 = true;
            }
            else
            {
                pos4 = new Vector2(-11, -1);
                celula52 = true;
            }
        }
        else if (sorteioPosH4 == 53)
        {
            if (celula53 == true)
            {
                pos4 = new Vector2(-5, -1);
                celula54 = true;
            }
            else
            {
                pos4 = new Vector2(-8, -1);
                celula53 = true;
            }
        }
        else if (sorteioPosH4 == 54)
        {
            if (celula54 == true)
            {
                pos4 = new Vector2(-2, -1);
                celula55 = true;
            }
            else
            {
                pos4 = new Vector2(-5, -1);
                celula54 = true;
            }
        }
        else if (sorteioPosH4 == 55)
        {
            if (celula55 == true)
            {
                pos4 = new Vector2(1, -1);
                celula56 = true;
            }
            else
            {
                pos4 = new Vector2(-2, -1);
                celula55 = true;
            }
        }
        else if (sorteioPosH4 == 56)
        {
            if (celula56 == true)
            {
                pos4 = new Vector2(4, -1);
                celula57 = true;
            }
            else
            {
                pos4 = new Vector2(1, -1);
                celula56 = true;
            }
        }
        else if (sorteioPosH4 == 57)
        {
            if (celula57 == true)
            {
                pos4 = new Vector2(7, -1);
                celula58 = true;
            }
            else
            {
                pos4 = new Vector2(4, -1);
                celula57 = true;
            }
        }
        else if (sorteioPosH4 == 58)
        {
            if (celula58 == true)
            {
                pos4 = new Vector2(10, -1);
                celula59 = true;
            }
            else
            {
                pos4 = new Vector2(7, -1);
                celula58 = true;
            }
        }
        else if (sorteioPosH4 == 59)
        {
            if (celula59 == true)
            {
                pos4 = new Vector2(-13, -1);
                celula60 = true;
            }
            else
            {
                pos4 = new Vector2(10, -1);
                celula59 = true;
            }
        }
        else if (sorteioPosH4 == 60)
        {
            if (celula60 == true)
            {
                pos4 = new Vector2(-14, -4);
                celula61 = true;
            }
            else
            {
                pos4 = new Vector2(-14, -1);
                celula60 = true;
            }
        }
        else if (sorteioPosH4 == 61)
        {
            if (celula61 == true)
            {
                pos4 = new Vector2(-11, -4);
                celula62 = true;
            }
            else
            {
                pos4 = new Vector2(-14, -4);
                celula61 = true;
            }
        }
        else if (sorteioPosH4 == 62)
        {
            if (celula62 == true)
            {
                pos4 = new Vector2(-8, -4);
                celula63 = true;
            }
            else
            {
                pos4 = new Vector2(-11, -4);
                celula62 = true;
            }
        }
        else if (sorteioPosH4 == 63)
        {
            if (celula63 == true)
            {
                pos4 = new Vector2(-5, -4);
                celula64 = true;
            }
            else
            {
                pos4 = new Vector2(-8, -4);
                celula63 = true;
            }
        }
        else if (sorteioPosH4 == 64)
        {
            if (celula64 == true)
            {
                pos4 = new Vector2(-2, -4);
                celula65 = true;
            }
            else
            {
                pos4 = new Vector2(-5, -4);
                celula64 = true;
            }
        }
        else if (sorteioPosH4 == 65)
        {
            if (celula65 == true)
            {
                pos4 = new Vector2(1, -4);
                celula66 = true;
            }
            else
            {
                pos4 = new Vector2(-2, -4);
                celula65 = true;
            }
        }
        else if (sorteioPosH4 == 66)
        {
            if (celula66 == true)
            {
                pos4 = new Vector2(4, -4);
                celula67 = true;
            }
            else
            {
                pos4 = new Vector2(1, -4);
                celula66 = true;
            }
        }
        else if (sorteioPosH4 == 67)
        {
            if (celula67 == true)
            {
                pos4 = new Vector2(7, -4);
                celula68 = true;
            }
            else
            {
                pos4 = new Vector2(4, -4);
                celula67 = true;
            }

        }
        else if (sorteioPosH4 == 68)
        {
            if (celula68 == true)
            {
                pos4 = new Vector2(10, -4);
                celula69 = true;
            }
            else
            {
                pos4 = new Vector2(7, -4);
                celula68 = true;
            }
        }
        else if (sorteioPosH4 == 69)
        {
            if (celula69 == true)
            {
                pos4 = new Vector2(13, -4);
                celula70 = true;
            }
            else
            {
                pos4 = new Vector2(10, -4);
                celula69 = true;
            }
        }
        else if (sorteioPosH4 == 70)
        {
            if (celula70 == true)
            {
                pos4 = new Vector2(-14, -7);
                celula71 = true;
            }
            else
            {
                pos4 = new Vector2(13, -4);
                celula70 = true;
            }
        }
        else if (sorteioPosH4 == 71)
        {
            if (celula71 == true)
            {
                pos4 = new Vector2(-11, -7);
                celula72 = true;
            }
            else
            {
                pos4 = new Vector2(-14, -7);
                celula71 = true;
            }
        }
        else if (sorteioPosH4 == 72)
        {
            if (celula72 == true)
            {
                pos4 = new Vector2(-8, -7);
                celula73 = true;
            }
            else
            {
                pos4 = new Vector2(-11, -7);
                celula72 = true;
            }
        }
        else if (sorteioPosH4 == 73)
        {
            if (celula73 == true)
            {
                pos4 = new Vector2(-5, -7);
                celula74 = true;
            }
            else
            {
                pos4 = new Vector2(-8, -7);
                celula73 = true;
            }
        }
        else if (sorteioPosH4 == 74)
        {
            if (celula74 == true)
            {
                pos4 = new Vector2(-2, -7);
                celula75 = true;
            }
            else
            {
                pos4 = new Vector2(-5, -7);
                celula74 = true;
            }
        }
        else if (sorteioPosH4 == 75)
        {
            if (celula75 == true)
            {
                pos4 = new Vector2(1, -7);
                celula76 = true;
            }
            else
            {
                pos4 = new Vector2(-2, -7);
                celula75 = true;
            }
        }
        else if (sorteioPosH4 == 76)
        {
            if (celula76 == true)
            {
                pos4 = new Vector2(4, -7);
                celula77 = true;
            }
            else
            {
                pos4 = new Vector2(1, -7);
                celula76 = true;
            }
        }
        else if (sorteioPosH4 == 77)
        {
            if (celula77 == true)
            {
                pos4 = new Vector2(7, -7);
                celula78 = true;
            }
            else
            {
                pos4 = new Vector2(4, -7);
                celula77 = true;
            }
        }
        else if (sorteioPosH4 == 78)
        {
            if (celula78 == true)
            {
                pos4 = new Vector2(10, -7);
                celula79 = true;
            }
            else
            {
                pos4 = new Vector2(7, -7);
                celula78 = true;
            }
        }
        else if (sorteioPosH4 == 79)
        {
            if (celula79 == true)
            {
                pos4 = new Vector2(13, -7);
                celula80 = true;
            }
            else
            {
                pos4 = new Vector2(10, -7);
                celula79 = true;
            }
        }
        else if (sorteioPosH4 == 80)
        {
            if (celula80 == true)
            {
                pos4 = new Vector2(-14, -10);
                celula81 = true;
            }
            else
            {
                pos4 = new Vector2(13, -7);
                celula80 = true;
            }
        }
        else if (sorteioPosH4 == 81)
        {
            if (celula81 == true)
            {
                pos4 = new Vector2(-11, -10);
                celula82 = true;
            }
            else
            {
                pos4 = new Vector2(-14, -10);
                celula81 = true;
            }
        }
        else if (sorteioPosH4 == 82)
        {
            if (celula82 == true)
            {
                pos4 = new Vector2(-8, -10);
                celula83 = true;
            }
            else
            {
                pos4 = new Vector2(-11, -10);
                celula82 = true;
            }
        }
        else if (sorteioPosH4 == 83)
        {
            if (celula83 == true)
            {
                pos4 = new Vector2(-5, -10);
                celula84 = true;
            }
            else
            {
                pos4 = new Vector2(-8, -10);
                celula83 = true;
            }
        }
        else if (sorteioPosH4 == 84)
        {
            if (celula84 == true)
            {
                pos4 = new Vector2(-2, -10);
                celula85 = true;
            }
            else
            {
                pos4 = new Vector2(-5, -10);
                celula84 = true;
            }
        }
        else if (sorteioPosH4 == 85)
        {
            if (celula85 == true)
            {
                pos4 = new Vector2(1, -10);
                celula86 = true;
            }
            else
            {
                pos4 = new Vector2(-2, -10);
                celula85 = true;
            }
        }
        else if (sorteioPosH4 == 86)
        {
            if (celula86 == true)
            {
                pos4 = new Vector2(4, -10);
                celula87 = true;
            }
            else
            {
                pos4 = new Vector2(1, -10);
                celula86 = true;
            }
        }
        else if (sorteioPosH4 == 87)
        {
            if (celula87 == true)
            {
                pos4 = new Vector2(7, -10);
                celula88 = true;
            }
            else
            {
                pos4 = new Vector2(4, -10);
                celula87 = true;
            }
        }
        else if (sorteioPosH4 == 88)
        {
            if (celula88 == true)
            {
                pos4 = new Vector2(10, -10);
                celula89 = true;
            }
            else
            {
                pos4 = new Vector2(7, -10);
                celula88 = true;
            }
        }
        else if (sorteioPosH4 == 89)
        {
            if (celula89 == true)
            {
                pos4 = new Vector2(13, -13);
                celula90 = true;
            }
            else
            {
                pos4 = new Vector2(10, -10);
                celula89 = true;
            }
        }
        else if (sorteioPosH4 == 90)
        {
            if (celula90 == true)
            {
                pos4 = new Vector2(-14, -13);
                celula91 = true;
            }
            else
            {
                pos4 = new Vector2(13, -13);
                celula90 = true;
            }
        }
        else if (sorteioPosH4 == 91)
        {
            if (celula91 == true)
            {
                pos4 = new Vector2(-11, -13);
                celula92 = true;
            }
            else
            {
                pos4 = new Vector2(-14, -13);
                celula91 = true;
            }
        }
        else if (sorteioPosH4 == 92)
        {
            if (celula92 == true)
            {
                pos4 = new Vector2(-8, -13);
                celula93 = true;
            }
            else
            {
                pos4 = new Vector2(-11, -13);
                celula92 = true;
            }
        }
        else if (sorteioPosH4 == 93)
        {
            if (celula93 == true)
            {
                pos4 = new Vector2(-5, -13);
                celula94 = true;
            }
            else
            {
                pos4 = new Vector2(-8, -13);
                celula93 = true;
            }
        }
        else if (sorteioPosH4 == 94)
        {
            if (celula94 == true)
            {
                pos4 = new Vector2(-2, -13);
                celula95 = true;
            }
            else
            {
                pos4 = new Vector2(-5, -13);
                celula94 = true;
            }
        }
        else if (sorteioPosH4 == 95)
        {
            if (celula95 == true)
            {
                pos4 = new Vector2(1, -13);
                celula96 = true;
            }
            else
            {
                pos4 = new Vector2(-2, -13);
                celula95 = true;
            }
        }
        else if (sorteioPosH4 == 96)
        {
            if (celula96 == true)
            {
                pos4 = new Vector2(4, -13);
                celula97 = true;
            }
            else
            {
                pos4 = new Vector2(1, -13);
                celula96 = true;
            }
        }
        else if (sorteioPosH4 == 97)
        {
            if (celula97 == true)
            {
                pos4 = new Vector2(7, -13);
                celula98 = true;
            }
            else
            {
                pos4 = new Vector2(4, -13);
                celula97 = true;
            }
        }
        else if (sorteioPosH4 == 98)
        {
            if (celula98 == true)
            {
                pos4 = new Vector2(10, -13);
                celula99 = true;
            }
            else
            {
                pos4 = new Vector2(7, -13);
                celula98 = true;
            }
        }
        else if (sorteioPosH4 == 99)
        {
            if (celula99 == true)
            {
                pos4 = new Vector2(13, -13);
                celula100 = true;
            }
            else
            {
                pos4 = new Vector2(10, -13);
                celula99 = true;
            }
        }
        else if (sorteioPosH4 == 100)
        {
            if (celula100 == true)
            {
                pos4 = new Vector2(-14, 14);
                celula1 = true;
            }
            else
            {
                pos4 = new Vector2(13, -13);
                celula100 = true;
            }
        }
        else
        {
            pos4 = new Vector2(13, -13);

        }

        sorteioPosH5 = Random.Range(1, 101);

        if (sorteioPosH5 == 1)
        {
            if (celula1 == true)
            {
                pos5 = new Vector2(-11, 14);
                celula2 = true;
            }
            else
            {
                pos5 = new Vector2(-14, 14);
                celula1 = true;

            }


        }
        else if (sorteioPosH5 == 2)
        {
            if (celula2 == true)
            {
                pos5 = new Vector2(-11, 14);
                celula3 = true;
            }
            else
            {
                pos5 = new Vector2(-8, 14);
                celula2 = true;

            }

        }
        else if (sorteioPosH5 == 3)
        {
            if (celula3 == true)
            {
                pos5 = new Vector2(-5, 14);
                celula4 = true;
            }
            else
            {
                pos5 = new Vector2(-8, 14);
                celula3 = true;

            }

        }
        else if (sorteioPosH5 == 4)
        {
            if (celula4 == true)
            {
                pos5 = new Vector2(-2, 14);
                celula5 = true;
            }
            else
            {
                pos5 = new Vector2(-5, 14);
                celula4 = true;
            }
        }
        else if (sorteioPosH5 == 5)
        {
            if (celula5 == true)
            {
                pos5 = new Vector2(1, 14);
                celula6 = true;
            }
            else
            {
                pos5 = new Vector2(-2, 14);
                celula5 = true;
            }
        }
        else if (sorteioPosH5 == 6)
        {
            if (celula6 == true)
            {
                pos5 = new Vector2(4, 14);
                celula7 = true;
            }
            else
            {
                pos5 = new Vector2(1, 14);
                celula6 = true;
            }
        }
        else if (sorteioPosH5 == 7)
        {
            if (celula7 == true)
            {
                pos5 = new Vector2(7, 14);
                celula8 = true;
            }
            else
            {
                pos5 = new Vector2(4, 14);
                celula7 = true;
            }
        }
        else if (sorteioPosH5 == 8)
        {
            if (celula8 == true)
            {
                pos5 = new Vector2(10, 14);
                celula9 = true;
            }
            else
            {
                pos5 = new Vector2(7, 14);
                celula8 = true;
            }
        }
        else if (sorteioPosH5 == 9)
        {
            if (celula9 == true)
            {
                pos5 = new Vector2(13, 14);
                celula10 = true;
            }
            else
            {
                pos5 = new Vector2(10, 14);
                celula9 = true;
            }
        }
        else if (sorteioPosH5 == 10)
        {
            if (celula10 == true)
            {
                pos5 = new Vector2(-14, 11);
                celula11 = true;
            }
            else
            {
                pos5 = new Vector2(13, 14);
                celula10 = true;
            }
        }
        else if (sorteioPosH5 == 11)
        {
            if (celula11 == true)
            {
                pos5 = new Vector2(-11, 11);
                celula12 = true;
            }
            else
            {
                pos5 = new Vector2(-14, 11);
                celula11 = true;
            }
        }
        else if (sorteioPosH5 == 12)
        {
            if (celula12 == true)
            {
                pos5 = new Vector2(-8, 11);
                celula13 = true;
            }
            else
            {
                pos5 = new Vector2(-11, 11);
                celula12 = true;
            }
        }
        else if (sorteioPosH5 == 13)
        {
            if (celula13 == true)
            {
                pos5 = new Vector2(-5, 11);
                celula14 = true;
            }
            else
            {
                pos5 = new Vector2(-8, 11);
                celula13 = true;
            }
        }
        else if (sorteioPosH5 == 14)
        {
            if (celula14 == true)
            {
                pos5 = new Vector2(-2, 11);
                celula15 = true;
            }
            else
            {

                pos5 = new Vector2(-5, 11);
                celula14 = true;
            }
        }
        else if (sorteioPosH5 == 15)
        {
            if (celula15 == true)
            {
                pos5 = new Vector2(1, 11);
                celula16 = true;
            }
            else
            {
                pos5 = new Vector2(-2, 11);
                celula15 = true;
            }
        }
        else if (sorteioPosH5 == 16)
        {
            if (celula16 == true)
            {
                pos5 = new Vector2(4, 11);
                celula17 = true;
            }
            else
            {
                pos5 = new Vector2(1, 11);
                celula16 = true;
            }
        }
        else if (sorteioPosH5 == 17)
        {
            if (celula17 == true)
            {
                pos5 = new Vector2(7, 11);
                celula18 = true;
            }
            else if (celula17 = false)
            {
                pos5 = new Vector2(4, 11);
                celula17 = true;
            }
            else
            {
                pos5 = new Vector2(4, 11);
                celula17 = true;
            }
        }
        else if (sorteioPosH5 == 18)
        {
            if (celula13 == true)
            {
                pos5 = new Vector2(10, 11);
                celula19 = true;
            }
            else
            {
                pos5 = new Vector2(7, 11);
                celula18 = true;
            }
        }
        else if (sorteioPosH5 == 19)
        {
            if (celula19 == true)
            {
                pos5 = new Vector2(13, 11);
                celula20 = true;
            }
            else
            {
                pos5 = new Vector2(10, 11);
                celula19 = true;
            }
        }
        else if (sorteioPosH5 == 20)
        {
            if (celula20 == true)
            {
                pos5 = new Vector2(-14, 8);
                celula21 = true;
            }
            else
            {
                pos5 = new Vector2(13, 11);
                celula20 = true;
            }
        }
        else if (sorteioPosH5 == 21)
        {
            if (celula21 == true)
            {
                pos5 = new Vector2(-11, 8);
                celula22 = true;
            }
            else
            {
                pos5 = new Vector2(-14, 8);
                celula21 = true;
            }
        }
        else if (sorteioPosH5 == 22)
        {
            if (celula22 == true)
            {
                pos5 = new Vector2(-8, 8);
                celula23 = true;
            }
            else
            {
                pos5 = new Vector2(-11, 8);
                celula22 = true;
            }
        }
        else if (sorteioPosH5 == 23)
        {
            if (celula23 == true)
            {
                pos5 = new Vector2(-5, 8);
                celula24 = true;
            }
            else
            {
                pos5 = new Vector2(-8, 8);
                celula23 = true;
            }
        }
        else if (sorteioPosH5 == 24)
        {
            if (celula24 == true)
            {
                pos5 = new Vector2(-2, 8);
                celula25 = true;
            }
            else
            {
                pos5 = new Vector2(-5, 8);
                celula24 = true;
            }
        }
        else if (sorteioPosH5 == 25)
        {
            if (celula25 == true)
            {
                pos5 = new Vector2(1, 8);
                celula26 = true;
            }
            else
            {
                pos5 = new Vector2(-2, 8);
                celula25 = true;
            }
        }
        else if (sorteioPosH5 == 26)
        {
            if (celula26 == true)
            {
                pos5 = new Vector2(4, 8);
                celula27 = true;
            }
            else
            {
                pos5 = new Vector2(1, 8);
                celula26 = true;
            }
        }
        else if (sorteioPosH5 == 27)
        {
            if (celula27 == true)
            {
                pos5 = new Vector2(7, 8);
                celula28 = true;
            }
            else
            {
                pos5 = new Vector2(4, 8);
                celula27 = true;
            }
        }
        else if (sorteioPosH5 == 28)
        {
            if (celula28 == true)
            {
                pos5 = new Vector2(10, 8);
                celula29 = true;
            }
            else
            {

                pos5 = new Vector2(7, 8);
                celula28 = true;
            }
        }
        else if (sorteioPosH5 == 29)
        {
            if (celula29 == true)
            {
                pos5 = new Vector2(13, 8);
                celula30 = true;
            }
            else
            {
                pos5 = new Vector2(10, 8);
                celula29 = true;
            }
        }
        else if (sorteioPosH5 == 30)
        {
            if (celula30 == true)
            {
                pos5 = new Vector2(-14, 5);
                celula31 = true;
            }
            else
            {
                pos5 = new Vector2(13, 8);
                celula30 = true;
            }
        }
        else if (sorteioPosH5 == 31)
        {
            if (celula31 == true)
            {
                pos5 = new Vector2(-11, 5);
                celula32 = true;
            }
            else
            {
                pos5 = new Vector2(-14, 5);
                celula31 = true;
            }
        }
        else if (sorteioPosH5 == 32)
        {
            if (celula32 == true)
            {
                pos5 = new Vector2(-8, 5);
                celula33 = true;
            }
            else
            {
                pos5 = new Vector2(-11, 5);
                celula32 = true;
            }
        }
        else if (sorteioPosH5 == 33)
        {
            if (celula33 == true)
            {
                pos5 = new Vector2(-5, 5);
                celula34 = true;
            }
            else
            {
                pos5 = new Vector2(-8, 5);
                celula33 = true;
            }
        }
        else if (sorteioPosH5 == 34)
        {
            if (celula34 == true)
            {
                pos5 = new Vector2(-2, 5);
                celula35 = true;
            }
            else
            {
                pos5 = new Vector2(-5, 5);
                celula34 = true;
            }
        }
        else if (sorteioPosH5 == 35)
        {
            if (celula35 == true)
            {
                pos5 = new Vector2(1, 5);
                celula36 = true;
            }
            else
            {
                pos5 = new Vector2(-2, 5);
                celula35 = true;
            }
        }
        else if (sorteioPosH5 == 36)
        {
            if (celula36 == true)
            {
                pos5 = new Vector2(4, 5);
                celula37 = true;
            }
            else
            {
                pos5 = new Vector2(1, 5);
                celula36 = true;
            }
        }
        else if (sorteioPosH5 == 37)
        {
            if (celula37 == true)
            {
                pos5 = new Vector2(7, 5);
                celula38 = true;
            }
            else
            {
                pos5 = new Vector2(4, 5);
                celula37 = true;
            }
        }
        else if (sorteioPosH5 == 38)
        {
            if (celula38 == true)
            {
                pos5 = new Vector2(10, 5);
                celula39 = true;
            }
            else
            {
                pos5 = new Vector2(7, 5);
                celula38 = true;
            }
        }
        else if (sorteioPosH5 == 39)
        {
            if (celula39 == true)
            {
                pos5 = new Vector2(13, 5);
                celula40 = true;
            }
            else
            {
                pos5 = new Vector2(10, 5);
                celula39 = true;
            }
        }
        else if (sorteioPosH5 == 40)
        {
            if (celula40 == true)
            {
                pos5 = new Vector2(-14, 2);
                celula41 = true;
            }
            else
            {
                pos5 = new Vector2(13, 5);
                celula40 = true;
            }
        }
        else if (sorteioPosH5 == 41)
        {
            if (celula41 == true)
            {
                pos5 = new Vector2(-11, 2);
                celula42 = true;
            }
            else
            {
                pos5 = new Vector2(-14, 2);
                celula41 = true;
            }
        }
        else if (sorteioPosH5 == 42)
        {
            if (celula42 == true)
            {
                pos5 = new Vector2(-8, 2);
                celula43 = true;
            }
            else
            {
                pos5 = new Vector2(-11, 2);
                celula42 = true;
            }
        }
        else if (sorteioPosH5 == 43)
        {
            if (celula43 == true)
            {
                pos5 = new Vector2(-5, 2);
                celula44 = true;
            }
            else
            {
                pos5 = new Vector2(-8, 2);
                celula43 = true;
            }
        }
        else if (sorteioPosH5 == 44)
        {
            if (celula44 == true)
            {
                pos5 = new Vector2(-2, 2);
                celula45 = true;
            }
            else
            {
                pos5 = new Vector2(-5, 2);
                celula44 = true;
            }
        }
        else if (sorteioPosH5 == 45)
        {
            if (celula45 == true)
            {
                pos5 = new Vector2(1, 2);
                celula46 = true;
            }
            else
            {
                pos5 = new Vector2(-2, 2);
                celula45 = true;
            }
        }
        else if (sorteioPosH5 == 46)
        {
            if (celula46 == true)
            {
                pos5 = new Vector2(4, 2);
                celula47 = true;
            }
            else
            {
                pos5 = new Vector2(1, 2);
                celula46 = true;
            }
        }
        else if (sorteioPosH5 == 47)
        {
            if (celula47 == true)
            {
                pos5 = new Vector2(7, 2);
                celula48 = true;
            }
            else
            {
                pos5 = new Vector2(4, 2);
                celula47 = true;
            }
        }
        else if (sorteioPosH5 == 48)
        {
            if (celula48 == true)
            {
                pos5 = new Vector2(10, 2);
                celula49 = true;
            }
            else
            {
                pos5 = new Vector2(7, 2);
                celula48 = true;
            }
        }
        else if (sorteioPosH5 == 49)
        {
            if (celula49 == true)
            {
                pos5 = new Vector2(13, 2);
                celula50 = true;
            }
            else
            {
                pos5 = new Vector2(10, 2);
                celula49 = true;
            }
        }
        else if (sorteioPosH5 == 50)
        {
            if (celula50 == true)
            {
                pos5 = new Vector2(-14, -1);
                celula51 = true;
            }
            else
            {
                pos5 = new Vector2(13, 2);
                celula50 = true;
            }
        }
        else if (sorteioPosH5 == 51)
        {
            if (celula51 == true)
            {
                pos5 = new Vector2(-11, -1);
                celula52 = true;
            }
            else
            {
                pos5 = new Vector2(-14, -1);
                celula51 = true;
            }
        }
        else if (sorteioPosH5 == 52)
        {
            if (celula52 == true)
            {
                pos5 = new Vector2(-8, -1);
                celula53 = true;
            }
            else
            {
                pos5 = new Vector2(-11, -1);
                celula52 = true;
            }
        }
        else if (sorteioPosH5 == 53)
        {
            if (celula53 == true)
            {
                pos5 = new Vector2(-5, -1);
                celula54 = true;
            }
            else
            {
                pos5 = new Vector2(-8, -1);
                celula53 = true;
            }
        }
        else if (sorteioPosH5 == 54)
        {
            if (celula54 == true)
            {
                pos5 = new Vector2(-2, -1);
                celula55 = true;
            }
            else
            {
                pos5 = new Vector2(-5, -1);
                celula54 = true;
            }
        }
        else if (sorteioPosH5 == 55)
        {
            if (celula55 == true)
            {
                pos5 = new Vector2(1, -1);
                celula56 = true;
            }
            else
            {
                pos5 = new Vector2(-2, -1);
                celula55 = true;
            }
        }
        else if (sorteioPosH5 == 56)
        {
            if (celula56 == true)
            {
                pos5 = new Vector2(4, -1);
                celula57 = true;
            }
            else
            {
                pos5 = new Vector2(1, -1);
                celula56 = true;
            }
        }
        else if (sorteioPosH5 == 57)
        {
            if (celula57 == true)
            {
                pos5 = new Vector2(7, -1);
                celula58 = true;
            }
            else
            {
                pos5 = new Vector2(4, -1);
                celula57 = true;
            }
        }
        else if (sorteioPosH5 == 58)
        {
            if (celula58 == true)
            {
                pos5 = new Vector2(10, -1);
                celula59 = true;
            }
            else
            {
                pos5 = new Vector2(7, -1);
                celula58 = true;
            }
        }
        else if (sorteioPosH5 == 59)
        {
            if (celula59 == true)
            {
                pos5 = new Vector2(-13, -1);
                celula60 = true;
            }
            else
            {
                pos5 = new Vector2(10, -1);
                celula59 = true;
            }
        }
        else if (sorteioPosH5 == 60)
        {
            if (celula60 == true)
            {
                pos5 = new Vector2(-14, -4);
                celula61 = true;
            }
            else
            {
                pos5 = new Vector2(-14, -1);
                celula60 = true;
            }
        }
        else if (sorteioPosH5 == 61)
        {
            if (celula61 == true)
            {
                pos5 = new Vector2(-11, -4);
                celula62 = true;
            }
            else
            {
                pos5 = new Vector2(-14, -4);
                celula61 = true;
            }
        }
        else if (sorteioPosH5 == 62)
        {
            if (celula62 == true)
            {
                pos5 = new Vector2(-8, -4);
                celula63 = true;
            }
            else
            {
                pos5 = new Vector2(-11, -4);
                celula62 = true;
            }
        }
        else if (sorteioPosH5 == 63)
        {
            if (celula63 == true)
            {
                pos5 = new Vector2(-5, -4);
                celula64 = true;
            }
            else
            {
                pos5 = new Vector2(-8, -4);
                celula63 = true;
            }
        }
        else if (sorteioPosH5 == 64)
        {
            if (celula64 == true)
            {
                pos5 = new Vector2(-2, -4);
                celula65 = true;
            }
            else
            {
                pos5 = new Vector2(-5, -4);
                celula64 = true;
            }
        }
        else if (sorteioPosH5 == 65)
        {
            if (celula65 == true)
            {
                pos5 = new Vector2(1, -4);
                celula66 = true;
            }
            else
            {
                pos5 = new Vector2(-2, -4);
                celula65 = true;
            }
        }
        else if (sorteioPosH5 == 66)
        {
            if (celula66 == true)
            {
                pos5 = new Vector2(4, -4);
                celula67 = true;
            }
            else
            {
                pos5 = new Vector2(1, -4);
                celula66 = true;
            }
        }
        else if (sorteioPosH5 == 67)
        {
            if (celula67 == true)
            {
                pos5 = new Vector2(7, -4);
                celula68 = true;
            }
            else
            {
                pos5 = new Vector2(4, -4);
                celula67 = true;
            }

        }
        else if (sorteioPosH5 == 68)
        {
            if (celula68 == true)
            {
                pos5 = new Vector2(10, -4);
                celula69 = true;
            }
            else
            {
                pos5 = new Vector2(7, -4);
                celula68 = true;
            }
        }
        else if (sorteioPosH5 == 69)
        {
            if (celula69 == true)
            {
                pos5 = new Vector2(13, -4);
                celula70 = true;
            }
            else
            {
                pos5 = new Vector2(10, -4);
                celula69 = true;
            }
        }
        else if (sorteioPosH5 == 70)
        {
            if (celula70 == true)
            {
                pos5 = new Vector2(-14, -7);
                celula71 = true;
            }
            else
            {
                pos5 = new Vector2(13, -4);
                celula70 = true;
            }
        }
        else if (sorteioPosH5 == 71)
        {
            if (celula71 == true)
            {
                pos5 = new Vector2(-11, -7);
                celula72 = true;
            }
            else
            {
                pos5 = new Vector2(-14, -7);
                celula71 = true;
            }
        }
        else if (sorteioPosH5 == 72)
        {
            if (celula72 == true)
            {
                pos5 = new Vector2(-8, -7);
                celula73 = true;
            }
            else
            {
                pos5 = new Vector2(-11, -7);
                celula72 = true;
            }
        }
        else if (sorteioPosH5 == 73)
        {
            if (celula73 == true)
            {
                pos5 = new Vector2(-5, -7);
                celula74 = true;
            }
            else
            {
                pos5 = new Vector2(-8, -7);
                celula73 = true;
            }
        }
        else if (sorteioPosH5 == 74)
        {
            if (celula74 == true)
            {
                pos5 = new Vector2(-2, -7);
                celula75 = true;
            }
            else
            {
                pos5 = new Vector2(-5, -7);
                celula74 = true;
            }
        }
        else if (sorteioPosH5 == 75)
        {
            if (celula75 == true)
            {
                pos5 = new Vector2(1, -7);
                celula76 = true;
            }
            else
            {
                pos5 = new Vector2(-2, -7);
                celula75 = true;
            }
        }
        else if (sorteioPosH5 == 76)
        {
            if (celula76 == true)
            {
                pos5 = new Vector2(4, -7);
                celula77 = true;
            }
            else
            {
                pos5 = new Vector2(1, -7);
                celula76 = true;
            }
        }
        else if (sorteioPosH5 == 77)
        {
            if (celula77 == true)
            {
                pos5 = new Vector2(7, -7);
                celula78 = true;
            }
            else
            {
                pos5 = new Vector2(4, -7);
                celula77 = true;
            }
        }
        else if (sorteioPosH5 == 78)
        {
            if (celula78 == true)
            {
                pos5 = new Vector2(10, -7);
                celula79 = true;
            }
            else
            {
                pos5 = new Vector2(7, -7);
                celula78 = true;
            }
        }
        else if (sorteioPosH5 == 79)
        {
            if (celula79 == true)
            {
                pos5 = new Vector2(13, -7);
                celula80 = true;
            }
            else
            {
                pos5 = new Vector2(10, -7);
                celula79 = true;
            }
        }
        else if (sorteioPosH5 == 80)
        {
            if (celula80 == true)
            {
                pos5 = new Vector2(-14, -10);
                celula81 = true;
            }
            else
            {
                pos5 = new Vector2(13, -7);
                celula80 = true;
            }
        }
        else if (sorteioPosH5 == 81)
        {
            if (celula81 == true)
            {
                pos5 = new Vector2(-11, -10);
                celula82 = true;
            }
            else
            {
                pos5 = new Vector2(-14, -10);
                celula81 = true;
            }
        }
        else if (sorteioPosH5 == 82)
        {
            if (celula82 == true)
            {
                pos5 = new Vector2(-8, -10);
                celula83 = true;
            }
            else
            {
                pos5 = new Vector2(-11, -10);
                celula82 = true;
            }
        }
        else if (sorteioPosH5 == 83)
        {
            if (celula83 == true)
            {
                pos5 = new Vector2(-5, -10);
                celula84 = true;
            }
            else
            {
                pos5 = new Vector2(-8, -10);
                celula83 = true;
            }
        }
        else if (sorteioPosH5 == 84)
        {
            if (celula84 == true)
            {
                pos5 = new Vector2(-2, -10);
                celula85 = true;
            }
            else
            {
                pos5 = new Vector2(-5, -10);
                celula84 = true;
            }
        }
        else if (sorteioPosH5 == 85)
        {
            if (celula85 == true)
            {
                pos5 = new Vector2(1, -10);
                celula86 = true;
            }
            else
            {
                pos5 = new Vector2(-2, -10);
                celula85 = true;
            }
        }
        else if (sorteioPosH5 == 86)
        {
            if (celula86 == true)
            {
                pos5 = new Vector2(4, -10);
                celula87 = true;
            }
            else
            {
                pos5 = new Vector2(1, -10);
                celula86 = true;
            }
        }
        else if (sorteioPosH5 == 87)
        {
            if (celula87 == true)
            {
                pos5 = new Vector2(7, -10);
                celula88 = true;
            }
            else
            {
                pos5 = new Vector2(4, -10);
                celula87 = true;
            }
        }
        else if (sorteioPosH5 == 88)
        {
            if (celula88 == true)
            {
                pos5 = new Vector2(10, -10);
                celula89 = true;
            }
            else
            {
                pos5 = new Vector2(7, -10);
                celula88 = true;
            }
        }
        else if (sorteioPosH5 == 89)
        {
            if (celula89 == true)
            {
                pos5 = new Vector2(13, -13);
                celula90 = true;
            }
            else
            {
                pos5 = new Vector2(10, -10);
                celula89 = true;
            }
        }
        else if (sorteioPosH5 == 90)
        {
            if (celula90 == true)
            {
                pos5 = new Vector2(-14, -13);
                celula91 = true;
            }
            else
            {
                pos5 = new Vector2(13, -13);
                celula90 = true;
            }
        }
        else if (sorteioPosH5 == 91)
        {
            if (celula91 == true)
            {
                pos5 = new Vector2(-11, -13);
                celula92 = true;
            }
            else
            {
                pos5 = new Vector2(-14, -13);
                celula91 = true;
            }
        }
        else if (sorteioPosH5 == 92)
        {
            if (celula92 == true)
            {
                pos5 = new Vector2(-8, -13);
                celula93 = true;
            }
            else
            {
                pos5 = new Vector2(-11, -13);
                celula92 = true;
            }
        }
        else if (sorteioPosH5 == 93)
        {
            if (celula93 == true)
            {
                pos5 = new Vector2(-5, -13);
                celula94 = true;
            }
            else
            {
                pos5 = new Vector2(-8, -13);
                celula93 = true;
            }
        }
        else if (sorteioPosH5 == 94)
        {
            if (celula94 == true)
            {
                pos5 = new Vector2(-2, -13);
                celula95 = true;
            }
            else
            {
                pos5 = new Vector2(-5, -13);
                celula94 = true;
            }
        }
        else if (sorteioPosH5 == 95)
        {
            if (celula95 == true)
            {
                pos5 = new Vector2(1, -13);
                celula96 = true;
            }
            else
            {
                pos5 = new Vector2(-2, -13);
                celula95 = true;
            }
        }
        else if (sorteioPosH5 == 96)
        {
            if (celula96 == true)
            {
                pos5 = new Vector2(4, -13);
                celula97 = true;
            }
            else
            {
                pos5 = new Vector2(1, -13);
                celula96 = true;
            }
        }
        else if (sorteioPosH5 == 97)
        {
            if (celula97 == true)
            {
                pos5 = new Vector2(7, -13);
                celula98 = true;
            }
            else
            {
                pos5 = new Vector2(4, -13);
                celula97 = true;
            }
        }
        else if (sorteioPosH5 == 98)
        {
            if (celula98 == true)
            {
                pos5 = new Vector2(10, -13);
                celula99 = true;
            }
            else
            {
                pos5 = new Vector2(7, -13);
                celula98 = true;
            }
        }
        else if (sorteioPosH5 == 99)
        {
            if (celula99 == true)
            {
                pos5 = new Vector2(13, -13);
                celula100 = true;
            }
            else
            {
                pos5 = new Vector2(10, -13);
                celula99 = true;
            }
        }
        else if (sorteioPosH5 == 100)
        {
            if (celula100 == true)
            {
                pos5 = new Vector2(-14, 14);
                celula1 = true;
            }
            else
            {
                pos5 = new Vector2(13, -13);
                celula100 = true;
            }
        }
        else
        {
            pos5 = new Vector2(13, -13);

        }

        //Sorteia a posição do Caçador
        sorteioPosHunter = Random.Range(1, 101);


        if (sorteioPosHunter == 1)
        {
            if (celula1 == true)
            {
                posHunter = new Vector2(-11, 14);
                celula2 = true;
            }
            else
            {
                posHunter = new Vector2(-14, 14);
                celula1 = true;

            }


        }
        else if (sorteioPosHunter == 2)
        {
            if (celula2 == true)
            {
                posHunter = new Vector2(-11, 14);
                celula3 = true;
            }
            else
            {
                posHunter = new Vector2(-8, 14);
                celula2 = true;

            }

        }
        else if (sorteioPosHunter == 3)
        {
            if (celula3 == true)
            {
                posHunter = new Vector2(-5, 14);
                celula4 = true;
            }
            else
            {
                posHunter = new Vector2(-8, 14);
                celula3 = true;

            }

        }
        else if (sorteioPosHunter == 4)
        {
            if (celula4 == true)
            {
                posHunter = new Vector2(-2, 14);
                celula5 = true;
            }
            else
            {
                posHunter = new Vector2(-5, 14);
                celula4 = true;
            }
        }
        else if (sorteioPosHunter == 5)
        {
            if (celula5 == true)
            {
                posHunter = new Vector2(1, 14);
                celula6 = true;
            }
            else
            {
                posHunter = new Vector2(-2, 14);
                celula5 = true;
            }
        }
        else if (sorteioPosHunter == 6)
        {
            if (celula6 == true)
            {
                posHunter = new Vector2(4, 14);
                celula7 = true;
            }
            else
            {
                posHunter = new Vector2(1, 14);
                celula6 = true;
            }
        }
        else if (sorteioPosHunter == 7)
        {
            if (celula7 == true)
            {
                posHunter = new Vector2(7, 14);
                celula8 = true;
            }
            else
            {
                posHunter = new Vector2(4, 14);
                celula7 = true;
            }
        }
        else if (sorteioPosHunter == 8)
        {
            if (celula8 == true)
            {
                posHunter = new Vector2(10, 14);
                celula9 = true;
            }
            else
            {
                posHunter = new Vector2(7, 14);
                celula8 = true;
            }
        }
        else if (sorteioPosHunter == 9)
        {
            if (celula9 == true)
            {
                posHunter = new Vector2(13, 14);
                celula10 = true;
            }
            else
            {
                posHunter = new Vector2(10, 14);
                celula9 = true;
            }
        }
        else if (sorteioPosHunter == 10)
        {
            if (celula10 == true)
            {
                posHunter = new Vector2(-14, 11);
                celula11 = true;
            }
            else
            {
                posHunter = new Vector2(13, 14);
                celula10 = true;
            }
        }
        else if (sorteioPosHunter == 11)
        {
            if (celula11 == true)
            {
                posHunter = new Vector2(-11, 11);
                celula12 = true;
            }
            else
            {
                posHunter = new Vector2(-14, 11);
                celula11 = true;
            }
        }
        else if (sorteioPosHunter == 12)
        {
            if (celula12 == true)
            {
                posHunter = new Vector2(-8, 11);
                celula13 = true;
            }
            else
            {
                posHunter = new Vector2(-11, 11);
                celula12 = true;
            }
        }
        else if (sorteioPosHunter == 13)
        {
            if (celula13 == true)
            {
                posHunter = new Vector2(-5, 11);
                celula14 = true;
            }
            else
            {
                posHunter = new Vector2(-8, 11);
                celula13 = true;
            }
        }
        else if (sorteioPosHunter == 14)
        {
            if (celula14 == true)
            {
                posHunter = new Vector2(-2, 11);
                celula15 = true;
            }
            else
            {

                posHunter = new Vector2(-5, 11);
                celula14 = true;
            }
        }
        else if (sorteioPosHunter == 15)
        {
            if (celula15 == true)
            {
                posHunter = new Vector2(1, 11);
                celula16 = true;
            }
            else
            {
                posHunter = new Vector2(-2, 11);
                celula15 = true;
            }
        }
        else if (sorteioPosHunter == 16)
        {
            if (celula16 == true)
            {
                posHunter = new Vector2(4, 11);
                celula17 = true;
            }
            else
            {
                posHunter = new Vector2(1, 11);
                celula16 = true;
            }
        }
        else if (sorteioPosHunter == 17)
        {
            if (celula17 == true)
            {
                posHunter = new Vector2(7, 11);
                celula18 = true;
            }
            else if (celula17 = false)
            {
                posHunter = new Vector2(4, 11);
                celula17 = true;
            }
            else
            {
                posHunter = new Vector2(4, 11);
                celula17 = true;
            }
        }
        else if (sorteioPosHunter == 18)
        {
            if (celula13 == true)
            {
                posHunter = new Vector2(10, 11);
                celula19 = true;
            }
            else
            {
                posHunter = new Vector2(7, 11);
                celula18 = true;
            }
        }
        else if (sorteioPosHunter == 19)
        {
            if (celula19 == true)
            {
                posHunter = new Vector2(13, 11);
                celula20 = true;
            }
            else
            {
                posHunter = new Vector2(10, 11);
                celula19 = true;
            }
        }
        else if (sorteioPosHunter == 20)
        {
            if (celula20 == true)
            {
                posHunter = new Vector2(-14, 8);
                celula21 = true;
            }
            else
            {
                posHunter = new Vector2(13, 11);
                celula20 = true;
            }
        }
        else if (sorteioPosHunter == 21)
        {
            if (celula21 == true)
            {
                posHunter = new Vector2(-11, 8);
                celula22 = true;
            }
            else
            {
                posHunter = new Vector2(-14, 8);
                celula21 = true;
            }
        }
        else if (sorteioPosHunter == 22)
        {
            if (celula22 == true)
            {
                posHunter = new Vector2(-8, 8);
                celula23 = true;
            }
            else
            {
                posHunter = new Vector2(-11, 8);
                celula22 = true;
            }
        }
        else if (sorteioPosHunter == 23)
        {
            if (celula23 == true)
            {
                posHunter = new Vector2(-5, 8);
                celula24 = true;
            }
            else
            {
                posHunter = new Vector2(-8, 8);
                celula23 = true;
            }
        }
        else if (sorteioPosHunter == 24)
        {
            if (celula24 == true)
            {
                posHunter = new Vector2(-2, 8);
                celula25 = true;
            }
            else
            {
                posHunter = new Vector2(-5, 8);
                celula24 = true;
            }
        }
        else if (sorteioPosHunter == 25)
        {
            if (celula25 == true)
            {
                posHunter = new Vector2(1, 8);
                celula26 = true;
            }
            else
            {
                posHunter = new Vector2(-2, 8);
                celula25 = true;
            }
        }
        else if (sorteioPosHunter == 26)
        {
            if (celula26 == true)
            {
                posHunter = new Vector2(4, 8);
                celula27 = true;
            }
            else
            {
                posHunter = new Vector2(1, 8);
                celula26 = true;
            }
        }
        else if (sorteioPosHunter == 27)
        {
            if (celula27 == true)
            {
                posHunter = new Vector2(7, 8);
                celula28 = true;
            }
            else
            {
                posHunter = new Vector2(4, 8);
                celula27 = true;
            }
        }
        else if (sorteioPosHunter == 28)
        {
            if (celula28 == true)
            {
                posHunter = new Vector2(10, 8);
                celula29 = true;
            }
            else
            {

                posHunter = new Vector2(7, 8);
                celula28 = true;
            }
        }
        else if (sorteioPosHunter == 29)
        {
            if (celula29 == true)
            {
                posHunter = new Vector2(13, 8);
                celula30 = true;
            }
            else
            {
                posHunter = new Vector2(10, 8);
                celula29 = true;
            }
        }
        else if (sorteioPosHunter == 30)
        {
            if (celula30 == true)
            {
                posHunter = new Vector2(-14, 5);
                celula31 = true;
            }
            else
            {
                posHunter = new Vector2(13, 8);
                celula30 = true;
            }
        }
        else if (sorteioPosHunter == 31)
        {
            if (celula31 == true)
            {
                posHunter = new Vector2(-11, 5);
                celula32 = true;
            }
            else
            {
                posHunter = new Vector2(-14, 5);
                celula31 = true;
            }
        }
        else if (sorteioPosHunter == 32)
        {
            if (celula32 == true)
            {
                posHunter = new Vector2(-8, 5);
                celula33 = true;
            }
            else
            {
                posHunter = new Vector2(-11, 5);
                celula32 = true;
            }
        }
        else if (sorteioPosHunter == 33)
        {
            if (celula33 == true)
            {
                posHunter = new Vector2(-5, 5);
                celula34 = true;
            }
            else
            {
                posHunter = new Vector2(-8, 5);
                celula33 = true;
            }
        }
        else if (sorteioPosHunter == 34)
        {
            if (celula34 == true)
            {
                posHunter = new Vector2(-2, 5);
                celula35 = true;
            }
            else
            {
                posHunter = new Vector2(-5, 5);
                celula34 = true;
            }
        }
        else if (sorteioPosHunter == 35)
        {
            if (celula35 == true)
            {
                posHunter = new Vector2(1, 5);
                celula36 = true;
            }
            else
            {
                posHunter = new Vector2(-2, 5);
                celula35 = true;
            }
        }
        else if (sorteioPosHunter == 36)
        {
            if (celula36 == true)
            {
                posHunter = new Vector2(4, 5);
                celula37 = true;
            }
            else
            {
                posHunter = new Vector2(1, 5);
                celula36 = true;
            }
        }
        else if (sorteioPosHunter == 37)
        {
            if (celula37 == true)
            {
                posHunter = new Vector2(7, 5);
                celula38 = true;
            }
            else
            {
                posHunter = new Vector2(4, 5);
                celula37 = true;
            }
        }
        else if (sorteioPosHunter == 38)
        {
            if (celula38 == true)
            {
                posHunter = new Vector2(10, 5);
                celula39 = true;
            }
            else
            {
                posHunter = new Vector2(7, 5);
                celula38 = true;
            }
        }
        else if (sorteioPosHunter == 39)
        {
            if (celula39 == true)
            {
                posHunter = new Vector2(13, 5);
                celula40 = true;
            }
            else
            {
                posHunter = new Vector2(10, 5);
                celula39 = true;
            }
        }
        else if (sorteioPosHunter == 40)
        {
            if (celula40 == true)
            {
                posHunter = new Vector2(-14, 2);
                celula41 = true;
            }
            else
            {
                posHunter = new Vector2(13, 5);
                celula40 = true;
            }
        }
        else if (sorteioPosHunter == 41)
        {
            if (celula41 == true)
            {
                posHunter = new Vector2(-11, 2);
                celula42 = true;
            }
            else
            {
                posHunter = new Vector2(-14, 2);
                celula41 = true;
            }
        }
        else if (sorteioPosHunter == 42)
        {
            if (celula42 == true)
            {
                posHunter = new Vector2(-8, 2);
                celula43 = true;
            }
            else
            {
                posHunter = new Vector2(-11, 2);
                celula42 = true;
            }
        }
        else if (sorteioPosHunter == 43)
        {
            if (celula43 == true)
            {
                posHunter = new Vector2(-5, 2);
                celula44 = true;
            }
            else
            {
                posHunter = new Vector2(-8, 2);
                celula43 = true;
            }
        }
        else if (sorteioPosHunter == 44)
        {
            if (celula44 == true)
            {
                posHunter = new Vector2(-2, 2);
                celula45 = true;
            }
            else
            {
                posHunter = new Vector2(-5, 2);
                celula44 = true;
            }
        }
        else if (sorteioPosHunter == 45)
        {
            if (celula45 == true)
            {
                posHunter = new Vector2(1, 2);
                celula46 = true;
            }
            else
            {
                posHunter = new Vector2(-2, 2);
                celula45 = true;
            }
        }
        else if (sorteioPosHunter == 46)
        {
            if (celula46 == true)
            {
                posHunter = new Vector2(4, 2);
                celula47 = true;
            }
            else
            {
                posHunter = new Vector2(1, 2);
                celula46 = true;
            }
        }
        else if (sorteioPosHunter == 47)
        {
            if (celula47 == true)
            {
                posHunter = new Vector2(7, 2);
                celula48 = true;
            }
            else
            {
                posHunter = new Vector2(4, 2);
                celula47 = true;
            }
        }
        else if (sorteioPosHunter == 48)
        {
            if (celula48 == true)
            {
                posHunter = new Vector2(10, 2);
                celula49 = true;
            }
            else
            {
                posHunter = new Vector2(7, 2);
                celula48 = true;
            }
        }
        else if (sorteioPosHunter == 49)
        {
            if (celula49 == true)
            {
                posHunter = new Vector2(13, 2);
                celula50 = true;
            }
            else
            {
                posHunter = new Vector2(10, 2);
                celula49 = true;
            }
        }
        else if (sorteioPosHunter == 50)
        {
            if (celula50 == true)
            {
                posHunter = new Vector2(-14, -1);
                celula51 = true;
            }
            else
            {
                posHunter = new Vector2(13, 2);
                celula50 = true;
            }
        }
        else if (sorteioPosHunter == 51)
        {
            if (celula51 == true)
            {
                posHunter = new Vector2(-11, -1);
                celula52 = true;
            }
            else
            {
                posHunter = new Vector2(-14, -1);
                celula51 = true;
            }
        }
        else if (sorteioPosHunter == 52)
        {
            if (celula52 == true)
            {
                posHunter = new Vector2(-8, -1);
                celula53 = true;
            }
            else
            {
                posHunter = new Vector2(-11, -1);
                celula52 = true;
            }
        }
        else if (sorteioPosHunter == 53)
        {
            if (celula53 == true)
            {
                posHunter = new Vector2(-5, -1);
                celula54 = true;
            }
            else
            {
                posHunter = new Vector2(-8, -1);
                celula53 = true;
            }
        }
        else if (sorteioPosHunter == 54)
        {
            if (celula54 == true)
            {
                posHunter = new Vector2(-2, -1);
                celula55 = true;
            }
            else
            {
                posHunter = new Vector2(-5, -1);
                celula54 = true;
            }
        }
        else if (sorteioPosHunter == 55)
        {
            if (celula55 == true)
            {
                posHunter = new Vector2(1, -1);
                celula56 = true;
            }
            else
            {
                posHunter = new Vector2(-2, -1);
                celula55 = true;
            }
        }
        else if (sorteioPosHunter == 56)
        {
            if (celula56 == true)
            {
                posHunter = new Vector2(4, -1);
                celula57 = true;
            }
            else
            {
                posHunter = new Vector2(1, -1);
                celula56 = true;
            }
        }
        else if (sorteioPosHunter == 57)
        {
            if (celula57 == true)
            {
                posHunter = new Vector2(7, -1);
                celula58 = true;
            }
            else
            {
                posHunter = new Vector2(4, -1);
                celula57 = true;
            }
        }
        else if (sorteioPosHunter == 58)
        {
            if (celula58 == true)
            {
                posHunter = new Vector2(10, -1);
                celula59 = true;
            }
            else
            {
                posHunter = new Vector2(7, -1);
                celula58 = true;
            }
        }
        else if (sorteioPosHunter == 59)
        {
            if (celula59 == true)
            {
                posHunter = new Vector2(-13, -1);
                celula60 = true;
            }
            else
            {
                posHunter = new Vector2(10, -1);
                celula59 = true;
            }
        }
        else if (sorteioPosHunter == 60)
        {
            if (celula60 == true)
            {
                posHunter = new Vector2(-14, -4);
                celula61 = true;
            }
            else
            {
                posHunter = new Vector2(-14, -1);
                celula60 = true;
            }
        }
        else if (sorteioPosHunter == 61)
        {
            if (celula61 == true)
            {
                posHunter = new Vector2(-11, -4);
                celula62 = true;
            }
            else
            {
                posHunter = new Vector2(-14, -4);
                celula61 = true;
            }
        }
        else if (sorteioPosHunter == 62)
        {
            if (celula62 == true)
            {
                posHunter = new Vector2(-8, -4);
                celula63 = true;
            }
            else
            {
                posHunter = new Vector2(-11, -4);
                celula62 = true;
            }
        }
        else if (sorteioPosHunter == 63)
        {
            if (celula63 == true)
            {
                posHunter = new Vector2(-5, -4);
                celula64 = true;
            }
            else
            {
                posHunter = new Vector2(-8, -4);
                celula63 = true;
            }
        }
        else if (sorteioPosHunter == 64)
        {
            if (celula64 == true)
            {
                posHunter = new Vector2(-2, -4);
                celula65 = true;
            }
            else
            {
                posHunter = new Vector2(-5, -4);
                celula64 = true;
            }
        }
        else if (sorteioPosHunter == 65)
        {
            if (celula65 == true)
            {
                posHunter = new Vector2(1, -4);
                celula66 = true;
            }
            else
            {
                posHunter = new Vector2(-2, -4);
                celula65 = true;
            }
        }
        else if (sorteioPosHunter == 66)
        {
            if (celula66 == true)
            {
                posHunter = new Vector2(4, -4);
                celula67 = true;
            }
            else
            {
                posHunter = new Vector2(1, -4);
                celula66 = true;
            }
        }
        else if (sorteioPosHunter == 67)
        {
            if (celula67 == true)
            {
                posHunter = new Vector2(7, -4);
                celula68 = true;
            }
            else
            {
                posHunter = new Vector2(4, -4);
                celula67 = true;
            }

        }
        else if (sorteioPosHunter == 68)
        {
            if (celula68 == true)
            {
                posHunter = new Vector2(10, -4);
                celula69 = true;
            }
            else
            {
                posHunter = new Vector2(7, -4);
                celula68 = true;
            }
        }
        else if (sorteioPosHunter == 69)
        {
            if (celula69 == true)
            {
                posHunter = new Vector2(13, -4);
                celula70 = true;
            }
            else
            {
                posHunter = new Vector2(10, -4);
                celula69 = true;
            }
        }
        else if (sorteioPosHunter == 70)
        {
            if (celula70 == true)
            {
                posHunter = new Vector2(-14, -7);
                celula71 = true;
            }
            else
            {
                posHunter = new Vector2(13, -4);
                celula70 = true;
            }
        }
        else if (sorteioPosHunter == 71)
        {
            if (celula71 == true)
            {
                posHunter = new Vector2(-11, -7);
                celula72 = true;
            }
            else
            {
                posHunter = new Vector2(-14, -7);
                celula71 = true;
            }
        }
        else if (sorteioPosHunter == 72)
        {
            if (celula72 == true)
            {
                posHunter = new Vector2(-8, -7);
                celula73 = true;
            }
            else
            {
                posHunter = new Vector2(-11, -7);
                celula72 = true;
            }
        }
        else if (sorteioPosHunter == 73)
        {
            if (celula73 == true)
            {
                posHunter = new Vector2(-5, -7);
                celula74 = true;
            }
            else
            {
                posHunter = new Vector2(-8, -7);
                celula73 = true;
            }
        }
        else if (sorteioPosHunter == 74)
        {
            if (celula74 == true)
            {
                posHunter = new Vector2(-2, -7);
                celula75 = true;
            }
            else
            {
                posHunter = new Vector2(-5, -7);
                celula74 = true;
            }
        }
        else if (sorteioPosHunter == 75)
        {
            if (celula75 == true)
            {
                posHunter = new Vector2(1, -7);
                celula76 = true;
            }
            else
            {
                posHunter = new Vector2(-2, -7);
                celula75 = true;
            }
        }
        else if (sorteioPosHunter == 76)
        {
            if (celula76 == true)
            {
                posHunter = new Vector2(4, -7);
                celula77 = true;
            }
            else
            {
                posHunter = new Vector2(1, -7);
                celula76 = true;
            }
        }
        else if (sorteioPosHunter == 77)
        {
            if (celula77 == true)
            {
                posHunter = new Vector2(7, -7);
                celula78 = true;
            }
            else
            {
                posHunter = new Vector2(4, -7);
                celula77 = true;
            }
        }
        else if (sorteioPosHunter == 78)
        {
            if (celula78 == true)
            {
                posHunter = new Vector2(10, -7);
                celula79 = true;
            }
            else
            {
                posHunter = new Vector2(7, -7);
                celula78 = true;
            }
        }
        else if (sorteioPosHunter == 79)
        {
            if (celula79 == true)
            {
                posHunter = new Vector2(13, -7);
                celula80 = true;
            }
            else
            {
                posHunter = new Vector2(10, -7);
                celula79 = true;
            }
        }
        else if (sorteioPosHunter == 80)
        {
            if (celula80 == true)
            {
                posHunter = new Vector2(-14, -10);
                celula81 = true;
            }
            else
            {
                posHunter = new Vector2(13, -7);
                celula80 = true;
            }
        }
        else if (sorteioPosHunter == 81)
        {
            if (celula81 == true)
            {
                posHunter = new Vector2(-11, -10);
                celula82 = true;
            }
            else
            {
                posHunter = new Vector2(-14, -10);
                celula81 = true;
            }
        }
        else if (sorteioPosHunter == 82)
        {
            if (celula82 == true)
            {
                posHunter = new Vector2(-8, -10);
                celula83 = true;
            }
            else
            {
                posHunter = new Vector2(-11, -10);
                celula82 = true;
            }
        }
        else if (sorteioPosHunter == 83)
        {
            if (celula83 == true)
            {
                posHunter = new Vector2(-5, -10);
                celula84 = true;
            }
            else
            {
                posHunter = new Vector2(-8, -10);
                celula83 = true;
            }
        }
        else if (sorteioPosHunter == 84)
        {
            if (celula84 == true)
            {
                posHunter = new Vector2(-2, -10);
                celula85 = true;
            }
            else
            {
                posHunter = new Vector2(-5, -10);
                celula84 = true;
            }
        }
        else if (sorteioPosHunter == 85)
        {
            if (celula85 == true)
            {
                posHunter = new Vector2(1, -10);
                celula86 = true;
            }
            else
            {
                posHunter = new Vector2(-2, -10);
                celula85 = true;
            }
        }
        else if (sorteioPosHunter == 86)
        {
            if (celula86 == true)
            {
                posHunter = new Vector2(4, -10);
                celula87 = true;
            }
            else
            {
                posHunter = new Vector2(1, -10);
                celula86 = true;
            }
        }
        else if (sorteioPosHunter == 87)
        {
            if (celula87 == true)
            {
                posHunter = new Vector2(7, -10);
                celula88 = true;
            }
            else
            {
                posHunter = new Vector2(4, -10);
                celula87 = true;
            }
        }
        else if (sorteioPosHunter == 88)
        {
            if (celula88 == true)
            {
                posHunter = new Vector2(10, -10);
                celula89 = true;
            }
            else
            {
                posHunter = new Vector2(7, -10);
                celula88 = true;
            }
        }
        else if (sorteioPosHunter == 89)
        {
            if (celula89 == true)
            {
                posHunter = new Vector2(13, -13);
                celula90 = true;
            }
            else
            {
                posHunter = new Vector2(10, -10);
                celula89 = true;
            }
        }
        else if (sorteioPosHunter == 90)
        {
            if (celula90 == true)
            {
                posHunter = new Vector2(-14, -13);
                celula91 = true;
            }
            else
            {
                posHunter = new Vector2(13, -13);
                celula90 = true;
            }
        }
        else if (sorteioPosHunter == 91)
        {
            if (celula91 == true)
            {
                posHunter = new Vector2(-11, -13);
                celula92 = true;
            }
            else
            {
                posHunter = new Vector2(-14, -13);
                celula91 = true;
            }
        }
        else if (sorteioPosHunter == 92)
        {
            if (celula92 == true)
            {
                posHunter = new Vector2(-8, -13);
                celula93 = true;
            }
            else
            {
                posHunter = new Vector2(-11, -13);
                celula92 = true;
            }
        }
        else if (sorteioPosHunter == 93)
        {
            if (celula93 == true)
            {
                posHunter = new Vector2(-5, -13);
                celula94 = true;
            }
            else
            {
                posHunter = new Vector2(-8, -13);
                celula93 = true;
            }
        }
        else if (sorteioPosHunter == 94)
        {
            if (celula94 == true)
            {
                posHunter = new Vector2(-2, -13);
                celula95 = true;
            }
            else
            {
                posHunter = new Vector2(-5, -13);
                celula94 = true;
            }
        }
        else if (sorteioPosHunter == 95)
        {
            if (celula95 == true)
            {
                posHunter = new Vector2(1, -13);
                celula96 = true;
            }
            else
            {
                posHunter = new Vector2(-2, -13);
                celula95 = true;
            }
        }
        else if (sorteioPosHunter == 96)
        {
            if (celula96 == true)
            {
                posHunter = new Vector2(4, -13);
                celula97 = true;
            }
            else
            {
                posHunter = new Vector2(1, -13);
                celula96 = true;
            }
        }
        else if (sorteioPosHunter == 97)
        {
            if (celula97 == true)
            {
                posHunter = new Vector2(7, -13);
                celula98 = true;
            }
            else
            {
                posHunter = new Vector2(4, -13);
                celula97 = true;
            }
        }
        else if (sorteioPosHunter == 98)
        {
            if (celula98 == true)
            {
                posHunter = new Vector2(10, -13);
                celula99 = true;
            }
            else
            {
                posHunter = new Vector2(7, -13);
                celula98 = true;
            }
        }
        else if (sorteioPosHunter == 99)
        {
            if (celula99 == true)
            {
                posHunter = new Vector2(13, -13);
                celula100 = true;
            }
            else
            {
                posHunter = new Vector2(10, -13);
                celula99 = true;
            }
        }
        else if (sorteioPosHunter == 100)
        {
            if (celula100 == true)
            {
                posHunter = new Vector2(-14, 14);
                celula1 = true;
            }
            else
            {
                posHunter = new Vector2(13, -13);
                celula100 = true;
            }
        }
        else
        {
            posHunter = new Vector2(13, -13);

        }

        Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        Instantiate(toSpawnH2, pos2, toSpawnH2.transform.rotation);
        Instantiate(toSpawnH3, pos3, toSpawnH3.transform.rotation);
        Instantiate(toSpawnH4, pos4, toSpawnH4.transform.rotation);
        Instantiate(toSpawnH5, pos5, toSpawnH5.transform.rotation);
        Instantiate(toSpawnHunter, posHunter, toSpawnHunter.transform.rotation);
       
        posAtual1 = pos;
        posAtual2 = pos2;
        posAtual3 = pos3;
        posAtual4 = pos4;
        posAtual5 = pos5;
        posAtualHunter = posHunter;

    }
    public void Inicio()
    {
        turno ++;
        jogo();
    }
    public void jogo()
    {
        Destruir();
        Vector2 pos1;
        Vector2 pos2;
        Vector2 pos3;
        Vector2 pos4;
        Vector2 pos5;
        Vector2 posHunter;
        pos1 = posAtual1;
        pos2 = posAtual2;
        pos3 = posAtual3;
        pos4 = posAtual4;
        pos5 = posAtual5;
        posHunter = posAtualHunter;
        int sorteioH1;
        int sorteioH2;
        int sorteioH3;
        int sorteioH4;
        int sorteioH5;
        int sorteioHunter;

       
        bool H1atacado;
        bool H2atacado; 
        bool H3atacado; 
        bool H4atacado; 
        bool H5atacado;

        if (Colisao.H1attack==true)
        {
            H1atacado = true;
        }
        else
        {
            H1atacado = false;
           
        }
        if (Colisao.H2attack == true)
        {
            H2atacado = true;
           
        }
        else
        {
            H2atacado = false;
        }

        if (Colisao.H3attack == true)
        {
            H3atacado = true;
        }
        else
        {
          H3atacado = false;
        }

        if (Colisao.H4attack == true)
        {
            H4atacado = true;
           
        }
        else
        {
            H4atacado = false;
        }
        if (Colisao.H5attack == true)
        {
            H5atacado = true;
            
        }
        else
        {
            H5atacado = false;

        }

            if (turno > 0)
        {
            
            
            sorteioH1 = Random.Range(1, 8);
            if (sorteioH1 == 1 )
            {
               
                pos1 = posAtual1+ new Vector2(3,0);
              
                  

            }
            else if(sorteioH1==2)
            {
               
                    pos1 = posAtual1 - new Vector2(3, 0);
                    
               
            }
            else if (sorteioH1 == 3)
            {
                
                    pos1 = posAtual1 - new Vector2(0, 3);
                    
                
            }
            else if (sorteioH1 == 4)
            {
               
                    pos1 = posAtual1 + new Vector2(0, 3);
                
            }
            else if (sorteioH1 == 5)
            {
                
                    pos1 = posAtual1 + new Vector2(3, 3);
                    
               
            }
            else if (sorteioH1 == 6)
            {
                
                    pos1 = posAtual1 + new Vector2(3, -3);
                
            }
            else if (sorteioH1 == 7)
            {
               
                    pos1 = posAtual1 + new Vector2(-3, 3);
               
            }
            else
            {
                
                
                    pos1 = posAtual1 - new Vector2(3, 3);
                   
                    /*osAtual1 = pos1;*/
                 
            }
            
            if (pos1.y > 15)
            {
                pos1 = pos1 = posAtual1 - new Vector2(0, 3);
            }
            if (pos1.x > 15)
            {
                pos1 = pos1 = posAtual1 - new Vector2(3, 0);
            }
            if (pos1.y < -15)
            {
                pos1 = pos1 = posAtual1 + new Vector2(0, 3);
            }
            if (pos1.x < -15)
            {
                pos1  = posAtual1 + new Vector2(3, 0);
            }

            posAtual1 = pos1;

                sorteioH2 = Random.Range(1, 8);
            if (sorteioH2 == 1)
            {
                
                    pos2 = posAtual2 + new Vector2(3, 0);
                

            }
            else if (sorteioH2 == 2)
            {
                
                    pos2 = posAtual2 - new Vector2(3, 0);
                
                
            }
            else if (sorteioH2 == 3)
            {
               
                    pos2 = posAtual2 - new Vector2(0, 3);
                
            }
            else if (sorteioH2 == 4)
            {
                
                    pos2 = posAtual2 + new Vector2(0, 3);
                
            }
            else if (sorteioH2 == 5)
            {
                
                    pos2 = posAtual2 + new Vector2(3, 3);
                
            }
            else if (sorteioH2 == 6)
            {
               
                    pos2 = posAtual2 + new Vector2(3, -3);
                
            }
            else if (sorteioH2 == 7)
            {
                
                    pos2 = posAtual2 + new Vector2(-3, 3);
                
            }
            else
            {
                
                    pos2 = posAtual2 - new Vector2(3, 3);
                
                /*osAtual1 = pos2;*/
            }
            if (pos2.y > 15)
            {
                pos2 = pos2 = posAtual2 - new Vector2(0, 3);
            }
            if (pos2.x > 15)
            {
                pos2 = pos2 = posAtual2 - new Vector2(3, 0);
            }
            if (pos2.y < -15)
            {
                pos2 = pos2 = posAtual2 + new Vector2(0, 3);
            }
            if (pos2.x < -15)
            {
                pos2 = posAtual2 + new Vector2(3, 0);
            }

            posAtual2 = pos2;

            sorteioH3 = Random.Range(1, 8);
            if (sorteioH3 == 1)
            {
                
                    pos3 = posAtual3 + new Vector2(3, 0);

            }
            else if (sorteioH3 == 2)
            {
                    pos3 = posAtual3 - new Vector2(3, 0);
               
            }
            else if (sorteioH3 == 3)
            {
                
                    pos3 = posAtual3 - new Vector2(0, 3);
                
            }
            else if (sorteioH3 == 4)
            {
                
                    pos3 = posAtual3 + new Vector2(0, 3);
                
            }
            else if (sorteioH3 == 5)
            {
                
                    pos3 = posAtual3 + new Vector2(3, 3);
               
            }
            else if (sorteioH3 == 6)
            {
               
                    pos3 = posAtual3 + new Vector2(3, -3);
                
            }
            else if (sorteioH3 == 7)
            {
                
                    pos3 = posAtual3 + new Vector2(-3, 3);
                
            }
            else
            {
                
                    pos3 = posAtual3 - new Vector2(3, 3);
                    
                
            }
            if (pos3.y > 15)
            {
                pos3 = pos3 = posAtual3 - new Vector2(0, 3);
            }
            if (pos3.x > 15)
            {
                pos3 = pos3 = posAtual3 - new Vector2(3, 0);
            }
            if (pos3.y < -15)
            {
                pos3 = pos3 = posAtual3 + new Vector2(0, 3);
            }
            if (pos3.x < -15)
            {
                pos3 = posAtual3 + new Vector2(3, 0);
            }

            posAtual3 = pos3;

            sorteioH4 = Random.Range(1, 8);
            if (sorteioH4 == 1)
            {
                
                    pos4 = posAtual4 + new Vector2(3, 0);
               

            }
            else if (sorteioH4 == 2)
            {
                
                    pos4 = posAtual4 - new Vector2(3, 0);
                
            }
            else if (sorteioH4 == 3)
            {
                
                    pos4 = posAtual4 - new Vector2(0, 3);
               
            }
            else if (sorteioH4 == 4)
            {
                
                    pos4 = posAtual4 + new Vector2(0, 3);
                
            }
            else if (sorteioH4 == 5)
            {
                
                    pos4 = posAtual4 + new Vector2(3, 3);
                
            }
            else if (sorteioH4 == 6)
            {
                
                    pos4 = posAtual4 + new Vector2(3, -3);
          
            }
            else if (sorteioH4 == 7)
            {
                
                    pos4 = posAtual4 + new Vector2(-3, 3);
                
            }
            else
            {
                
                    pos4 = posAtual4 - new Vector2(3, 3);
               
                /*osAtual1 = pos4;*/
            }
            if (pos4.y > 15)
            {
                pos4 = pos4 = posAtual4 - new Vector2(0, 3);
            }
            if (pos4.x > 15)
            {
                pos4 = pos4 = posAtual4 - new Vector2(3, 0);
            }
            if (pos4.y < -15)
            {
                pos4 = pos4 = posAtual4 + new Vector2(0, 3);
            }
            if (pos4.x < -15)
            {
                pos4 = posAtual4 + new Vector2(3, 0);
            }

            posAtual4 = pos4;

            sorteioH5 = Random.Range(1, 8);
            if (sorteioH5 == 1)
            {
                
                    pos5 = posAtual5 + new Vector2(3, 0);
           

            }
            else if (sorteioH5 == 2)
            {
                
                    pos5 = posAtual5 - new Vector2(3, 0);
                
            }
            else if (sorteioH5 == 3)
            {
                
                    pos5 = posAtual5 - new Vector2(0, 3);
                
            }
            else if (sorteioH5 == 4)
            {
               
                    pos5 = posAtual5 + new Vector2(0, 3); pos5 = posAtual5 - new Vector2(0, 3);
                
            }
            else if (sorteioH5 == 5)
            {
                
                    pos5 = posAtual5 + new Vector2(3, 3);
                
            }
            else if (sorteioH5 == 6)
            {
                

                    pos5 = posAtual5 + new Vector2(3, -3);
                


            }
            else if (sorteioH5 == 7)
            {
                
                    pos5 = posAtual5 + new Vector2(-3, 3);
               
            }
            else
            {
               
                    pos5 = posAtual5 - new Vector2(3, 3);
                
                /*osAtual1 = pos5;*/
            }
            if (pos5.y > 15)
            {
                pos5 = pos5 = posAtual5 - new Vector2(0, 3);
            }
            if (pos5.x > 15)
            {
                pos5 = pos5 = posAtual5 - new Vector2(3, 0);
            }
            if (pos5.y < -15)
            {
                pos5 = pos5 = posAtual5 + new Vector2(0, 3);
            }
            if (pos5.x < -15)
            {
                pos5 = posAtual5 + new Vector2(3, 0);
            }

            posAtual5 = pos5;
            if(H1atacado==false)
            {
                 Instantiate(toSpawn, pos1, toSpawn.transform.rotation);
            }
            if (H1atacado == true)
            {

            }

            if (H2atacado==false)
            {
                Instantiate(toSpawnH2, pos2, toSpawnH2.transform.rotation);
            }
            if(H2atacado==true)
            {

            }
            if(H3atacado==false)
            {
                Instantiate(toSpawnH3, pos3, toSpawnH3.transform.rotation);
            }
            if(H3atacado==true)
            {

            }
            if(H4atacado==false)
            {
               Instantiate(toSpawnH4, pos4, toSpawnH4.transform.rotation);
            }
            if(H4atacado==false)
            { }
            if(H5atacado==false)
            {
                Instantiate(toSpawnH5, pos5, toSpawnH5.transform.rotation);

            }
            if(H5atacado==true)
            { }
            else { }


            if (H1atacado == true && H2atacado == true && H3atacado==true && H4atacado==true && H5atacado==true)
            {
                Debug.Log("Acabou a simulação");
                Application.Quit();
                
            }

            

            //Instantiate(toSpawnHunter, posHunter, toSpawnHunter.transform.rotation);

            sorteioHunter = Random.Range(1, 8);
            if(sorteioHunter==1)
            {
                posHunter = posAtualHunter - new Vector2(3, 0);
            }
            if(sorteioHunter==2)
            {
                posHunter = posAtualHunter + new Vector2(3, 0);
            }
            if(sorteioHunter==3)
            {
                posHunter = posAtualHunter + new Vector2(0, 3);
            }
            if(sorteioHunter==4)
            {
                posHunter = posAtualHunter + new Vector2(-3, 3);
            }
            if (sorteioHunter == 5)
            {
                posHunter = posAtualHunter + new Vector2(3, 3);
            }
            else if (sorteioHunter == 6)
            {


                posHunter = posAtualHunter + new Vector2(3, -3);



            }
            else if (sorteioHunter == 7)
            {

                posHunter = posAtualHunter + new Vector2(-3, 3);

            }
            else
            {
                posHunter = posAtualHunter - new Vector2(3, 3);
            }
               
            if (posHunter.y > 15)
            {
                posHunter = posAtualHunter - new Vector2(0, 3);
            }
            if (posHunter.x > 15)
            {
                posHunter = posAtualHunter - new Vector2(3, 0);
            }
            if (posHunter.y < -15)
            {
                posHunter = posAtualHunter + new Vector2(0, 3);
            }
            if (posHunter.x < -15)
            {
                posHunter = posAtualHunter + new Vector2(3, 0);
            }

            posAtualHunter = posHunter;
           
            Instantiate(toSpawnHunter, posHunter, toSpawnHunter.transform.rotation);

            Debug.Log(H1atacado);
        }
    }
  

 
    private void Destruir()
    {
        foreach(GameObject o in GameObject.FindGameObjectsWithTag("CacaSpawn"))
        {
            Destroy(o);
        }
       
    }
}
