using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PFE
{
    public class UILogin : MonoBehaviour
    {
        private Button BtnLogin, BtnSignin;
        public void Awake()
        {
            BtnLogin = transform.Find("BtnLogin").GetComponent<Button>();
            BtnSignin = transform.Find("BtnSignin").GetComponent<Button>();

            BtnLogin.onClick.AddListener(ClickBtnLogin);
            BtnSignin.onClick.AddListener(ClickBtnSignin);
        }

        public void ClickBtnLogin()
        {
            UIGlobalData.Instance.isShowLogin = false;
            UIGlobalData.Instance.isShowProfile = true;
        }

        public void ClickBtnSignin()
        {
            UIGlobalData.Instance.isShowLogin = false;
            UIGlobalData.Instance.isShowSignin = true;
        }
    }
}