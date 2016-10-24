using UnityEngine;
using System.Collections;

public class S_CardMaterials : MonoBehaviour {

    public static Material[][] CardsMat;

    public GameObject Card;

    public Material[] m_PinkCardsMat;
    public Material[] m_BlueCardsMat;
    public Material[] m_GreenCardsMat;


    private Renderer m_FrontMat;


    // Use this for initialization
    void Start () {

        m_FrontMat = GetComponent<Renderer>();

        CardsMat[ 0 ] = m_PinkCardsMat;
        CardsMat[ 1 ] = m_BlueCardsMat;
        CardsMat[ 2 ] = m_GreenCardsMat;
    }
	
	// Update is called once per frame
	void Update () {
      
    }
}
