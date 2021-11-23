﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biblioteca : MonoBehaviour
{
    public GameObject canvas;
    public GameObject jogador;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, jogador.transform.position) < 3)
        {
            canvas.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Application.OpenURL("https://www.ufn.edu.br/site/portfolio");
            }
        }
        else
        {
            canvas.gameObject.SetActive(false);
        }
    }
}