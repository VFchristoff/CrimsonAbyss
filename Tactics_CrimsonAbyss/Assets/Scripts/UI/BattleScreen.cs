using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleScreen : MonoBehaviour
{

    public GameObject [] enemyPrefabs;
    Transform transformInimigo;

    // Start is called before the first frame update
    void Start()
    {
        enemyPrefabs = GameObject.FindGameObjectsWithTag("NPC");
        transformInimigo = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckDistance ()
    {
        //if (transform)

    }
}
