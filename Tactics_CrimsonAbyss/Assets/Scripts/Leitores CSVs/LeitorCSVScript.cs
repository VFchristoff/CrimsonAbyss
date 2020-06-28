using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeitorCSVScript : MonoBehaviour {

    // Use this for initialization
    TextAsset le;
    public GameObject inimigo;
    public GameObject listaDeInimigos;

    void Start() {

        le = Resources.Load<TextAsset>("inimigosLevel1");

        if (le == null)
        {
            Debug.Log("não leu arquivo");
        }
        else {
            Debug.Log("leu arquivo de csv");
        }


        string[] data = le.text.Split('\n');
        //começa pelo 1 pq ele avisa quais são meus parametros;
        for (int i = 1; i < data.Length; i++) {
            //Debug.Log(data[i]);
            string[] valor = data[i].Split(',');

            inimigo.GetComponent<InimigoBehaviour>().ID = int.Parse(valor[0]);// ID
            inimigo.GetComponent<InimigoBehaviour>().classe = valor[1];// classe
            inimigo.GetComponent<InimigoBehaviour>().material = valor[2];// material
            inimigo.GetComponent<InimigoBehaviour>().hpTotal = int.Parse(valor[3]);//hp
            inimigo.GetComponent<InimigoBehaviour>().tpTotal = int.Parse(valor[4]);//tp
            inimigo.GetComponent<InimigoBehaviour>().level = int.Parse(valor[5]);//level

            var novoInimigo = Instantiate(inimigo, GenerateVector3(),
               Quaternion.Euler(0,0,0));

            novoInimigo.transform.parent = listaDeInimigos.transform;
        }

    }
    
    public Vector3 GenerateVector3()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), 1.4f, Random.Range(7f, 16f));
        return randomPosition;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
