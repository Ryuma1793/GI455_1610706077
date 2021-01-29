using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TextMach : MonoBehaviour
{
    public Text addtext;
    public Button search;
    public InputField searchText;
    public Text check;

    // Start is called before the first frame update
    void Start()
    {
        addtext.text = "Jim Pen Pencil Egg Gold";
        search.onClick.AddListener(SearchText);


    }
   void SearchText()
    {
        string[] arr = { "Jim", "Pen", "Pencil","Egg","Gold" };
        string str = searchText.text;
        bool relese = arr.AsQueryable().Contains(str);
        if (relese == true)
        {
            check.text = searchText.text + " found";
        }
        else
        {
            check.text = searchText.text + " not found";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
