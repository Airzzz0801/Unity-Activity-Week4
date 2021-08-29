using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    public Renderer rend;
    private GameObject[] goS;
    private int a;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        a = Random.Range(200,251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        PrintAndHide.print(gameObject.name+":"+i);
        goS = GameObject.FindGameObjectsWithTag("Red");
        if(i==100)
        {
            foreach(GameObject redGo in goS)
            {
                redGo.SetActive(false);
            }
        }
        goS = GameObject.FindGameObjectsWithTag("Blue");
        if (i ==a)
        {
            foreach(GameObject blueGo in goS)
            {
                blueGo.GetComponent<Renderer>().enabled=false;
            }
        }
    }
}
