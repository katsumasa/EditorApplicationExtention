using System.Reflection;
using UnityEngine.Events;
using UnityEditor;


namespace UTJ
{
    public partial class EditorApplicationExtention
    {
        static FieldInfo m_editorApplicationQuitFieldInfo;

        static FieldInfo editorApplicationQuitFieldInfo
        {
            get
            {
                if (m_editorApplicationQuitFieldInfo == null)
                {
                    m_editorApplicationQuitFieldInfo = typeof(EditorApplication).GetField("editorApplicationQuit", BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);
                }
                return m_editorApplicationQuitFieldInfo;
            }
        }


        /// <summary>
        /// UnityEditor終了時に実行されるUnityAction
        /// </summary>
        public static UnityAction editorApplicationQuit
        {
            get 
            {
                return editorApplicationQuitFieldInfo.GetValue(null) as UnityAction;
            }

            set
            {
                var actions = editorApplicationQuitFieldInfo.GetValue(null) as UnityAction;
                actions += value;
                editorApplicationQuitFieldInfo.SetValue(null, actions);

            }
        }
    }
}