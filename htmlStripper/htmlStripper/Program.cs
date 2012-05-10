using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;

namespace htmlStripper
{
    class Program
    {
        struct champData
        {
            public String champName;

            public double initialStr;
            public double initialAgi;
            public double initialInt;

            public double strGrowth;
            public double agiGrowth;
            public double intGrowth;

            public double movSpeed;
            public double armor;
            public double range;


        }

        struct itemData
        {
            public String itemName;
             
            public int cost;

            public String strMod;
            public String intMod;
            public String agiMod;

            public String damageMod;

            public String allAttributesMod;


        }

        static public void ProcessChamps()
        {
            //FileInfo fo = new FileInfo("F:\Dota2Wiki\scrape\spider\www.dota2wiki.com\wiki\agilityChamps.html");
            String heroDir = "F:\\Dota2Wiki\\scrape\\spider\\www.dotafire.com\\dota-2\\hero";
            DirectoryInfo dir = new DirectoryInfo(heroDir);
            IEnumerable<FileInfo> files = dir.EnumerateFiles();

            champData[] champs = new champData[files.Count()];

            StreamReader reader;
            string line, tempString;

            bool inStatsSection = false;

            int champIndex = 0;

            int parseIndex = 0;
            int startValueIndex = 0;
            int endValueIndex = 0;
            
            foreach(FileInfo fi in files)
            {
                if(!(fi.Name.StartsWith("-")))
                {
                    reader = fi.OpenText();
                    while ((line = reader.ReadLine()) != null)
                    {
                        if(line.Contains("Stats"))
                        {
                            inStatsSection = true;
                        }
                        else if(line.Contains("skills-box"))
                        {
                            inStatsSection = false;
                        }

                        if(inStatsSection)
                        {
                            parseIndex = line.IndexOf('&');
                            champs[champIndex].champName = line.Substring(4, parseIndex - 4);
                            
                            line = reader.ReadLine();
                            line = reader.ReadLine();


                            parseIndex = line.IndexOf("STR");
                            if (parseIndex != -1)
                            {
                                startValueIndex = line.IndexOf('(', parseIndex) + 1;
                                endValueIndex = line.IndexOf('+', startValueIndex);
                                tempString = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                                champs[champIndex].initialStr = Convert.ToDouble(tempString);


                                startValueIndex = endValueIndex + 2;
                                endValueIndex = line.IndexOf("/level", startValueIndex);
                                tempString = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                                champs[champIndex].strGrowth = Convert.ToDouble(tempString);
                            }

                            parseIndex = line.IndexOf("AGI");
                            if (parseIndex != -1)
                            {
                                startValueIndex = line.IndexOf('(', parseIndex) + 1;
                                endValueIndex = line.IndexOf('+', startValueIndex);
                                tempString = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                                champs[champIndex].initialAgi = Convert.ToDouble(tempString);

                                startValueIndex = endValueIndex + 2;
                                endValueIndex = line.IndexOf("/level", startValueIndex);
                                tempString = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                                champs[champIndex].agiGrowth = Convert.ToDouble(tempString);
                            }

                            parseIndex = line.IndexOf("INT");
                            if (parseIndex != -1)
                            {
                                startValueIndex = line.IndexOf('(', parseIndex) + 1;
                                endValueIndex = line.IndexOf('+', startValueIndex);
                                tempString = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                                champs[champIndex].initialInt = Convert.ToDouble(tempString);

                                startValueIndex = endValueIndex + 2;
                                endValueIndex = line.IndexOf("/level", startValueIndex);
                                tempString = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                                champs[champIndex].intGrowth = Convert.ToDouble(tempString);
                            }
                            
                            line = reader.ReadLine();

                            parseIndex = line.IndexOf("Range");
                            if (parseIndex != -1)
                            {
                                startValueIndex = line.IndexOf("hiliteG", parseIndex) + 9;
                                endValueIndex = line.IndexOf("/span", startValueIndex) - 1;
                                tempString = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                                champs[champIndex].range = Convert.ToDouble(tempString);
                            }


                            parseIndex = line.IndexOf("Armor");
                            if (parseIndex != -1)
                            {
                                startValueIndex = line.IndexOf("hiliteG", parseIndex) + 9;
                                endValueIndex = line.IndexOf("/span", startValueIndex) - 1;
                                tempString = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                                champs[champIndex].armor = Convert.ToDouble(tempString);
                            }


                            parseIndex = line.IndexOf("Movement");
                            if (parseIndex != -1)
                            {
                                startValueIndex = line.IndexOf("hiliteG", parseIndex) + 9;
                                endValueIndex = line.IndexOf("/span", startValueIndex) - 1;
                                tempString = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                                champs[champIndex].movSpeed = Convert.ToDouble(tempString);
                            }
                            //tempString = "";
                        }
                    }
                    champIndex++;
                }
            }

            //StreamReader reader = fo.OpenText();
            //String line;
            //while ((line = reader.ReadLine()) != null) 
            //{
            //    string items[] = line.Split('\t');
            //    int myInteger = int.Parse(items[1]); // Here's your integer.
            //    // Now let's find the path.
            //    string path = null;
            //    foreach (string item in items) {
            //        if (item.StartsWith("item\\") && item.EndsWith(".ddj")) {
            //            path = item;
            //        }
            //    }

            //    // At this point, `myInteger` and `path` contain the values we want
            //    // for the current line. We can then store those values or print them,
            //    // or anything else we like.
            //}

            int printIter = 0;

            //StreamWriter newFile = new StreamWriter("F:\\Dota2Wiki\\Champs.csv");

            //if(newFile != null)
            //{
            //    newFile.AutoFlush = true;
            //    while (printIter < champIndex)
            //    {
            //        newFile.WriteLine(champs[printIter].champName + ","
            //            + champs[printIter].initialStr.ToString() + ","
            //            + champs[printIter].strGrowth.ToString() + ","
            //            + champs[printIter].initialAgi.ToString() + ","
            //            + champs[printIter].agiGrowth.ToString() + ","
            //            + champs[printIter].initialInt.ToString() + ","
            //            + champs[printIter].intGrowth.ToString() + ","
            //            + champs[printIter].range.ToString() + ","
            //            + champs[printIter].movSpeed.ToString() + ","
            //            + champs[printIter].armor.ToString());
            //        printIter++;
            //    }
            //    newFile.Close();
            //}

            SqlConnection localDB = new SqlConnection(Properties.Settings.Default.DOTA2BuildCalculatorConnectionString);

            SqlCommand insertCommand;
            SqlCommand checkCommand;
            SqlDataReader checkResult;

            printIter = 0;

            localDB.Open();

            while (printIter < champIndex)
            {
                checkCommand = new SqlCommand("Select ChampionName from Champions where ChampionName like '" + champs[printIter].champName + "'", localDB);
                
                checkResult = checkCommand.ExecuteReader();

                if (!checkResult.HasRows)
                {
                    //(ChampionName, initialStr, initialAgi, initialInt, strGrowth, agiGrowth, intGrowth, movSpeed, armor, range) 
                    checkResult.Close();
                    insertCommand = new SqlCommand("INSERT into Champions values ('" + champs[printIter].champName + "',"
                                    + champs[printIter].initialStr.ToString() + ","
                                    + champs[printIter].initialAgi.ToString() + ","
                                    + champs[printIter].initialInt.ToString() + ","
                                    + champs[printIter].strGrowth.ToString() + ","
                                    + champs[printIter].agiGrowth.ToString() + ","
                                    + champs[printIter].intGrowth.ToString() + ","
                                    + champs[printIter].movSpeed.ToString() + ","
                                    + champs[printIter].armor.ToString() + ","
                                    + champs[printIter].range.ToString() + ")", localDB);

                    int rows = insertCommand.ExecuteNonQuery();
                    //insertCommand.
                }
                else
                    checkResult.Close();
                printIter++;
            }

            localDB.Close();

            int poop;

        }

