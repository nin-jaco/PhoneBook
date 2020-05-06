using System;
using System.Configuration;
using System.IO;
using System.Runtime.Serialization;
using CIB.PhoneBook.Shared.Extensions;
using CIB.PhoneBook.Shared.Helpers;

namespace CIB.PhoneBook.Shared.BaseClasses
{
    [Serializable]
    [DataContract]
    public class ApiBase 
    {
        [DataMember]
        public string ApiPath { get; set; }
        [DataMember]
        public string VirtualApiPath { get; set; }
        [DataMember] public string ApiContentPath { get; set; }
        [DataMember] public string ApiLogPath { get; set; }
        [DataMember] public string ApiItemPath { get; set; }
        [DataMember] public string VirtualItemPath { get; set; }

        private string NetworkLocation { get; } = ConfigurationManager.AppSettings["NetworkLocation"];

        public ApiBase(string virtualDirectory, int idDealer, int idUser, int idContact, string itemId)
        {
            ApiPath = GetApiPath(virtualDirectory);
            ApiContentPath = GetContentPath();
            ApiLogPath = GetLogsPath();
            ApiItemPath = GetItemPath(idDealer.ToString(), idUser.ToString(), idContact.ToString(), itemId);
            VirtualItemPath = MapPathReverse();
        }

        public ApiBase(string virtualDirectory, int idDealer, int idUser)
        {
            ApiPath = GetApiPath(virtualDirectory);
            ApiContentPath = GetContentPath();
            ApiLogPath = GetLogsPath();
            ApiItemPath = GetItemPath(idDealer.ToString(), idUser.ToString(), "", "");
            VirtualItemPath = MapPathReverse();
        }

        public ApiBase(string virtualDirectory)
        {
            ApiPath = GetApiPath(virtualDirectory);
            ApiContentPath = GetContentPath();
            ApiLogPath = GetLogsPath();
            ApiItemPath = ApiContentPath;
            VirtualItemPath = MapPathReverse();
        }

        private string GetApiPath(string virtualDirectory)
        {
            return DirectoryHelper.CreateDirectory(Path.Combine(NetworkLocation, virtualDirectory));
        }

        private string GetContentPath()
        {
            return DirectoryHelper.CreateDirectory(Path.Combine(ApiPath, "Content"));
        }

        private string GetLogsPath()
        {
            return DirectoryHelper.CreateDirectory(Path.Combine(ApiPath, "Logs"));
        }

        private string GetItemPath(string pathOne, string pathTwo, string pathThree, string pathFour)
        {
            if (pathFour.IsNullOrWhitespace())
            {
                if (pathThree.IsNullOrWhitespace())
                {
                    if (pathTwo.IsNullOrWhitespace())
                    {
                        return DirectoryHelper.CreateDirectory(Path.Combine(ApiContentPath, pathOne));
                    }
                    return DirectoryHelper.CreateDirectory(Path.Combine(ApiContentPath, pathOne, pathTwo));
                }
                return DirectoryHelper.CreateDirectory(Path.Combine(ApiContentPath, pathOne, pathTwo, pathThree));
            }
            return DirectoryHelper.CreateDirectory(Path.Combine(ApiContentPath, pathOne, pathTwo, pathThree, pathFour));
        }



        public string MapPathReverse()
        {
            var path = ApiItemPath.Replace(NetworkLocation, "~/");
            if (path.Contains(@"\"))
            {
                path = path.Replace(@"\", "/");
            }

            return path;
        }

        //            ApiPath = DirectoryHelper.CreateDirectory(HttpContext.Current.Request.MapPath(virtualDirectory));
    }
}
