using System.Collections;
using System.Collections.Generic;
using NWH.VehiclePhysics2;
using UnityEngine.UI;
using UnityEngine;

public class ContagemRegressiva : MonoBehaviour
{
    public Text txtContagem;
    public float contagem = 5f;
    public VehicleController[] vehicles;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        txtContagem.text = Mathf.RoundToInt(contagem).ToString();
        //Mathf.RoundToInt(contagem);
        contagem -= Time.deltaTime;

        if (contagem <= 0)
        {
            txtContagem.gameObject.SetActive(false);
            ativar();
        }
        else
        {
            desativar();
        }
    }
    public void desativar()
    {
        foreach (VehicleController car in vehicles)
        {
            car.input.autoSetInput = false;
        }
    }

    public void ativar()
    {
        foreach (VehicleController car in vehicles)
        {
            car.input.autoSetInput = true;
        }
    }
}
