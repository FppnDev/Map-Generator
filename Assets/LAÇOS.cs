using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAÇOS : MonoBehaviour
{

    public int[,] TABULEIRO;
    public int linha;
    public int coluna;
    void Start()
    {

        linha = 5;
        coluna = 5;

        TABULEIRO = new int[linha, coluna];


        for (int linha = 0; linha < TABULEIRO.GetLength(0);  linha++){
            for (int coluna = 0; coluna < TABULEIRO.GetLength(0); coluna++)   // linha vai ser 0 então para ele acrescentar linha 1, vai ter que passar por todas as colunas antes
                                                                              // linha 0 [ coluna 1,2,3,4]
                                                                              // linha 1 [ coluna 1,2,3,4]
                                                                              // linha 2 [ coluna 1,2,3,4]
            {

                print(TABULEIRO);
            }



        }







    }

   
}
