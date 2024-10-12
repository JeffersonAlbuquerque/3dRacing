using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ContadorCheckPoint : MonoBehaviour
{
    public Text CheckPointText;
    public int MaxCheckPoint;
    public static int CheckPointAtual;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckPointText.text = "CHECKPOINT " + CheckPointAtual + "/" + MaxCheckPoint.ToString();
    }
}
