using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Harmony;
using System.Reflection;

namespace KCModUtils
{
    public class ModUtilsMain : MonoBehaviour
    {
        public static KCModHelper Helper { get; set; }

        public static string modID { get; set; }

        static void Prelaod(KCModHelper helper)
        {
            ModUtilsMain.Helper = helper;

            var harmony = HarmonyInstance.Create("harmony");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}