using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ob;
    // Start is called before the first frame update
    void Start()
    {
        ob.SetActive(false);
    }

    public void ObjOn()
    {
        ob.SetActive(true);
    }

    public void ObjOff()
    {
        ob.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
