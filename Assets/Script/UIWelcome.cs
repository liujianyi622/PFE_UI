using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace PFE
{
    public class UIWelcome : MonoBehaviour
    {
        public GameObject WelcomePage, LoginPage, MenuPage, SignupPage, CollectionPage, ProfilePage, RecognizePage;
        private Button BtnLogin;
        public void Awake()
        {
            UIGlobalData.Instance.isShowWelcome = true;
        }

        public void Start()
        {
            StartCoroutine(TimeDelay(2f));
        }

        public void Update()
        {
            if (UIGlobalData.Instance.isShowWelcome)
                WelcomePage.SetActive(true);
            else
                WelcomePage.SetActive(false);

            if (UIGlobalData.Instance.isShowLogin)
                LoginPage.SetActive(true);
            else
                LoginPage.SetActive(false);

            if (UIGlobalData.Instance.isShowMenu)
                MenuPage.SetActive(true);
            else
                MenuPage.SetActive(false);

            if (UIGlobalData.Instance.isShowSignin)
                SignupPage.SetActive(true);
            else
                SignupPage.SetActive(false);

            if (UIGlobalData.Instance.isShowCollection)
                CollectionPage.SetActive(true);
            else
                CollectionPage.SetActive(false);

            if (UIGlobalData.Instance.isShowProfile)
                ProfilePage.SetActive(true);
            else
                ProfilePage.SetActive(false);

            if (UIGlobalData.Instance.isRecognize)
                RecognizePage.SetActive(true);
            else
                RecognizePage.SetActive(false);

        }

        private IEnumerator TimeDelay(float time)
        {
            yield return new WaitForSeconds(time);
            UIGlobalData.Instance.isShowLogin = true;
            UIGlobalData.Instance.isShowWelcome = false;            
        }

    }
}