using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UiView : MonoBehaviour
{
    // DADOS DO CRIACAO DE MAPA 
    public GerarGrid gerargrid;
    public Text componenteTextoX;
    public Text componenteTextoZ;
    public string StringEmInteiroParaConverterX;
    public string StringEmInteiroParaConverterZ;
    public int valorConvertidoX;
    public int valorConvertidoZ;
    // ELEMENTOS DO UI
    public GameObject Textt;
    public GameObject inputX;
    public GameObject inputZ;
    public GameObject BttCriarmapa;
    public bool gatilhoUI;

    private void Awake()
    {
        gerargrid = GetComponent<GerarGrid>();
        componenteTextoX = GameObject.Find("TextValorX").GetComponent<Text>();
        componenteTextoZ = GameObject.Find("TextValorZ").GetComponent<Text>();
        Textt = GameObject.Find("Texto");
        inputX = GameObject.Find("InputFieldValorX");
        inputZ = GameObject.Find("InputFieldValorZ");
        BttCriarmapa = GameObject.Find("Button");
        gatilhoUI = true;


    }

    private void Update()
    {
        Gatilho();
    }

    public void BttGerarMapa()
    {
        // Conversão de "STRING PARA INT" + função do botão gerar mapa  
        StringEmInteiroParaConverterX = componenteTextoX.text;
        valorConvertidoX = int.Parse(componenteTextoX.text);
        gerargrid.getSetColunaGridX = valorConvertidoX;

        StringEmInteiroParaConverterZ = componenteTextoZ.text;
        valorConvertidoZ = int.Parse(componenteTextoZ.text);
        gerargrid.getSetlinhaGridZ = valorConvertidoZ;

        gerargrid.GerarMapa(valorConvertidoX, valorConvertidoZ);

        // Gatilhos UI
        gatilhoUI = false;

    }

    public void Gatilho()
    {
        if (gatilhoUI == true) {

            Textt.SetActive(true);
            inputX.SetActive(true);
            inputZ.SetActive(true);
            BttCriarmapa.SetActive(true);
            Cursor.lockState = CursorLockMode.None;

        }
        else
        {
            Textt.SetActive(false);
            inputX.SetActive(false);
            inputZ.SetActive(false);
            BttCriarmapa.SetActive(false);

            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public int getSetValorConvertidoX
    {
        get { return valorConvertidoX; }
        set { valorConvertidoX = value; }
    }






}
