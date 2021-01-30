using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Score : MonoBehaviour
{
    public static int score = 0;
    public static int totalScore = 0;
    public  enum SunStatus
    {
        CoolSun,
        SleepingSun
    }

    public static SunStatus sunstatus = SunStatus.SleepingSun;
    public static bool sunFlag = false;
    public int magnification = 0;

    public static bool humanStatus = false;


    public static  int scorePlus(int ratio){

        score = 0;
        if(!sunFlag){
            return 2;
        }

        if(sunstatus == SunStatus.CoolSun){
            score = 100 * ratio;
            totalScore += 100 * ratio;
            sunFlag = false;
            return 0;
        }
        if(sunstatus == SunStatus.SleepingSun){
            score = 30 * ratio;
            totalScore += 30 * ratio;
            sunFlag = false;

            return 1;
        }

        return 2;
    }

    public static void susStatus_sleeping(){
        sunstatus = SunStatus.SleepingSun;
    }
    public static void susStatus_cool(){
        sunstatus = SunStatus.CoolSun;
    }

        public static  int scorePlus_human(int ratio){

        score = 0;
        if(!sunFlag){
            return 3;
        }

        if(sunstatus == SunStatus.CoolSun && humanStatus == true){
            score = 200 * ratio;
            totalScore += 200 * ratio;
            sunFlag = false;
            humanStatus =false;
            return 0;
        }

        if(sunstatus == SunStatus.CoolSun){
            score = 100 * ratio;
            totalScore += 100 * ratio;
            sunFlag = false;
            return 1;
        }

        if(sunstatus == SunStatus.SleepingSun){
            score = 50 * ratio;
            totalScore += 50 * ratio;
            sunFlag = false;
            humanStatus = false;

            return 2;
        }

        return 3;
    }
}
