using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrParaProfessores : MonoBehaviour
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
        if (Vector3.Distance(this.transform.position, jogador.transform.position) < 1)
        {
            canvas.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Application.OpenURL("https://www.youtube.com/watch?v=FyuPmY6VrrU");
            }
        }
        else
        {
            canvas.gameObject.SetActive(false);
        }
    }
}
