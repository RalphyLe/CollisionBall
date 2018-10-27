﻿using GameFramework;
namespace CollisionBall
{
    /// <summary>
    /// 游戏入口。
    /// </summary>
    public partial class GameEntry
    {
        /// <summary>
        /// 获取场景组件。
        /// </summary>
        public static MapComponent Map
        {
            get;
            private set;
        }

        public static SpawnComponent Spawn
        {
            get;
            private set;
        }

        private static void InitCustomComponents()
        {
            Map = UnityGameFramework.Runtime.GameEntry.GetComponent<MapComponent>();
            if (Map)
                Log.Info("获取Map组件成功");
            else
                Log.Info("获取Map组件失败");
            Spawn = UnityGameFramework.Runtime.GameEntry.GetComponent<SpawnComponent>();
            if (Spawn)
                Log.Info("获取Spawn组件成功");
            else
                Log.Info("获取Spawn组件失败");
        }
    }
}