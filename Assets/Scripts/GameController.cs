using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject OneBallPrefab;

    void Start()
    {
        InvokeRepeating("AddABall", 1.5F, 1);

    }
    void AddABall()
    {
        Instantiate(OneBallPrefab);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
