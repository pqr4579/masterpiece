using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManeger : MonoBehaviour {

    public GameObject Panel;


    public void OpenPanel()
    {
        if(Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("open");//애니메이터의 불타입 파라미터 open을 is open에 대입
                Debug.Log(animator.GetBool("open"));
                animator.SetBool("open", !isOpen);//open에 만약 isOpen이 참이면 false를 거짓이면 true를 set해줌-> 토글

            }
        }
    }

    public void build_mode()
    {


    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
