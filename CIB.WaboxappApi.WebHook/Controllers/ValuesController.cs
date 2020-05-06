using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Web.Http;
using CIB.PhoneBook.Shared.Enums;
using CIB.PhoneBook.Shared.Extensions;
using CIB.PhoneBook.Shared.Models;
using CIB.PhoneBook.Shared.Utilities;
using CIB.WhatsAppApi.WebHook.Models;
using CIB.WhatsAppApi.WebHook.ObjectMethods;

namespace CIB.WhatsAppApi.WebHook.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        //url : http://solumedsrv.eastus.cloudapp.azure.com/CIB.Services.WhatsAppApi/api/values
        public void Post([FromBody]OMessage value)
        {
            try
            {
                var item = new WhatsAppHookMessageDto();
                item.EventType = value.@event;
                item.ContactName = value.contact.name;
                item.ContactType = value.contact.type;
                item.ContactUid = value.contact.uid;
                item.MessageCuid = value.message.cuid;
                item.MessageDate = DateUtility.UnixTimeStampToDateTime(value.message.dtm.ToInt());
                item.MessageDirection = value.message.dir;
                item.MessageType = value.message.type;
                item.MessageUid = value.message.uid;
                item.Token = value.token;
                item.IdContact = GetIdContactFromMessageCuid(value.message.cuid);
                switch (value.message.type)
                {
                    case "audio":
                        item.WhatsAppHookAudioCaption = value.message.body.caption;
                        item.WhatsAppHookAudioDuration = value.message.body.duration;
                        item.WhatsAppHookAudioForeignUrl = value.message.body.url;
                        item.WhatsAppHookAudioLocalUrl = DownloadFileFromUrl(value.message.body.url);
                        item.WhatsAppHookAudioMimeType = value.message.body.mimetype;
                        item.WhatsAppHookAudioSize = value.message.body.size;
                        break;
                    case "document":
                        item.WhatsAppHookDocumentCaption = value.message.body.caption;
                        item.WhatsAppHookDocumentMimeType = value.message.body.mimetype;
                        item.WhatsAppHookDocumentSize = value.message.body.size;
                        item.WhatsAppHookDocumentThumbnail = value.message.body.thumb;
                        item.WhatsAppHookDocumentForeignUrl = value.message.body.url;
                        item.WhatsAppHookDocumentLocalUrl = DownloadFileFromUrl(value.message.body.url);
                        break;
                    case "chat":
                        item.WhatsAppHookTextText = value.message.body.text;
                        break;
                    case "image":
                        item.WhatsAppHookImageCaption = value.message.body.caption;
                        item.WhatsAppHookImageMimeType = value.message.body.mimetype;
                        item.WhatsAppHookImageSize = value.message.body.size;
                        item.WhatsAppHookImageThumbnail = value.message.body.thumb;
                        item.WhatsAppHookImageForeignUrl = value.message.body.url;
                        item.WhatsAppHookImageLocalUrl = DownloadFileFromUrl(value.message.body.url);
                        break;
                    case "video":
                        item.WhatsAppHookVideoCaption = value.message.body.caption;
                        item.WhatsAppHookVideoMimeType = value.message.body.mimetype;
                        item.WhatsAppHookVideoSize = value.message.body.size;
                        item.WhatsAppHookVideoDuration = value.message.body.duration;
                        item.WhatsAppHookVideoThumbnail = value.message.body.thumb;
                        item.WhatsAppHookVideoForeignUrl = value.message.body.url;
                        item.WhatsAppHookVideoLocalUrl = DownloadFileFromUrl(value.message.body.url);
                        break;
                    case "ptt":
                        item.WhatsAppHookPttCaption = value.message.body.caption;
                        item.WhatsAppHookPttMimeType = value.message.body.mimetype;
                        item.WhatsAppHookPttSize = value.message.body.size;
                        item.WhatsAppHookPttDuration = value.message.body.duration;
                        item.WhatsAppHookPttForeignUrl = value.message.body.url;
                        item.WhatsAppHookPttLocalUrl = DownloadFileFromUrl(value.message.body.url);
                        break;
                    case "vcard":
                        item.WhatsAppHookVCardContact = value.message.body.contact;
                        //todo: update with vcard information when it is available
                        break;
                    case "location":
                        item.WhatsAppHookLocationName = value.message.body.name;
                        item.WhatsAppHookLocationLongitude = value.message.body.lng;
                        item.WhatsAppHookLocationLatitude = value.message.body.lat;
                        item.WhatsAppHookLocationThumbnail = value.message.body.thumb;
                        item.WhatsAppHookLocationForeignUrl = value.message.body.url;
                        item.WhatsAppHookLocationLocalUrl = value.message.body.url;
                        break;
                }
                
                item = WhatsAppHookMethods.Create(item);
                //todo: do something with result

                /*
                string path = @"c:\MotovateOnTheMove\WhatsAppResult.txt";
                //if (!File.Exists(path))
                //{
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine($@"step 1: creating file");
                        sw.WriteLine($@"step 2: writing file");
                        sw.WriteLine($@"event: {value.@event}");
                        sw.WriteLine($@"token: {value.token}");
                        sw.WriteLine($@"uid: {value.uid}");
                        sw.WriteLine($@"contact uid: {value.contact.uid}");
                        sw.WriteLine($@"contact name: {value.contact.name}");
                        sw.WriteLine($@"contact type: {value.contact.type}");
                        sw.WriteLine($@"message dtm: {value.message.dtm}");
                        sw.WriteLine($@"message uid: {value.message.uid}");
                        sw.WriteLine($@"message cuid: {value.message.cuid}");
                        sw.WriteLine($@"message dir: {value.message.dir}");
                        sw.WriteLine($@"message type: {value.message.type}");
                        switch (value.message.type)
                        {
                            case "chat":
                                sw.WriteLine($@"message body text: {value.message.body.text}");
                                break;
                            case "image":
                                var image = value.message.body.image;
                                if (image != null)
                                {
                                    sw.WriteLine($@"image caption: {image.caption}");
                                    sw.WriteLine($@"image mimetype: {image.mimetype}");
                                    sw.WriteLine($@"image size: {image.size}");
                                    sw.WriteLine($@"image thumb: {image.thumb}");
                                    sw.WriteLine($@"image url: {image.url}");
                                }
                                break;
                            case "video":
                                var video = value.message.body.video;
                                if (video != null)
                                {
                                    sw.WriteLine($@"video caption: {video.caption}");
                                    sw.WriteLine($@"video mimetype: {video.mimetype}");
                                    sw.WriteLine($@"video size: {video.size}");
                                    sw.WriteLine($@"video duration: {video.duration} seconds");
                                    sw.WriteLine($@"video thumb: {video.thumb}");
                                    sw.WriteLine($@"video url: {video.url}");
                                }
                                break;
                            case "audio":
                                var audio = value.message.body.audio;
                                if (audio != null)
                                {
                                    sw.WriteLine($@"audio caption: {audio.caption}");
                                    sw.WriteLine($@"audio mimetype: {audio.mimetype}");
                                    sw.WriteLine($@"audio size: {audio.size}");
                                    sw.WriteLine($@"audio duration: {audio.duration} seconds");
                                    sw.WriteLine($@"audio url: {audio.url}");
                                }
                                break;
                            case "ptt":
                                var ptt = value.message.body.ptt;
                                if (ptt != null)
                                {
                                    sw.WriteLine($@"ptt caption: {ptt.caption}");
                                    sw.WriteLine($@"ptt mimetype: {ptt.mimetype}");
                                    sw.WriteLine($@"ptt size: {ptt.size}");
                                    sw.WriteLine($@"ptt duration: {ptt.duration}");
                                    sw.WriteLine($@"ptt url: {ptt.url}");
                                }
                                break;
                            case "document":
                                var document = value.message.body.document;
                                if (document != null)
                                {
                                    sw.WriteLine($@"document caption: {document.caption}");
                                    sw.WriteLine($@"document mimetype: {document.mimetype}");
                                    sw.WriteLine($@"document size: {document.size}");
                                    sw.WriteLine($@"document thumb: {document.thumb}");
                                    sw.WriteLine($@"document url: {document.url}");
                                }
                                break;
                            case "vcard":
                                var vcard = value.message.body.vcard;
                                if (vcard != null)
                                {
                                    sw.WriteLine($@"vcard contact: {vcard.contact}");
                                    sw.WriteLine($@"vcard vCard : {vcard.vCard}");
                                }
                                break;
                            case "location":
                                var location = value.message.body.location;
                                if (location != null)
                                {
                                    sw.WriteLine($@"location name: {location.name}");
                                    sw.WriteLine($@"location lng: {location.lng}");
                                    sw.WriteLine($@"location lat: {location.lat}");
                                    sw.WriteLine($@"location thumb: {location.thumb}");
                                    sw.WriteLine($@"location url: {location.url}");
                                }
                                break;
                        }
                        sw.WriteLine($@"message ack: {value.message.ack}");
                        //var result = Newtonsoft.Json.JsonConvert.DeserializeObject<ExpandoObject>(value);
                        sw.WriteLine($@"step 3: done");
                    }
                //}*/
            }
            catch (Exception ex)
            {
                //Log
            }
        }

        private int? GetIdContactFromMessageCuid(string messageCuid)
        {
            if (string.IsNullOrWhiteSpace(messageCuid) || (!messageCuid.Contains("C") && !messageCuid.Contains("S"))) return null;

            var id =  messageCuid.Remove(0, messageCuid.IndexOf("C", StringComparison.Ordinal) + 1)
                .Remove(messageCuid.IndexOf("S", StringComparison.Ordinal)).ToInt();
            return id == 0 ? (int?) null : id;
        }

        private static string DownloadFileFromUrl(string url)
        {
            if (!System.IO.Directory.Exists(ConfigurationManager.AppSettings["WhatsAppHookFilePath"]))
            {
                System.IO.Directory.CreateDirectory(ConfigurationManager.AppSettings["WhatsAppHookFilePath"]);
            }

            var client = new WebClient();
            var fileName = ConfigurationManager.AppSettings["WhatsAppHookFilePath"] +
                           url.Remove(0, url.LastIndexOf("/", StringComparison.Ordinal) +1);
            client.DownloadFile(url, fileName);
            return fileName;
        }




        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
