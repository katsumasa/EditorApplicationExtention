using System.Reflection;
using UnityEngine.Events;
using UnityEditor;


namespace UTJ
{
    public partial class EditorApplicationExtention
    {
        static FieldInfo m_eitorApplicationQuitFieldInfo;

        static FieldInfo eitorApplicationQuitFieldInfo
        {
            get
            {
                if (m_eitorApplicationQuitFieldInfo == null)
                {
                    m_eitorApplicationQuitFieldInfo = typeof(EditorApplication).GetField("editorApplicationQuit", BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);
                }
                return m_eitorApplicationQuitFieldInfo;
            }
        }


        /// <summary>
        /// UnityEditor終了時に実行されるUnityAction
        /// </summary>
        public static UnityAction eitorApplicationQuit
        {
            get 
            {
                return eitorApplicationQuitFieldInfo.GetValue(null) as UnityAction;
            }

            set
            {
                var actions = eitorApplicationQuitFieldInfo.GetValue(null) as UnityAction;
                actions += value;
                eitorApplicationQuitFieldInfo.SetValue(null, actions);

            }
        }
    }
}