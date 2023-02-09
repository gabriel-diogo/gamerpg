using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class npcbuy_fala : MonoBehaviour
{


float vel=1;
int time=dia.horas;

string[] nomeanima={"idle","walk","victory"};

string[] nomeanima2={"para","anda","trab"};


Animation a;


    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
           move(anim,npc,nomeanima2);
    
    
    //detectt();
      
    }




public Transform[] ponts;

public int tempo;
public int temporestante;

public Transform tanget;
public Transform detect;
 float timetrans;
 int nexpont,lastpont;

 public NavMeshAgent npc;



 Animator anim;





void Awake()
{a=GetComponent<Animation>();
    npc=GetComponent<NavMeshAgent>();
   anim=GetComponent<Animator>();
    lastpont=ponts.Length;
}
    // Start is called before the first frame update
   

    // Update is called once per frame
 
    void move(Animator a ,NavMeshAgent npc,string[] nomeanima)
    {
        //timetrans+=Time.deltaTime;
        //tempo=Mathf.RoundToInt (timetrans);
      //  if(tempo==temporestante){timetrans=0f;tempo=0;
        //    nexpont= Random.Range(0,lastpont);
            
            
        int distacia=Mathf.RoundToInt(Vector3.Distance(transform.position,ponts[nexpont].position));

            
switch(dia.horas){
    case 6 :
    case 7 :
npc.destination=ponts[0].position;nexpont=0;
    //anda
           if(distacia==1|distacia==0)a.Play(nomeanima[0]);else a.Play(nomeanima[1]);
            

            
    break;
       case 8 :
    case 9 :
npc.destination=ponts[1].position;nexpont=1; 
    //anda

if(distacia==1|distacia==0)a.Play(nomeanima[0]);else a.Play(nomeanima[2]);

           
    break;



    
        case 1:
npc.destination=ponts[2].position;nexpont=2; 
if(distacia==1|distacia==0)a.Play(nomeanima[0]);else
    //anda
            a.Play(nomeanima[1]);
         // anim.Play("anda");nexpont=2;
    break;
}
  
            
            
            //anim.SetBool("anda",true);


            
      //  }

       
Debug.Log("distacia"+distacia);


    } 
       void detectt()
    {
        
        detect.LookAt(tanget);

        var fwd=detect.TransformDirection(Vector3.forward);

        RaycastHit hit;

        if(Physics.Raycast(detect.position,fwd,out hit,5f)&&hit.collider.CompareTag("Player")){




        npc.isStopped=true;
        transform.LookAt(tanget);
        
        //animacao anda =false

        //ataque = true
        
        
                }else{
                    npc.isStopped=false;
                    //anima ataca=false
                }

    }
}