        static public void ProcessItems()
        {
            String itemDir = "F:\\Dota2Wiki\\scrape\\spider\\www.dotafire.com\\dota-2\\item";
            DirectoryInfo dir = new DirectoryInfo(itemDir);
            IEnumerable<FileInfo> files = dir.EnumerateFiles();

            itemData[] items = new itemData[files.Count()];

            StreamReader reader;
            string line, tempString;

            bool inStatsSection = false;

            int itemIndex = 0;

            int parseIndex = 0;
            int startValueIndex = 0;
            int endValueIndex = 0;

            foreach (FileInfo fi in files)
            {
                reader = fi.OpenText();
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("Recipe Cost:") || line.Contains("Details"))
                    {
                        inStatsSection = true;
                    }
                    else if (line.Contains("Discussion"))
                    {
                        inStatsSection = false;
                    }

                    if (inStatsSection)
                    {
                        //get to cost line
                        if(line.Contains("Recipe Cost"))
                        {
                            line = reader.ReadLine();

                            parseIndex = line.IndexOf('>');
                            items[itemIndex].cost = Convert.ToInt32(line.Substring(parseIndex+1));
                        }


                        while (!line.Contains("hiliteO"))
                        {
                            line = reader.ReadLine();
                        }


                        parseIndex = line.IndexOf('>');
                        startValueIndex = parseIndex + 1;
                        endValueIndex = line.IndexOf("</h2>");
                        items[itemIndex].itemName = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                            
                        line = reader.ReadLine();

                        if (line.Contains("Damage") || line.Contains("damage"))
                        {
                            startValueIndex = line.IndexOf('+') + 1;
                            endValueIndex = line.IndexOf("Damage", startValueIndex) - 1;
                            if (endValueIndex == -2)
                                endValueIndex = line.IndexOf("damage", startValueIndex) - 1;
                            items[itemIndex].damageMod = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                        }
                        else if (line.Contains("Strength") || line.Contains("strength"))
                        {
                            startValueIndex = line.IndexOf('+') + 1;
                            endValueIndex = line.IndexOf("Strength", startValueIndex) - 1;
                            if(endValueIndex == -2)
                                endValueIndex = line.IndexOf("strength", startValueIndex) - 1;
                            items[itemIndex].strMod = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                        }
                        else if (line.Contains("Intelligence") || line.Contains("intelligence"))
                        {
                            startValueIndex = line.IndexOf('+') + 1;
                            endValueIndex = line.IndexOf("Intelligence", startValueIndex) - 1;
                            if (endValueIndex == -2)
                                endValueIndex = line.IndexOf("intelligence", startValueIndex) - 1;
                            items[itemIndex].intMod = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                        }
                        else if (line.Contains("Agility") || line.Contains("agility"))
                        {
                            startValueIndex = line.IndexOf('+') + 1;
                            endValueIndex = line.IndexOf("Agility", startValueIndex) - 1;
                            if (endValueIndex == -2)
                                endValueIndex = line.IndexOf("agility", startValueIndex) - 1;
                            items[itemIndex].agiMod = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                        }
                        else if (line.Contains("All") || line.Contains("all"))
                        {
                            startValueIndex = line.IndexOf('+') + 1;
                            endValueIndex = line.IndexOf("All", startValueIndex) - 1;
                            if (endValueIndex == -2)
                                endValueIndex = line.IndexOf("all", startValueIndex) - 1;
                            items[itemIndex].allAttributesMod = line.Substring(startValueIndex, endValueIndex - startValueIndex);
                        }

                        inStatsSection = false;
                    }
                }
                itemIndex++;
            }


