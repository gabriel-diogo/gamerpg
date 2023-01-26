using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegaarma : MonoBehaviour
{

    public GameObject[] armas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
if(Input.GetKeyDown(KeyCode.R)){desativa();}


        
    }

    public void ativaarma(int num){
for(int i=0;i<armas.Length;i++){
            armas[i].SetActive(false);
        }
        armas[num].SetActive(true);
    }

    public void desativa(){
        for(int i=0;i<armas.Length;i++){
            armas[i].SetActive(false);
        }
    }
}
