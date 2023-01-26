using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativaarma : MonoBehaviour
{
    public pegaarma pgarma;

    public  int numarma;

   public static List<int>armas=new List<int>();

   
    // Start is called before the first frame update
    void Start()
    {
        pgarma=GameObject.FindGameObjectWithTag("Player").GetComponent<pegaarma>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        
        if(other.tag=="Player"&&Input.GetKey(KeyCode.E)){

if(!armas.Contains(numarma)){
  armas.Add(numarma);
            Debug.Log(numarma);


}
          

            pgarma.ativaarma(numarma);
            Destroy(gameObject);
            
        }
    }
}
