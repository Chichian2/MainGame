using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cooking : MonoBehaviour
{

    
    private MeshRenderer meatMat;
    private string stillcooking = "y";
    testPlace script;
    //[SerializeField] testPlace OnStove;
    public GameObject Stove;
    public GameObject currentItem;
    public GameObject nextStage;
    public string objName = "testcollider";
    public enum state { raw, cooking };
    public state currState;
    
   

    void Awake()
    {
        print("Activate works");
        if(currState == state.cooking)
        {
            print("Enum works");
            Stove = GameObject.Find(objName);
            StartCoroutine(cookTimer());
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //print(onStove.isOnStove);
        if(other.gameObject == Stove)
        {
            script = other.GetComponentInParent<testPlace>();
            if (script.isOnStove)
            {
                print("testPlace Works");
                print(other.GetComponentInParent<testPlace>());
                stillcooking = "y";
                print("Works");
                meatMat = GetComponent<MeshRenderer>();
                StartCoroutine(cookTimer());
            }
            /*print(other.GetComponentInParent<testPlace>());
            stillcooking = "y";
            print("Works");
            meatMat = GetComponent<MeshRenderer>();
            StartCoroutine(cookTimer());
            */

        }
    }

    void OnTriggerExit(Collider other)
    {
        //print("Works exited");
        if (other.gameObject == Stove)
        {

            print("Works exited");
            stillcooking = "n";
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator cookTimer()
    {
        yield return new WaitForSeconds(5);
        if (stillcooking == "y")
        {
            Replace(currentItem, nextStage);
        }
    }

    void Replace(GameObject obj1, GameObject obj2)
    {
        Instantiate(obj2, obj1.transform.position, obj1.transform.rotation);
        Destroy(obj1);
    }
}
