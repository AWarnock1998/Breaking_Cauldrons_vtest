using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeBehave : MonoBehaviour
{
    [SerializeField] public GameObject Player1;
    [SerializeField] public GameObject Player2;

    private Vector3 Player1Pos;
    private Vector3 Player2Pos;

    private float DiffDis;

    private void Start()
    {
        
    }
    void Update()
    {
        Player1Pos = Player1.transform.position;
        Player2Pos = Player2.transform.position;

        DiffDis = Vector3.Distance(Player1Pos, Player2Pos);
        if (DiffDis >= 3)
        {
            Debug.Log("Too Long");
        }
    }
}
