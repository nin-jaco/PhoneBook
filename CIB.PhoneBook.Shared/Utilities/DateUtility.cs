using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.UI.WebControls;

namespace CIB.PhoneBook.Shared.Utilities
{
    public static class DateUtility
    {
        public static List<string> GetListOfLastTwentyYears()
        {
            var years = new List<string> {DateTime.Now.AddYears(1).Year.ToString()};
            for (var i = DateTime.Now.Year; i > DateTime.Now.AddYears(-20).Year; i--)
            {
                years.Add(i.ToString());
            }
            return years;
        }

        public static void PopulateWithLastTwentyYears(this DropDownList dropDownList, bool showPleaseSelect = false)
        {
            dropDownList.DataSource = GetListOfLastTwentyYears();
            dropDownList.DataBind();

            if (showPleaseSelect)
            {
                //dropDownList.InsertPleaseSelect();
            }
        }

        public static void PopulateWithLastNYears(this DropDownList dropDownList, int nYears, bool showPleaseSelect = false)
        {
            var years = new List<string>();
            for (var i = DateTime.Now.Year + 1; i > DateTime.Now.AddYears(-nYears).Year; i--)
            {
                years.Add(i.ToString());
            }

            dropDownList.DataSource = years;
            dropDownList.DataBind();

            if(showPleaseSelect)
            {
                //dropDownList.InsertPleaseSelect();
            }
        }

        public static void PopulateWithNYearsStartingWith(this DropDownList dropDownList, int startYear, int numberofYears, bool showPleaseSelect = false)
        {
            var years = new List<string>();
            for (var i = 0; i <= numberofYears; i++)
            {
                years.Add((startYear - i).ToString());
            }

            dropDownList.DataSource = years;
            dropDownList.DataBind();

            if (showPleaseSelect)
            {
                //dropDownList.InsertPleaseSelect();
            }
        }


        public static void PopulateWithMonths(this DropDownList dropDownList, bool showPleaseSelect = false)
        {
            for (int i = 1; i < 13; i++)
            {
                var name = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                var item = new ListItem(name, i.ToString());
                dropDownList.Items.Add(item);
            }

            if (showPleaseSelect)
            {
                //dropDownList.InsertPleaseSelect();
            }
        }

        public static void PopulateWithDepartments(this DropDownList dropDownList, bool showPleaseSelect = false)
        {
            dropDownList.DataSource = new string[] { "ALL", "NEW", "USED" };
            dropDownList.DataBind();

            if (showPleaseSelect)
            {
                //dropDownList.InsertPleaseSelect();
            }
        }

        public static string ToMonthName(this int monthNumber)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber);
        }

        public static int MonthNameToInt(this string month)
        {
            return Array.IndexOf(
                        CultureInfo.CurrentCulture.DateTimeFormat.MonthNames,
                        month.ToLower(CultureInfo.CurrentCulture))
                    + 1;
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static DateTime JavaTimeStampToDateTime(double javaTimeStamp)
        {
            // Java timestamp is milliseconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(javaTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
