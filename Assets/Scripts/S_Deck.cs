using UnityEngine;
using System.Collections;

public class S_Deck : MonoBehaviour {

    public GameObject m_CardPrefab;

    private GameObject[] m_CardsInDeck = new GameObject[60];

	// Use this for initialization
	void Start () {
        int index;
        for( int i = 0; i < 4; i++ )
        {
            for( int j = 0; j < 3; j++ )
            {
                for( int k = 0; k < 5; k++ )
                {
                    index = ( i * 15 ) + ( j * 5 ) + k;

                    Debug.Log( index );

                    m_CardsInDeck[index] = Instantiate( m_CardPrefab, new Vector3( index + 2, index / 20f, 0 ), Quaternion.identity ) as GameObject;

                    m_CardsInDeck[ index ].transform.parent = this.gameObject.transform;
                    m_CardsInDeck[ index ].transform.Rotate( 0, 0, 180 );
                    m_CardsInDeck[ index ].GetComponent<S_Card>().SetValues(j, k);


                }
            }
        }


    }
	
	// Update is called once per frame
	void Update () {
       
	}
}
