using System;
using System.Collections.Generic;

class KodePos
{
    private static Dictionary<string, string> kodePos = new Dictionary<string, string>()
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public static string getKodePos(string kelurahan)
    {
        return kodePos.ContainsKey(kelurahan) ? kodePos[kelurahan] : "Kode Pos Tidak Ditemukan";
    }
}
