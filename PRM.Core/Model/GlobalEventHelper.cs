﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRM.Core.Model
{
    public static class GlobalEventHelper
    {
        /// <summary>
        /// Invoke to notify a new remote session is start.
        /// </summary>
        public static Action<uint> OnServerConnect { get; set; } = null;

        /// <summary>
        /// Go to server edit by server id
        /// param1 uint: server id
        /// param2 boo: is duplicate?
        /// </summary>
        public static Action<uint, bool> OnGoToServerEditPage { get; set; } = null;


        /// <summary>
        /// Invoke to notify a newer version of te software was released
        /// while new version code = arg1, download url = arg2
        /// </summary>
        public static Action<string, string> OnNewVersionRelease { get; set; } = null;


        /// <summary>
        /// Invoke to show up progress bar when arg2 > 0
        /// while progress percent = arg1 / arg2 * 100%, alert info = arg3
        /// </summary>
        public static Action<int, int, string> OnLongTimeProgress { get; set; } = null;

        /// <summary>
        /// Invoke to notify language was changed.
        /// </summary>
        public static Action OnLanguageChanged { get; set; } = null;
    }
}
