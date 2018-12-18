using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordGenerator : MonoBehaviour {

    private static string[] wordList1 ={"map","cow","kit","vat","rob","law","sum","gas","ton","gun","pot",
        "act","buy","row","run","old","jam","cut","bay","pin","lot","era","bin","bag","man","try",
        "bad","hit","tie","see","bet","bar","pan","nun","fur","few","pig","pat","cup","eat" };

    private static string[] wordList2 ={ "size", "lift", "user", "view", "idea", "fire", "find",
        "dead", "pack", "chew", "tape", "rare", "star", "skip", "prey", "fuel", "free", "easy", "roll",
        "mars", "load", "sign", "open", "leaf", "form", "shop", "soul", "sour", "riot", "dorm", "time",
        "text", "past", "bald", "eaux", "aunt", "stab", "hall", "plot", "crop" };

    private static string[] wordList3 ={ "drama", "money", "track", "shake", "evoke", "bacon", "heart",
        "noble", "stall", "brave", "crude", "snake", "title", "uncle", "allow", "mouth", "habit", "strip",
        "learn", "onion", "funny", "crown", "movie", "asset", "brand", "linen", "ivory", "index", "whole",
        "guest", "color", "draft", "shark", "fling", "sheep", "grain", "bless", "begin", "fairy", "fight" };

    private static string[] wordList4 ={ "smooth", "ignore", "coffee", "defend", "leader", "matrix", "burial",
        "fossil", "absent", "mother", "regret", "camera", "efflux", "reveal", "throne", "indoor", "cotton",
        "racism", "suffer", "medium", "season", "strain", "runner", "ballot", "moment", "heroin", "suntan",
        "prefer", "copper", "tender", "summit", "rescue", "credit", "minute", "change", "bucket", "horror",
        "garage", "afford", "timber" };

    private static string[] wordList5 ={ "stomach","impound","predict","offense","fighter","persist",
        "hallway","steward","pasture","laundry","country","soprano","splurge","auditor","quarrel","scatter",
        "chapter","digital","feather","precede","command","skilled","nuclear","nervous","retreat","version",
        "calorie","vehicle","fantasy","general","explode","plastic","funeral","limited","crystal","cutting",
        "perfume","section","achieve" };

    private static string[] wordList6 ={ "midnight","notebook","survival","analysis","abstract","dressing",
        "football","approach","judgment","vertical","straight","opposite","distinct","grateful","innocent",
        "flatware","decrease","perceive","confront","restrain","triangle","cylinder","explicit","ordinary",
        "estimate","congress","security","business","discount","misplace","attitude","election","theorist",
        "negative","sequence","contrast","restrict","slippery","concrete","earthwax", };

    private static string[] wordList7 ={ "unanimous", "different", "inspector", "computing", "construct",
        "circulate", "empirical", "effective", "reception", "accompany", "hilarious", "agreement", "objective",
        "challenge", "vegetable", "underline", "translate", "structure", "eliminate", "housewife", "sculpture",
        "intensify", "eggwhite", "copyright", "intention", "recording", "deviation", "fascinate", "apparatus",
        "neighbour", "premature", "evolution", "liability", "available", "determine", "rebellion", "directory",
        "hierarchy", "recommend", "tradition" };

    private static string[] wordList8 ={ "settlement", "memorandum", "conclusion", "stereotype", "investment",
        "chauvinist", "understand", "compromise", "commission", "reasonable", "resolution", "assumption",
        "vegetarian", "permission", "fastidious", "constraint", "exhibition", "dependence", "collection",
        "initiative", "attraction", "laboratory", "repetition", "expression", "confidence", "decorative",
        "disability", "inhibition", "researcher", "atmosphere", "restaurant", "incredible", "distortion",
        "girlfriend", "negligence", "attachment", "attractive", "mainstream", "management", "concession" };

    private static string[] wordList9 ={ "experienced", "contraction", "unfortunate", "nationalist", "nationalism",
        "fluctuation", "competition", "information", "grandmother", "development", "possibility", "avant-garde",
        "instruction", "demonstrate", "consumption", "shareholder", "nonremittal", "prosecution", "countryside",
        "integration", "firefighter", "compartment", "credit card", "responsible", "credibility", "disposition",
        "miscarriage", "battlefield", "hospitality", "photography", "respectable", "circulation", "inspiration",
        "acquisition", "foolaround", "operational", "expectation", "advertising", "replacement", "comfortable" };

    private static string[] bonusWordList ={ "unanimous", "different", "inspector", "computing", "construct",
        "circulate", "empirical", "effective", "reception", "accompany", "hilarious", "agreement", "objective",
        "challenge", "vegetable", "underline", "translate", "structure", "eliminate", "housewife", "sculpture",
        "intensify", "eggwhite", "copyright", "intention", "recording", "deviation", "fascinate", "apparatus",
        "neighbour", "premature", "evolution", "liability", "available", "determine", "rebellion", "directory",
        "hierarchy", "recommend", "tradition", "map","cow","kit","vat","rob","law","sum","gas","ton","gun","pot",
        "act","buy","row","run","old","jam","cut","bay","pin","lot","era","bin","bag","man","try",
        "bad","hit","tie","see","bet","bar","pan","nun","fur","few","pig","pat","cup","eat", "drama", "money", "track", "shake", "evoke", "bacon", "heart",
        "noble", "stall", "brave", "crude", "snake", "title", "uncle", "allow", "mouth", "habit", "strip",
        "learn", "onion", "funny", "crown", "movie", "asset", "brand", "linen", "ivory", "index", "whole",
        "guest", "color", "draft", "shark", "fling", "sheep", "grain", "bless", "begin", "fairy", "fight", "stomach","impound","predict","offense","fighter","persist",
        "hallway","steward","pasture","laundry","country","soprano","splurge","auditor","quarrel","scatter",
        "chapter","digital","feather","precede","command","skilled","nuclear","nervous","retreat","version",
        "calorie","vehicle","fantasy","general","explode","plastic","funeral","limited","crystal","cutting",
        "perfume","section","achieve", "size", "lift", "user", "view", "idea", "fire", "find",
        "dead", "pack", "chew", "tape", "rare", "star", "skip", "prey", "fuel", "free", "easy", "roll",
        "mars", "load", "sign", "open", "leaf", "form", "shop", "soul", "sour", "riot", "dorm", "time",
        "text", "past", "bald", "eaux", "aunt", "stab", "hall", "plot", "crop" };






    private static string[] colorWordList = { "BLUE", "GREEN", "RED", "YELLOW", "WHITE", "ORANGE" };

    private static string[] colorList = { "blue", "green", "red","yellow", "white" , "orange"  };

    public static string GetRandomColor()
    {
        int randomIndex = Random.Range(0, colorList.Length);
        string randomColor = colorList[randomIndex];
        return randomColor;
       
    }

    public static string GetRandomWord()
    {
        
        int randomIndex = Random.Range(0, colorWordList.Length);
        string randomWord = colorWordList[randomIndex];
       
        return randomWord;
        
    }

    public static string GetRandomTypeWord1()
    {

        int randomIndex = Random.Range(0, wordList1.Length);
        string randomTypeWord = wordList1[randomIndex];
       
        return randomTypeWord;
    }

    public static string GetRandomTypeWord2()
    {

        int randomIndex = Random.Range(0, wordList2.Length);
        string randomTypeWord = wordList2[randomIndex];

        return randomTypeWord;
    }

    public static string GetRandomTypeWord3()
    {

        int randomIndex = Random.Range(0, wordList3.Length);
        string randomTypeWord = wordList3[randomIndex];

        return randomTypeWord;
    }

    public static string GetRandomTypeWord4()
    {

        int randomIndex = Random.Range(0, wordList4.Length);
        string randomTypeWord = wordList4[randomIndex];

        return randomTypeWord;
    }

    public static string GetRandomTypeWord5()
    {

        int randomIndex = Random.Range(0, wordList5.Length);
        string randomTypeWord = wordList5[randomIndex];

        return randomTypeWord;
    }
    public static string GetRandomTypeWord6()
    {

        int randomIndex = Random.Range(0, wordList6.Length);
        string randomTypeWord = wordList6[randomIndex];

        return randomTypeWord;
    }
    public static string GetRandomTypeWord7()
    {

        int randomIndex = Random.Range(0, wordList7.Length);
        string randomTypeWord = wordList7[randomIndex];

        return randomTypeWord;
    }
    public static string GetRandomTypeWord8()
    {

        int randomIndex = Random.Range(0, wordList8.Length);
        string randomTypeWord = wordList8[randomIndex];

        return randomTypeWord;
    }
    public static string GetRandomTypeWord9()
    {

        int randomIndex = Random.Range(0, wordList9.Length);
        string randomTypeWord = wordList9[randomIndex];

        return randomTypeWord;
    }

    public static string GetRandomBonusWord()
    {

        int randomIndex = Random.Range(0, bonusWordList.Length);
        string randomWord = bonusWordList[randomIndex];

        return randomWord;

    }










}
