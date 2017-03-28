using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBinding {
    class MembershipData {
        private const string dir = @"C:\Users\sinci\Documents\Visual Studio 2015\Projects\PracticeBinding\PracticeBinding\";
        private const string path = dir + "Members.txt";
        static string[] columns;
        static List<User> member; //creates a list of members

        //sends back lsit of memebrs
        public static List<User> GetMemberships() {
            member = new List<User>();
            //open file to read
            StreamReader sr = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            while (sr.Peek() != -1) { //while more to read
                string line = sr.ReadLine();
                columns = line.Split('|'); //splits line into 3 values
                member.Add(new User(columns[0], columns[1], columns[2]));
            }
            sr.Close();
            return member; //return list

        }

        //saves membership list to the text file
        public void SaveMemberships(List<User> members) {
            // create the output stream for a text file that exists
            StreamWriter textOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            // write each customer from the list to the file
            foreach (User member in members) {
                textOut.Write(member.Name + "|");
                textOut.Write(member.LastName + "|");
                textOut.WriteLine(member.Email);
            }
            textOut.Close();
        }
        
    }
}
