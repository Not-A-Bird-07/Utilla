﻿using BepInEx.Logging;
using UnityEngine;

namespace Utilla.Tools
{
    internal class Logging
    {
        public static ManualLogSource Logger;

        public static void Info(object data) => Log(data, LogLevel.Info);

        public static void Warning(object data) => Log(data, LogLevel.Warning);

        public static void Error(object data) => Log(data, LogLevel.Error);

        public static void Log(object data, LogLevel level = LogLevel.Info)
        {
#if DEBUG
            if (Logger == null) Debug.Log($"[Utilla, {level}] {data}");
            else Logger.Log(level, data);
#endif
        }
    }
}
