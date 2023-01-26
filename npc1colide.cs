using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc1 : MonoBehaviour
{
    public float velmov,velrot;
    public float tenpo=8f;
    int mov;
    bool espera,caminha,gire;

Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //anim.GetComponent<Animator>();
        acao();
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward,out hit,2.5f )){
            if(hit.collider){
                gire=true;
                StartCoroutine(tempogira());
            }
        }




        if(espera){GetComponent<Animator>().SetBool("ativo",false);  }


      
if(caminha){GetComponent<Animator>().SetBool("ativo",true);
transform.position+=(transform.forward*velmov*Time.deltaTime);}


        if(gire){transform.Rotate(Vector3.up*velrot*Time.deltaTime);GetComponent<Animator>().SetBool("rota",gire); }
       // else{GetComponent<Animator>().SetBool("rota",gire);}
            
       
        
    }


    void acao(){
        mov=Random.Range(1,4);
    
    switch(mov){
        case 1:
        caminha=true;
        espera=false;
        break;
         case 2:
         espera=true;
         caminha=false;
        break;
         case 3:
         gire=true;
         StartCoroutine(tempogira());

        break;
        
    }
    Invoke("acao",tenpo);
    }
    IEnumerator tempogira(){
        yield return new WaitForSeconds(2);
        gire=false;
    }
}
