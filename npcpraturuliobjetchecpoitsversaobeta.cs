using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class npcnavpont : MonoBehaviour
{

public Transform[] ponts;

public int tempo;
public int temporestante;

public Transform tanget;
public Transform detect;
 float timetrans;
 int nexpont,lastpont;

 public NavMeshAgent npc;

 Animation animm;

 Animator anim;





void Awake()
{
    npc=GetComponent<NavMeshAgent>();
    animm=GetComponent<Animation>(); anim=GetComponent<Animator>();
    lastpont=ponts.Length;
}
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
        move();
    
    
    detectt();
        
    }



    void move()
    {
        timetrans+=Time.deltaTime;
        tempo=Mathf.RoundToInt (timetrans);
        if(tempo==temporestante){timetrans=0f;tempo=0;
            nexpont= Random.Range(0,lastpont);
            
            

            npc.destination=ponts[nexpont].position;
            
            //anim.SetBool("anda",true);

            anim.Play("anda");
        }
        int distacia=Mathf.RoundToInt(Vector3.Distance(transform.position,ponts[nexpont].position));
Debug.Log(distacia);
        if(distacia==0){
            anim.Play("para");
            // npc.isStopped=true;
            //anim.SetBool("anda",false);anim.SetBool("ativo",true);
        }
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
