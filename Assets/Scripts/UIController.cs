using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.WSA;

public class UIController : MonoBehaviour
{
    public SubMenu[] Menus;
    public Button backButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public SubMenu GetActiveMenu()
    {
        foreach (var item in Menus)
        {
            if (item.IsActive)
            {
                return item;
            }
        }

        return null;
    }

    public void LaunchMenu(SubMenu sub)
    {
        SubMenu currMenu = GetActiveMenu();

        if (currMenu != null)
        {
            DeactivateMenu(currMenu);
        }

        ActivateMenu(sub);
    }

    public void ReturnToGame()
    {
        SubMenu currMenu = GetActiveMenu();

        DeactivateMenu(currMenu);


    }

    public void ActivateMenu(SubMenu sub)
    {
        sub.init();

        sub.gameObject.SetActive(true);
        sub.IsActive = true;

        backButton.transform.position = sub.MenuButton.transform.position;


        sub.MenuButton.gameObject.SetActive(false);


        backButton.gameObject.SetActive(true);
    }

    public void DeactivateMenu(SubMenu sub)
    {
        sub.gameObject.SetActive(false);
        sub.IsActive = false;

        sub.MenuButton.gameObject.SetActive(true);

        backButton.gameObject.SetActive(false);
    }
}
