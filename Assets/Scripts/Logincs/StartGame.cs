using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public void StartButton()
    {

        SceneManager.LoadScene("SampleScene"); // ��ȯ�ϰ��� �ϴ� ȭ���� B�� �̸��� ""�� �־��ش�.
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
