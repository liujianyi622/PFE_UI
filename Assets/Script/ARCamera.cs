using UnityEngine;
using System.Collections;
using Vuforia;

namespace PFE
{
    public class ARCamera : MonoBehaviour
    {
        void Start()
        {

            VuforiaARController.Instance.RegisterVuforiaStartedCallback(OnVuforiaStarted);
            VuforiaARController.Instance.RegisterOnPauseCallback(OnPaused);
        }

        private void OnVuforiaStarted()
        {
            CameraDevice.Instance.SetFocusMode(
                CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }

        private void OnPaused(bool paused)
        {
            if (!paused)
            {
                CameraDevice.Instance.SetFocusMode(
                    CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
            }
        }

        public void OnDestroy()
        {
            UIGlobalData.Instance.isShowMenu = true;
        }
    }
}