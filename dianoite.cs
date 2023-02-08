using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class dia : MonoBehaviour
{
    [SerializeField]  Transform luz;
   [SerializeField]   [Tooltip("duracao dias segundos")] int duraodia=2000;
   [SerializeField]  TextMeshProUGUI horariotxt;

   public static string horasglobal;
  
  float segundos;
  float multiplicado;

  public static int diaglobal;
  
   public static int horas;
  
  
  void proceu(){
    float rotx =Mathf.Lerp(-90,270,segundos/86400);
    luz.rotation=Quaternion.Euler(rotx,0,0);
  }
  void calchora(){
   // horasglobal=



 horariotxt.text=TimeSpan.FromSeconds(segundos).ToString(@"hh/:mm");
  }
    // Start is called before the first frame update
    void Start()
    {
        
        multiplicado=86400/duraodia;
    }

    // Update is called once per frame
    void Update()
    {
        segundos+=Time.deltaTime*multiplicado;
        if(segundos>=86400){segundos=0;diaglobal++;}

      
        

    
    calchoras();

        proceu();
        //double h=double.Parse( horasglobal);

        Debug.Log(horas+" ------------  "+diaglobal+" ------------  "+horasglobal);

        
        
    }

    void LateUpdate()
    {    
        
    }

    void FixedUpdate()
    {
        
       
        
        
    }

 

 

    void calchoras(){

         horasglobal= TimeSpan.FromSeconds( segundos).ToString(@"hh\:mm");
        
        //if();

        switch (horasglobal)
        {
            case "01:00":

            horas=1;
            

            break;
             case "02:00":

            horas=2;
            

            break;

              case "03:00":

            horas=3;
            

            break;
              case "04:00":

            horas=4;
            

            break;
              case "05:00":

            horas=5;
            

            break;
              case "06:00":

            horas=6;
            

            break;
              case "07:00":

            horas=7;
            

            break;

              case "08:00":

            horas=8;
            

            break;
              case "09:00":

            horas=9;
            

            break;
              case "10:00":

            horas=10;
            

            break;
              case "11:00":

            horas=11;
            

            break;
              case "12:00":

            horas=12;
            

            break;
              case "13:00":

            horas=13;
            

            break;
              case "14:00":

            horas=14;
            

            break;
              case "15:00":

            horas=15;
            

            break;
              case "16:00":

            horas=16;
            

            break;
              case "17:00":

            horas=17;
            

            break;
              case "18:00":

            horas=18;
            

            break;
              case "19:00":

            horas=19;
            


            break;
              case "20:00":

            horas=20;
            

            break;
              case "21:00":

            horas=21;
            

            break;
              case "22:00":

            horas=22;
            

            break;
              case "23:00":

            horas=23;
            

            break;
              case "00:00":

            horas=24;
            

            break;
            
            
        }



    }

}


