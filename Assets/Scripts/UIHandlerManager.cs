using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using System.IO;
using TMPro;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class UIHandlerManager : MonoBehaviour
{
    
    public static UIHandlerManager Instance;

    // Start is called before the first frame update
    [SerializeField] public Text Nombre;
    public void NewNameChoose(Text name)
    {
        Nombre = name;

    }
    public void StartNew()
    {
        
        SceneManager.LoadScene(1);
        
        

    }
   
    
    // Update is called once per frame
    void Update()
    {
        Nombre = PlayerPrefs.GetString(Nombre);
    }

   
}
