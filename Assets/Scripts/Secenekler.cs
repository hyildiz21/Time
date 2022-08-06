using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Secenekler
{
    //PlayerPrefs

    public static string muzik = "muzik";

    public static void MuzikDegerAta(int muzikAcik)
    {
        PlayerPrefs.SetInt(Secenekler.muzik, muzikAcik);
    }

    public static int MuzikDegerOku()
    {
        return PlayerPrefs.GetInt(Secenekler.muzik);
    }


    public static bool MuzikKayitVarMi()
    {
        if (PlayerPrefs.HasKey(Secenekler.muzik))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
