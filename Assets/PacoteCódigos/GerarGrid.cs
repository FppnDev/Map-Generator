using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerarGrid : MonoBehaviour
{
    //propriedades do Cubo"TILE"
    private float cuboX;
    private float cuboY;
    private float cuboZ;
    private float posX;
    private float posY;
    private float posZ;
    GameObject cubocriado;
    GameObject prefabcriado;
    public int randonIndexPrefab;
    public Material gramaMaterial;
    public Renderer rend;
    //propriedades da criação do mapa
    
    private  int colunaGridX;
    private int linhaGridZ;
    private int valorx;
    private int valorz;
    private int[,] grid;
    private int index;
    private int contadorArray;
    public bool MapaCriado;
    // Propriedades dos PreFabs
    public List<Vector3> posPrefab = new List<Vector3>();
    public int quantidadeDePreafabs;

    // CLASSES IMPORTADAS
    private Models3D models3D;
    public GameObject playerMovementScript;

    private void Awake()
    {
        rend = GameObject.Find("CuboReferencia").GetComponent<Renderer>();
        playerMovementScript = GameObject.Find("FirstPersonPlayer");
    }
    private void Start()
    {
        
        grid = new int[colunaGridX, linhaGridZ];
        GerarMapa(getSetColunaGridX,getSetlinhaGridZ);
        models3D = GetComponent<Models3D>();
        MapaCriado = false;
        PosPrefabDefaut();

        
    }

    public void PosPrefabDefaut()
    {
        for (int i = 0; i < quantidadeDePreafabs; i++)
        {
            index = Random.Range(0, 2);
            int x = Random.Range(0, 50);
            int z = Random.Range(0, 50);
            posPrefab.Add(new Vector3(x, 0, z));
            models3D.prefabModels(prefabcriado, index, x, 0, z);
            
        }
        
    }

   
    public void GerarMapa(int colunaX,int linhaZ)
    {
        this.colunaGridX = colunaX;
        this.linhaGridZ = linhaZ;

        for (int valorx = 0; valorx < colunaGridX; valorx++)
        {
            for (int valorz = 0; valorz < linhaGridZ; valorz++)
            {
                
                CriarCubo(1f, 1f, 1f, valorx, 0, valorz);
                
            }
        }

       MapaCriado = true;

       if(MapaCriado == true)
        {
          //  playerMovementScript.SetActive(true);
        }
        else
        {
            
        }

    }


    public GameObject CriarCubo(float cuboX, float cuboY, float cuboZ, float posx, float posy, float posz) // Construtor de Blocos de Terreno 
    {
        cubocriado = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubocriado.GetComponent<Renderer>().sharedMaterial = gramaMaterial;
        cubocriado.transform.localScale = new Vector3(cuboX, cuboY, cuboZ);
        cubocriado.transform.position = new Vector3(posx, posy, posz);
        cubocriado.layer = LayerMask.NameToLayer("Ground");

        return cubocriado;
    }


    // CRIAÇÃO DE UM CUBO E MANIPULAÇÃO DO CUBO

    public void PropriedadesDoCuboSize(float cubox,float cuboy, float cuboz)
    {

        this.cuboX = cubox;
        this.cuboY = cuboy;
        this.cuboZ = cuboz;
    }

    public void PropriedadesDoCuboPos(float posx, float posy, float posz)
    {
        this.posX = posx;
        this.posY = posy;
        this.posZ = posz;
    }

    public int getSetColunaGridX
    {
        get { return colunaGridX; }
        set { colunaGridX = value; }
    }

    public int getSetlinhaGridZ
    {
        get { return linhaGridZ; }
        set { linhaGridZ = value; }
    }

    public float getSetPosX
    {
        get { return posX; }
        set { posX = value; }
    }

    public float getSetPosY
    {
        get { return posY; }
        set { posY = value; }
    }

    public float getSetPosZ
    {
        get { return posZ; }
        set { posZ = value; }
    }

    public float getSetCuboX
    {
        get { return cuboX; }
        set { cuboX = value; }
    }

    public float  getSetCuboY
    {
        get { return cuboY; }
        set { cuboY = value; }
    }

    public float getSetCuboZ
    {
        get { return cuboZ; }
        set { cuboZ = value; }
    }

    

}






    

