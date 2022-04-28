using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
	public GameObject Confettiobject;
	public GameObject BagAcc;
	public GameObject Lvel2;
	public GameObject Level1;
	public GameObject BagAnim;
	public GameObject Next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKeyDown("space"))
        {
           Confettiobject.SetActive(true);
		   BagAcc.SetActive(true);
		   Lvel2.SetActive(true);
		   Level1.SetActive(false);
		   BagAnim.GetComponent<Animator>().enabled = true;
		   
		   StartCoroutine("WinScene");
        }
    }
	
	
	
		    IEnumerator WinScene()
    {
        yield return new WaitForSeconds(2);
		Next.SetActive(true);
		
	}
}