            int printIter = 0;

            //StreamWriter newFile = new StreamWriter("F:\\Dota2Wiki\\Items.csv");

            //if (newFile != null)
            //{
            //    newFile.AutoFlush = true;
            //    while (printIter < itemIndex)
            //    {
            //        newFile.WriteLine(items[printIter].itemName + ","
            //            + (items[printIter].cost == null ? String.Empty : items[printIter].cost.ToString()) + ","
            //            + (items[printIter].allAttributesMod == null ? String.Empty : items[printIter].allAttributesMod) + ","
            //            + (items[printIter].strMod == null ? String.Empty : items[printIter].strMod) + ","
            //            + (items[printIter].agiMod == null ? String.Empty : items[printIter].agiMod) + ","
            //            + (items[printIter].intMod == null ? String.Empty : items[printIter].intMod) + ","
            //            + (items[printIter].damageMod == null ? String.Empty : items[printIter].damageMod));
            //        printIter++;
            //    }
            //    newFile.Close();
            //}



            SqlConnection localDB = new SqlConnection(Properties.Settings.Default.DOTA2BuildCalculatorConnectionString);

            SqlCommand insertCommand;
            SqlCommand checkCommand;
            SqlDataReader checkResult;

            printIter = 0;

            localDB.Open();

            while (printIter < itemIndex)
            {
                checkCommand = new SqlCommand("Select ItemName from Items where ItemName like '" + items[printIter].itemName + "'", localDB);

                checkResult = checkCommand.ExecuteReader();

                if (!checkResult.HasRows)
                {
                    //(ChampionName, initialStr, initialAgi, initialInt, strGrowth, agiGrowth, intGrowth, movSpeed, armor, range) 
                    checkResult.Close();
                    insertCommand = new SqlCommand("INSERT into Items values ('" + items[printIter].itemName + "','"
                        + (items[printIter].cost == null ? String.Empty : items[printIter].cost.ToString()) + "','"
                        + (items[printIter].strMod == null ? String.Empty : items[printIter].strMod) + "','"
                        + (items[printIter].intMod == null ? String.Empty : items[printIter].intMod) + "','"
                        + (items[printIter].agiMod == null ? String.Empty : items[printIter].agiMod) + "','"
                        + (items[printIter].damageMod == null ? String.Empty : items[printIter].damageMod) + "','" 
                        + (items[printIter].allAttributesMod == null ? String.Empty : items[printIter].allAttributesMod) + "')", localDB);

                    int rows = insertCommand.ExecuteNonQuery();
                    //insertCommand.
                }
                else
                    checkResult.Close();
                printIter++;
            }

            localDB.Close();


            int poop;

        }

        static public void ImportToDB()
        {

        }



        static void Main(string[] args)
        {
            ProcessChamps();
            ProcessItems();
        }

    }
}
