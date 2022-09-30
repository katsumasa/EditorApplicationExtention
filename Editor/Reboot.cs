using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UTJ
{
    public partial class EditorApplicationExtention
    {
        // File/Exit or File Cles prio is 240
        [MenuItem("File/Reboot",false,241)]
        public static void Reboot()
        {
            editorApplicationQuit += RebootCB;
            UnityEditor.EditorApplication.Exit(0);
        }


        //[MenuItem("Window/Test2")]
        static void Test()
        {
            var argv = System.Environment.GetCommandLineArgs();
            for (var i = 0; i < argv.Length; i++)
            {
                if (argv[i].Contains(" "))
                {
                    argv[i] = string.Format("\"{0}\"", argv[i]);
                }
            }

            var Arguments = string.Join(" ", argv);
        }

        static void RebootCB()
        {
            editorApplicationQuit -= RebootCB;

            var argv = System.Environment.GetCommandLineArgs();
            var args = new string[argv.Length - 1];
            for(var i = 1; i < argv.Length; i++)
            {
                if(argv[i].Contains(" "))
                {
                    args[i - 1] = string.Format("\"{0}\"", argv[i]);
                }
                else
                {
                    args[i - 1] = argv[i];
                }
            }


            var info = new System.Diagnostics.ProcessStartInfo();
            info.FileName = argv[0];
            info.Arguments = string.Join(" ", args);            
            System.Diagnostics.Process.Start(info);
        }
    }
}