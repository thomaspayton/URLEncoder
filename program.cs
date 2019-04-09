
using System;

namespace URLEncolder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // naming/getting varibles

            Console.WriteLine("Project Name:\n");

            string projectname = Console.ReadLine();

            Console.WriteLine("Activity Name:\n");

            string activityname = Console.ReadLine();

            //delimiter's for project 

            projectname = projectname.Replace("%", "%25");
            projectname = projectname.Replace(" ", "%20");
            projectname = projectname.Replace("<", "%3C");
            projectname = projectname.Replace(">", "%3E");
            projectname = projectname.Replace("#", "%23");
            projectname = projectname.Replace("\"", "%22");

            //special characters for project

            projectname = projectname.Replace(";", "%3B");
            projectname = projectname.Replace("/", "%2F");
            projectname = projectname.Replace(":", "%3A");
            projectname = projectname.Replace("@", "%40");
            projectname = projectname.Replace("&", "%26");
            projectname = projectname.Replace("=", "%3D");
            projectname = projectname.Replace("+", "%2B");
            projectname = projectname.Replace("$", "%24");
            projectname = projectname.Replace(",", "%2C");

            // other special characters for project

            projectname = projectname.Replace("{", "%7B");
            projectname = projectname.Replace("}", "%7D");
            projectname = projectname.Replace("|", "%7C");
            projectname = projectname.Replace("\\", "%5C");
            projectname = projectname.Replace("^", "%5E");
            projectname = projectname.Replace("[", "%5B");
            projectname = projectname.Replace("]", "%5D");
            projectname = projectname.Replace("`", "%80");

            //delimiter's for activity

            activityname = activityname.Replace("%", "%25");
            activityname = activityname.Replace(" ", "%20");
            activityname = activityname.Replace("<", "%3C");
            activityname = activityname.Replace(">", "%3E");
            activityname = activityname.Replace("#", "%23");
            activityname = activityname.Replace("\"", "%22");

            //special characters for activity

            activityname = activityname.Replace(";", "%3B");
            activityname = activityname.Replace("/", "%2F");
            activityname = activityname.Replace(":", "%3A");
            activityname = activityname.Replace("@", "%40");
            activityname = activityname.Replace("&", "%26");
            activityname = activityname.Replace("=", "%3D");
            activityname = activityname.Replace("+", "%2B");
            activityname = activityname.Replace("$", "%24");
            activityname = activityname.Replace(",", "%2C");

            // other special characters for activity

            activityname = activityname.Replace("{", "%7B");
            activityname = activityname.Replace("}", "%7D");
            activityname = activityname.Replace("|", "%7C");
            activityname = activityname.Replace("\\", "%5C");
            activityname = activityname.Replace("^", "%5E");
            activityname = activityname.Replace("[", "%5B");
            activityname = activityname.Replace("]", "%5D");
            activityname = activityname.Replace("`", "%80");

            //website

            Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", projectname, activityname);

           
        }
    }
}
