using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recebedano : MonoBehaviour
{
      public int hp=30;
    public int danoarma;
    public Animator ani;




      static public int qtdeenimigo;

     

    public Transform[] enemigoalcace=new Transform[qtdeenimigo];



       public float alerta=8f;
public LayerMask player;
bool estaalerta;
 Transform jogador;

public float vel=2;

int dano=0;int dano1=0;public static float ataque;public static bool morte;


float v;public static bool atak;
string nomeenimigo="enemigo";

   // public GameObject inimigo; static int enemigosnome;    public string[]ene=new string[enemigosnome];






    // Start is called before the first frame update
    void Start()
    {

      //nomes.Add(nomeenimigo);
     
      ani=GetComponent<Animator>();

     // for ( i = 0; i <ene.Length ; i++) {inimigo=GameObject.Find(ene[i]);}
     
        
        
      
      
    }
    void LateUpdate()
    {
      
    }

    // Update is called once per frame
    void Update()
    { 
      
      
      
       estaalerta= Physics.CheckSphere(transform.position,alerta,player);
    if(estaalerta==true){
        //transform.LookAt(jogador);
    
    
   
    
    }
         if(Input.GetKey(KeyCode.V))Debug.Log(nomes[0]);
    }


    void FixedUpdate()
    {
        
    }
void danoinimigo(){}


public List<string>nomes=new List<string>();


    void anosofre(Collider other){

         if(other.gameObject.tag=="armainimigo"&e.ataca==true){
            
        dano1++;
        Debug.Log("dano em vc"+dano1);

       if(other.gameObject.tag=="armainimigo"&&morte==false&&atak==false)ani.Play("receberdano");
        
            //if(ani!=null){ani.Play(""); }
                
              
           
          hp-=danoarma;
            
        }

    }
 void OnTriggerEnter(Collider other)
    {


    

        //else{ani.SetBool("dano",false);}
        





    
       for (int i = 0; i <enemigoalcace.Length; i++){ v= Vector3.Distance(transform.position,enemigoalcace[i].transform.position);}




   
        if(other.gameObject.tag=="arma"&
        Input.GetKey(KeyCode.Mouse1)|Input.GetKey(KeyCode.Mouse0)){
                      atak=true;
           if(v<1){
          dano++;

           if(dano>=20){ani.SetBool ("morte",true); morte=true;}else{morte=false;ani.SetBool ("morte",false);}
            
        
        Debug.Log("dano no inimigo"+dano+morte);
            //if(ani!=null){ani.Play(""); }
                
                if(other.gameObject.tag=="arma"){ ani.SetBool("dano",true);ataque+=10;}else{ani.SetBool("dano",false);}
            
          hp-=danoarma;





          }
            
        }else{ atak=false;}
        
        

       // if(hp<=0){Destroy(gameObject);}





            
    }

    void ataquee(Collider other){

  ///////atacar




        for (int i = 0; i <enemigoalcace.Length; i++){ v= Vector3.Distance(transform.position,enemigoalcace[i].transform.position);}




   
        if(other.gameObject.name==nomeenimigo&
        Input.GetKey(KeyCode.Mouse1)|Input.GetKey(KeyCode.Mouse0)){
                      atak=true;
           if(v<1){
          dano++;

           if(dano>=20){ani.Play("morte"); morte=true;}else{morte=false;}
            
        
        Debug.Log("dano no inimigo"+dano+morte);
            //if(ani!=null){ani.Play(""); }
                
                if(other.gameObject.name==nomeenimigo){ ani.Play("dano");ataque+=10;}
            
          hp-=danoarma;





          }
            
        }else{ atak=false;}
        
        

       // if(hp<=0){Destroy(gameObject);}
    }
    
    

      void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,alerta);
    }

    
}
