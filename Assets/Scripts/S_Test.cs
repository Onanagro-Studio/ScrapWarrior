using UnityEngine;
using System.Collections;

public class S_Test : MonoBehaviour {

    enum ETurnState
    {
        Draw,
        Defense,
        Attack,
        Discard
    }

    [Range(2,6)]
    public int m_PlayerQtt = 2;

    private int m_ActivePlayer = 0;
    private ETurnState m_ActualState = 0;



	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        switch( m_ActualState )
        {
            case ETurnState.Draw:

                Debug.Log( "Player" + m_ActivePlayer + " Draw");


                m_ActualState = ETurnState.Defense;
                break;
            case ETurnState.Defense:

                Debug.Log( "Player" + m_ActivePlayer + " Defense" );

                m_ActualState = ETurnState.Attack;
                break;
            case ETurnState.Attack:

                Debug.Log( "Player" + m_ActivePlayer + " Attack" );

                m_ActualState = ETurnState.Discard;
                break;
            case ETurnState.Discard:

                Debug.Log( "Player" + m_ActivePlayer + " Discard" );


                if( m_ActivePlayer + 1 < m_PlayerQtt )
                {
                    m_ActivePlayer++;
                }
                else
                {
                    m_ActivePlayer = 0;
                }
                m_ActualState = ETurnState.Draw;
                break;
            default:
                break;
        }

    }
}
