using UnityEngine;
using System.Collections;

public class S_Card : MonoBehaviour {

    public enum EColor
    {
        Pink,
        Blue,
        Green
    }

    public enum ESymbol
    {
        Head,
        Torso,
        Hand,
        Leg,
        Foot
    }

    public EColor m_Color = 0;
    public ESymbol m_Symbol =0;

    public GameObject m_Front;
    private Renderer m_FrontMat;

    public Material[] m_PinkCardsMat;
    public Material[] m_BlueCardsMat;
    public Material[] m_GreenCardsMat;




    // Use this for initialization
    void Start () {
     //   m_Color = (EColor)Random.Range( 0, 3 );
     //   m_Symbol = (ESymbol)Random.Range( 0, 5 );

        m_FrontMat = m_Front.GetComponent<Renderer>();

        switch( m_Color )
        {
            case EColor.Pink:
                m_FrontMat.material = m_PinkCardsMat[ (int)m_Symbol ];

                break;
            case EColor.Blue:
                m_FrontMat.material = m_BlueCardsMat[ (int)m_Symbol ];
                break;
            case EColor.Green:
                m_FrontMat.material = m_GreenCardsMat[ (int)m_Symbol ];
                break;
            default:
                break;
        }

        

    }
	
	// Update is called once per frame
	void Update () {
       
    }


    public void SetValues(int color, int symbol )
    {
        m_Color = (EColor)color;
        m_Symbol = (ESymbol)symbol;
    }
}
