using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

[Serializable]
public class SegmentTemplates
{
    public List<MatchSegment> OpeningSegments;
    public List<MatchSegment> ClosingSegments;
    public List<MatchSegment> MatchSegments;
    private SegmentTemplates() { }
    private static SegmentTemplates instance;
    public static SegmentTemplates Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SegmentTemplates();
            }
            return instance;
        }
        private set { instance = value; }
    }

    public static void Load()
    {
        string filename = "MatchSegments.json";
        TextAsset textFile = (TextAsset)AssetDatabase.LoadAssetAtPath(@"Assets/Mods/Core/"+filename, typeof(TextAsset));
        string json = textFile.text;
        Instance = JsonUtility.FromJson<SegmentTemplates> (json);       
    }
}

