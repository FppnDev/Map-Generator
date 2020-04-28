using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Models3D : MonoBehaviour
{
    public List<GameObject> prefabsList = new List<GameObject>();
    public GameObject prefabPedra1;
    public GameObject prefabArvare1;
    public GameObject prefabArvere2;
    
    // Elementos da classe prefabModels
    private GameObject prefabGO;
    public int indexLista;
    public float prefabPosX;
    public float prefabPosY;
    public float prefabPosZ;
    public Vector3 PosDoPrefab;
    // Controle De Mapa
    public int totalArvores;
    public int contadorArvores;
    public int test;
    // importaçoes
    public GerarGrid gerarGrid;
    public UiView uiView;
    public int testx;
    public int testz;
    private void Awake()
    {
        gerarGrid = GetComponent<GerarGrid>();
        uiView = GetComponent<UiView>();

        prefabsList.Add(prefabArvare1);
        prefabsList.Add(prefabPedra1);
        
    }

    private void Start()
    {
     
        totalArvores = 2;

        
    }

  
    private void Update()
    {
        
    }

    public GameObject prefabModels(GameObject prefabgo,int indexlista,float prefabposx,float prefabposy,float prefabposz)
    {
        prefabGO = prefabgo;
        indexLista = indexlista;
        prefabPosX = prefabposx;
        prefabPosY = prefabposy;
        prefabPosZ = prefabposz;


        Instantiate(prefabsList[indexLista], new Vector3(prefabposx, prefabposy, prefabposz), Quaternion.Euler(-90, 0, 0));
 
     
        
        return prefabgo;

    }

    public float getSetprefabPosX
    {
        get { return prefabPosX; }
        set { prefabPosX = value; }
    }

    public float getSetprefabPosY
    {
        get { return prefabPosY; }
        set { prefabPosY = value; }
    }

    public float getSetprefabPosZ
    {
        get { return prefabPosZ; }
        set { prefabPosZ = value; }
    }

    public int getSetindexLista
    {
        get { return indexLista; }
        set { indexLista = value; }
    }

}





