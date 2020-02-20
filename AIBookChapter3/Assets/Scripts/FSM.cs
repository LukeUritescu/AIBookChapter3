using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum FSMState { Chase, Flee}

public class FSM : MonoBehaviour
{
    public int chaseProbability = 80;
    public int fleeProbability = 20;

    public ArrayList statesPoll = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < chaseProbability; i++)
        {
            statesPoll.Add(FSMState.Chase);
        }
        for(int i = 0; i < fleeProbability; i++)
        {
            statesPoll.Add(FSMState.Flee);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomState = Random.Range(0, statesPoll.Count);
            Debug.Log(statesPoll[randomState].ToString());
        }   
    }
}
