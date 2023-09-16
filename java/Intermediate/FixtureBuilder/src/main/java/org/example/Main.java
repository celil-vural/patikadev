package org.example;
import java.util.*;
public class Main {
    public static void main(String[] args) {
        Random ran = new Random();
        Set<String> teams = new TreeSet<>();
        teams.add("Gs");
        teams.add("Fener");
        teams.add("Başakşehir");
        teams.add("Bjk");
        if (teams.size() % 2 == 1) teams.add("BAY");
        int randomNumber, week=0, isThereAre=0, totalWeek = (teams.size() - 1) * 2, weeklyMatch = teams.size() / 2;
        String temp="";
        boolean loop = true;
        String[][] fixture = new String[totalWeek][weeklyMatch];
        String[] weekControl = new String[(teams.size())];
        List<String> teamsTemp = new ArrayList<>(teams);
        for (int i = 0; i < teams.size()-1; i++) {
            while (loop) {
                teamsTemp.clear();
                teamsTemp.addAll(teams);
                for (int j = 0; j < teams.size(); j++) {
                    randomNumber = ran.nextInt(teamsTemp.size());
                    if (j % 2 == 0) {
                        temp = teamsTemp.get(randomNumber);
                        teamsTemp.remove(randomNumber);
                    }
                    else {
                        weekControl[j / 2] = temp + " - " + teamsTemp.get(randomNumber);
                        weekControl[(j / 2) + weeklyMatch] = teamsTemp.get(randomNumber) + " - " + temp;
                        teamsTemp.remove(randomNumber);
                    }
                }
                if (week == 0) break;
                for (int z = 0; z < week; z++) {
                    for (int j = 0; j < weeklyMatch; j++) {
                        for (int k = 0; k < teams.size(); k++){
                            if (fixture[z][j].equals(weekControl[k]) || fixture[week-1][j].startsWith(temp)) isThereAre++;
                        }
                    }
                }
                if (isThereAre==0) loop=false;
                isThereAre=0;
            }
            for (int sutun = 0; sutun<weeklyMatch; sutun++){
                fixture[week][sutun] = weekControl[sutun];
                fixture[week+(teams.size()-1)][sutun] = weekControl[sutun+weeklyMatch];
            }
            week++;
            loop=true;
        }
        for (int i=0; i<totalWeek; i++){
            System.out.println("\n" + (i+1) + ". Hafta: ");
            for (int j=0; j<weeklyMatch; j++){
                System.out.println(fixture[i][j]);
            }
        }
    }
}