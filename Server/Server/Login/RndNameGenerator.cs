using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using Swift;
using Nova;
/// <summary>
/// 随机名字生成器
/// </summary>
public class RndNameGenerator : Component
{
    // 随机名字次数上限，如果超过该次数还没有随到可用则随机 BB 形式的名字
    public readonly int RandomNameTimes = 5;
    // 名字前缀集合
    public List<string> PrefixList = new List<string>();
    // 名字男后缀集合
    public List<string> MSuffixList = new List<string>();
    // 名字女后缀集合
    public List<string> FSuffixList = new List<string>();

    // 加载随机名字库
    public void Load()
    {
        string text = File.ReadAllText(/*CsvParser.csvDir + */"/name_random.txt");
        string[] nameArr = text.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        List<string> nameList = null;

        foreach (string name in nameArr)
        {
            string str = name.Trim();
            if (string.IsNullOrEmpty(str))
                continue;

            if (str == "[前缀]")
            {
                nameList = PrefixList;
                continue;
            }
            else if (str == "[男名]")
            {
                nameList = MSuffixList;
                continue;
            }
            else if (str == "[女名]")
            {
                nameList = FSuffixList;
                continue;
            }

            if (nameList != null)
                nameList.Add(str);
        }
    }
    // 随机一个男名字,名字随机按照 AB 形式（前缀+名称）进行随机
    string RandomMaleName()
    {
        int prefixNum = PrefixList.Count;
        int suffixNum = MSuffixList.Count;
        int prefixIndex = Utils.Random(0, prefixNum);
        int suffixIndex = Utils.Random(0, suffixNum);
        return PrefixList[prefixIndex] + MSuffixList[suffixIndex];
    }
    // 随机一个女名字,名字随机按照 AB 形式（前缀+名称）进行随机
    string RandomFamaleName()
    {
        int prefixNum = PrefixList.Count;
        int suffixNum = FSuffixList.Count;
        int prefixIndex = Utils.Random(0, prefixNum);
        int suffixIndex = Utils.Random(0, suffixNum);
        return PrefixList[prefixIndex] + FSuffixList[suffixIndex];
    }
    // 随机一个BB形式的男名
    string RandomMaleName2()
    {
        int suffixNum = MSuffixList.Count;
        int prefixIndex = Utils.Random(0, suffixNum);
        int suffixIndex = Utils.Random(0, suffixNum);
        return MSuffixList[prefixIndex] + MSuffixList[suffixIndex];
    }
    // 随机一个BB形式的女名
    string RandomFamaleName2()
    {
        int suffixNum = FSuffixList.Count;
        int prefixIndex = Utils.Random(0, suffixNum);
        int suffixIndex = Utils.Random(0, suffixNum);
        return FSuffixList[prefixIndex] + FSuffixList[suffixIndex];
    }

    public string RndName_AB()
    {
        //if (sex == Sex.Male)
            return RandomMaleName();   
        //else
        //    return RandomFamaleName();
    }

    public string RndName_BB()
    {
        //if (sex == Sex.Male)
            return RandomMaleName2();
        //else
        //    return RandomFamaleName2();
    }

    public override void OnAdded()
    {
        base.OnAdded();
        Load();
    }
}
