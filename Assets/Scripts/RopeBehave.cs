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

    private SpringJoint2D SpgJtPl1; 
    private SpringJoint2D SpgJtPl2;

    private void Start()
    {
        SpgJtPl1 = Player1.GetComponent<SpringJoint2D>();
        SpgJtPl2 = Player2.GetComponent<SpringJoint2D>();            
    }
    void Update()
    {
        Player1Pos = Player1.transform.position;
        Player2Pos = Player2.transform.position;

        DiffDis = Vector3.Distance(Player1Pos, Player2Pos);
        if (DiffDis >= 3)
        {
            SpgJtPl1.enabled = true;
            SpgJtPl2.enabled = true;
        }
    }
}
