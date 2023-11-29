using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class TruckMovement : MonoBehaviour
{
    [SerializeField] Transform target1;
    public Button targetButton1;
    [SerializeField] Transform target2;
    public Button targetButton2;
    [SerializeField] Transform target3;
    public Button targetButton3;
    [SerializeField] Transform target4;
    public Button targetButton4;
    [SerializeField] Transform targetMengirim;
    public Button targetButtonMengirim;
    NavMeshAgent agent;

	private void Start()
	{
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        Button btn = targetButton1.GetComponent<Button>();
        Button btn2 = targetButton2.GetComponent<Button>();
        Button btn3 = targetButton3.GetComponent<Button>();
        Button btn4 = targetButton4.GetComponent<Button>();
        Button btnMengirim = targetButtonMengirim.GetComponent<Button>();
        btn.onClick.AddListener(Follow1);
        btn2.onClick.AddListener(Follow2);
        btn3.onClick.AddListener(Follow3);
        btn4.onClick.AddListener(Follow4);
        btnMengirim.onClick.AddListener(Follow5);
    }

	void Follow1 ()
	{   
        agent.SetDestination(target1.position);
    }

    void Follow2()
    {
        agent.SetDestination(target2.position);
    }

    void Follow3()
    {
        agent.SetDestination(target3.position);
    }

    void Follow4()
    {
        agent.SetDestination(target4.position);
    }
    
    void Follow5()
    {
        agent.SetDestination(targetMengirim.position);
    }
}