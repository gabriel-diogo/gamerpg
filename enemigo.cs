using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class e : MonoBehaviour
{
    // Start is called before the first frame update
    public int rotina;
    public float cronometro;
    public Animator ani;
    public float grado;
    public Quaternion angulo;
    public GameObject target;
    public bool ataca;
    // Start is called before the first frame update
    void Start()
    {
        ani=GetComponent<Animator>();
        target=GameObject.Find("gd");
    }
public void coportamento(){
if(Vector3.Distance(transform.position,target.transform.position)>5){

ani.SetBool("run",false);
    cronometro+=1*Time.deltaTime;
    if(cronometro>=4){
        rotina=Random.Range(0,2);
        cronometro=0;
    }
    switch(rotina){
        case 0:
        ani.SetBool("walk",false);
    break;
    case 1:
    grado=Random.Range(0,360);
    angulo=Quaternion.Euler(0,grado,0);
    rotina++;
    break;
    case 2:
    transform.rotation=Quaternion.RotateTowards(transform.rotation,angulo,0.5f);
    transform.Translate(Vector3.forward*1*Time.deltaTime);
    ani.SetBool("walk",true);
    break;
    }
}else{
    if(Vector3.Distance(transform.position,target.transform.position)>1&&!ataca){
    var lookpos=target.transform.position-transform.position;
    lookpos.y=0;
    var rotation =Quaternion.LookRotation(lookpos);
    transform.rotation=Quaternion.RotateTowards(transform.rotation,rotation,3);
    ani.SetBool("walke",false);
    ani.SetBool("run",true);
    transform.Translate(Vector3.forward*2*Time.deltaTime);
   
   ani.SetBool("ata",false);
   
   }
    else{
ani.SetBool("run",false);
ani.SetBool("walk",false);
ataca=true;
ani.SetBool("ata",true);
if(Vector3.Distance(transform.position,target.transform.position)>2&&ataca){
    final();
}
    }
}
}
public void final(){
    ani.SetBool("ata",false);
    ataca=false;

}


    // Update is called once per frame
    void Update()
    {
        coportamento();
    }
}
