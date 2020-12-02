﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Gaia
{


    /// <summary>
    /// The baked mask types publicly available for selection
    /// </summary>
    public enum BakedMaskType { TerrainTree, Tag} //Layer }

    /// <summary>
    /// All possible baked mask types
    /// </summary>
    public enum BakedMaskTypeInternal { TerrainTree, Tag, WorldBiomeMask } //Layer }
    [System.Serializable]
    public class CollisionMask
    {
        public bool m_active = true;
        public bool m_invert = false;
        public BakedMaskType m_type;
        //public int m_treePrototypeId= -99;

        public string m_treeSpawnRuleGUID = "";
        public static SpawnRule[] m_allTreeSpawnRules;
        public static Spawner[] m_allTreeSpawners;
        public static string[] m_allTreeSpawnRuleNames;
        public static int[] m_allTreeSpawnRuleIndices;

        public string m_tag;
        public float m_Radius;
        public string m_layer;

    }
}
