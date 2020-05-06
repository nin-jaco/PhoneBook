using System;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using CIB.PhoneBook.DAL.Dtos.Infrastructure;

namespace CIB.PhoneBook.Shared.Models
{
    [DataContract(Namespace = "MotovateOnTheMove.Models.Dto", Name = "WhatsAppHookMessageDto")]
    [KnownType(typeof(WhatsAppHookMessageDto))]
    public class WhatsAppHookMessageDto
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<int> IdContact { get; set; }
        [DataMember]
        public string EventType { get; set; }
        [DataMember]
        public string Token { get; set; }
        [DataMember]
        public string ContactUid { get; set; }
        [DataMember]
        public string ContactName { get; set; }
        [DataMember]
        public string ContactType { get; set; }

        [DataMember]
        public System.DateTime MessageDate { get; set; }
        [DataMember]
        public string MessageUid { get; set; }
        [DataMember]
        public string MessageCuid { get; set; }
        [DataMember]
        public string MessageDirection { get; set; }
        [DataMember]
        public string MessageType { get; set; }
        [DataMember]
        public Nullable<int> IdHookText { get; set; }
        [DataMember]
        public Nullable<int> IdHookImage { get; set; }
        [DataMember]
        public Nullable<int> IdHookVideo { get; set; }
        [DataMember]
        public Nullable<int> IdHookAudio { get; set; }
        [DataMember]
        public Nullable<int> IdHookPtt { get; set; }
        [DataMember]
        public Nullable<int> IdHookDocument { get; set; }
        [DataMember]
        public Nullable<int> IdHookVCard { get; set; }
        [DataMember]
        public Nullable<int> IdHookLocation { get; set; }
        [DataMember]
        public int WhatsAppHookAudioId { get; set; }
        [DataMember]
        public string WhatsAppHookAudioCaption { get; set; }
        [DataMember]
        public string WhatsAppHookAudioMimeType { get; set; }
        [DataMember]
        public int WhatsAppHookAudioDuration { get; set; }
        [DataMember]
        public int WhatsAppHookAudioSize { get; set; }
        [DataMember]
        public string WhatsAppHookAudioForeignUrl { get; set; }
        [DataMember]
        public string WhatsAppHookAudioLocalUrl { get; set; }
        [DataMember]
        public int WhatsAppHookDocumentId { get; set; }
        [DataMember]
        public string WhatsAppHookDocumentCaption { get; set; }
        [DataMember]
        public string WhatsAppHookDocumentMimeType { get; set; }
        [DataMember]
        public int WhatsAppHookDocumentSize { get; set; }
        [DataMember]
        public string WhatsAppHookDocumentThumbnail { get; set; }
        [DataMember]
        public string WhatsAppHookDocumentForeignUrl { get; set; }
        [DataMember]
        public string WhatsAppHookDocumentLocalUrl { get; set; }
        [DataMember]
        public int WhatsAppHookImageId { get; set; }
        [DataMember]
        public string WhatsAppHookImageCaption { get; set; }
        [DataMember]
        public string WhatsAppHookImageMimeType { get; set; }
        [DataMember]
        public int WhatsAppHookImageSize { get; set; }
        [DataMember]
        public string WhatsAppHookImageThumbnail { get; set; }
        [DataMember]
        public string WhatsAppHookImageForeignUrl { get; set; }
        [DataMember]
        public string WhatsAppHookImageLocalUrl { get; set; }
        [DataMember]
        public int WhatsAppHookLocationId { get; set; }
        [DataMember]
        public string WhatsAppHookLocationName { get; set; }
        [DataMember]
        public string WhatsAppHookLocationLongitude { get; set; }
        [DataMember]
        public string WhatsAppHookLocationLatitude { get; set; }
        [DataMember]
        public string WhatsAppHookLocationThumbnail { get; set; }
        [DataMember]
        public string WhatsAppHookLocationForeignUrl { get; set; }
        [DataMember]
        public string WhatsAppHookLocationLocalUrl { get; set; }
        [DataMember]
        public int WhatsAppHookPttId { get; set; }
        [DataMember]
        public string WhatsAppHookPttCaption { get; set; }
        [DataMember]
        public string WhatsAppHookPttMimeType { get; set; }
        [DataMember]
        public int WhatsAppHookPttDuration { get; set; }
        [DataMember]
        public int WhatsAppHookPttSize { get; set; }
        [DataMember]
        public string WhatsAppHookPttForeignUrl { get; set; }
        [DataMember]
        public string WhatsAppHookPttLocalUrl { get; set; }
        [DataMember]
        public int WhatsAppHookTextId { get; set; }
        [DataMember]
        public string WhatsAppHookTextText { get; set; }
        [DataMember]
        public int WhatsAppHookVCardId { get; set; }
        [DataMember]
        public string WhatsAppHookVCardContact { get; set; }
        [DataMember]
        public int WhatsAppHookVideoId { get; set; }
        [DataMember]
        public string WhatsAppHookVideoCaption { get; set; }
        [DataMember]
        public string WhatsAppHookVideoMimeType { get; set; }
        [DataMember]
        public int WhatsAppHookVideoDuration { get; set; }
        [DataMember]
        public int WhatsAppHookVideoSize { get; set; }
        [DataMember]
        public string WhatsAppHookVideoThumbnail { get; set; }
        [DataMember]
        public string WhatsAppHookVideoForeignUrl { get; set; }
        [DataMember]
        public string WhatsAppHookVideoLocalUrl { get; set; }

    }

    public class WhatsAppHookMessageDtoMapper : MapperBase<WhatsAppHookMessage, WhatsAppHookMessageDto>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 

        public override Expression<Func<WhatsAppHookMessage, WhatsAppHookMessageDto>> SelectorExpression
        {
            get
            {
                return ((Expression<Func<WhatsAppHookMessage, WhatsAppHookMessageDto>>)(p => new WhatsAppHookMessageDto()
                {
                    ////BCC/ BEGIN CUSTOM CODE SECTION 
                    ////ECC/ END CUSTOM CODE SECTION 
                    Id = p.Id,
                    IdContact = p.IdContact,
                    EventType = p.EventType,
                    Token = p.Token,
                    ContactUid = p.ContactUid,
                    ContactName = p.ContactName,
                    ContactType = p.ContactType,
                    MessageDate = p.MessageDate,
                    MessageUid = p.MessageUid,
                    MessageCuid = p.MessageCuid,
                    MessageDirection = p.MessageDirection,
                    MessageType = p.MessageType,
                    IdHookText = p.IdHookText,
                    IdHookImage = p.IdHookImage,
                    IdHookVideo = p.IdHookVideo,
                    IdHookAudio = p.IdHookAudio,
                    IdHookPtt = p.IdHookPtt,
                    IdHookDocument = p.IdHookDocument,
                    IdHookVCard = p.IdHookVCard,
                    IdHookLocation = p.IdHookLocation,
                    WhatsAppHookAudioId = p.WhatsAppHookAudio != null ? p.WhatsAppHookAudio.Id : default(int),
                    WhatsAppHookAudioCaption = p.WhatsAppHookAudio != null ? p.WhatsAppHookAudio.Caption : default(string),
                    WhatsAppHookAudioMimeType = p.WhatsAppHookAudio != null ? p.WhatsAppHookAudio.MimeType : default(string),
                    WhatsAppHookAudioDuration = p.WhatsAppHookAudio != null ? p.WhatsAppHookAudio.Duration : default(int),
                    WhatsAppHookAudioSize = p.WhatsAppHookAudio != null ? p.WhatsAppHookAudio.Size : default(int),
                    WhatsAppHookAudioForeignUrl = p.WhatsAppHookAudio != null ? p.WhatsAppHookAudio.ForeignUrl : default(string),
                    WhatsAppHookAudioLocalUrl = p.WhatsAppHookAudio != null ? p.WhatsAppHookAudio.LocalUrl : default(string),
                    WhatsAppHookDocumentId = p.WhatsAppHookDocument != null ? p.WhatsAppHookDocument.Id : default(int),
                    WhatsAppHookDocumentCaption = p.WhatsAppHookDocument != null ? p.WhatsAppHookDocument.Caption : default(string),
                    WhatsAppHookDocumentMimeType = p.WhatsAppHookDocument != null ? p.WhatsAppHookDocument.MimeType : default(string),
                    WhatsAppHookDocumentSize = p.WhatsAppHookDocument != null ? p.WhatsAppHookDocument.Size : default(int),
                    WhatsAppHookDocumentThumbnail = p.WhatsAppHookDocument != null ? p.WhatsAppHookDocument.Thumbnail : default(string),
                    WhatsAppHookDocumentForeignUrl = p.WhatsAppHookDocument != null ? p.WhatsAppHookDocument.ForeignUrl : default(string),
                    WhatsAppHookDocumentLocalUrl = p.WhatsAppHookDocument != null ? p.WhatsAppHookDocument.LocalUrl : default(string),
                    WhatsAppHookImageId = p.WhatsAppHookImage != null ? p.WhatsAppHookImage.Id : default(int),
                    WhatsAppHookImageCaption = p.WhatsAppHookImage != null ? p.WhatsAppHookImage.Caption : default(string),
                    WhatsAppHookImageMimeType = p.WhatsAppHookImage != null ? p.WhatsAppHookImage.MimeType : default(string),
                    WhatsAppHookImageSize = p.WhatsAppHookImage != null ? p.WhatsAppHookImage.Size : default(int),
                    WhatsAppHookImageThumbnail = p.WhatsAppHookImage != null ? p.WhatsAppHookImage.Thumbnail : default(string),
                    WhatsAppHookImageForeignUrl = p.WhatsAppHookImage != null ? p.WhatsAppHookImage.ForeignUrl : default(string),
                    WhatsAppHookImageLocalUrl = p.WhatsAppHookImage != null ? p.WhatsAppHookImage.LocalUrl : default(string),
                    WhatsAppHookLocationId = p.WhatsAppHookLocation != null ? p.WhatsAppHookLocation.Id : default(int),
                    WhatsAppHookLocationName = p.WhatsAppHookLocation != null ? p.WhatsAppHookLocation.Name : default(string),
                    WhatsAppHookLocationLongitude = p.WhatsAppHookLocation != null ? p.WhatsAppHookLocation.Longitude : default(string),
                    WhatsAppHookLocationLatitude = p.WhatsAppHookLocation != null ? p.WhatsAppHookLocation.Latitude : default(string),
                    WhatsAppHookLocationThumbnail = p.WhatsAppHookLocation != null ? p.WhatsAppHookLocation.Thumbnail : default(string),
                    WhatsAppHookLocationForeignUrl = p.WhatsAppHookLocation != null ? p.WhatsAppHookLocation.ForeignUrl : default(string),
                    WhatsAppHookLocationLocalUrl = p.WhatsAppHookLocation != null ? p.WhatsAppHookLocation.LocalUrl : default(string),
                    WhatsAppHookPttId = p.WhatsAppHookPtt != null ? p.WhatsAppHookPtt.Id : default(int),
                    WhatsAppHookPttCaption = p.WhatsAppHookPtt != null ? p.WhatsAppHookPtt.Caption : default(string),
                    WhatsAppHookPttMimeType = p.WhatsAppHookPtt != null ? p.WhatsAppHookPtt.MimeType : default(string),
                    WhatsAppHookPttDuration = p.WhatsAppHookPtt != null ? p.WhatsAppHookPtt.Duration : default(int),
                    WhatsAppHookPttSize = p.WhatsAppHookPtt != null ? p.WhatsAppHookPtt.Size : default(int),
                    WhatsAppHookPttForeignUrl = p.WhatsAppHookPtt != null ? p.WhatsAppHookPtt.ForeignUrl : default(string),
                    WhatsAppHookPttLocalUrl = p.WhatsAppHookPtt != null ? p.WhatsAppHookPtt.LocalUrl : default(string),
                    WhatsAppHookTextId = p.WhatsAppHookText != null ? p.WhatsAppHookText.Id : default(int),
                    WhatsAppHookTextText = p.WhatsAppHookText != null ? p.WhatsAppHookText.Text : default(string),
                    WhatsAppHookVCardId = p.WhatsAppHookVCard != null ? p.WhatsAppHookVCard.Id : default(int),
                    WhatsAppHookVCardContact = p.WhatsAppHookVCard != null ? p.WhatsAppHookVCard.Contact : default(string),
                    WhatsAppHookVideoId = p.WhatsAppHookVideo != null ? p.WhatsAppHookVideo.Id : default(int),
                    WhatsAppHookVideoCaption = p.WhatsAppHookVideo != null ? p.WhatsAppHookVideo.Caption : default(string),
                    WhatsAppHookVideoMimeType = p.WhatsAppHookVideo != null ? p.WhatsAppHookVideo.MimeType : default(string),
                    WhatsAppHookVideoDuration = p.WhatsAppHookVideo != null ? p.WhatsAppHookVideo.Duration : default(int),
                    WhatsAppHookVideoSize = p.WhatsAppHookVideo != null ? p.WhatsAppHookVideo.Size : default(int),
                    WhatsAppHookVideoThumbnail = p.WhatsAppHookVideo != null ? p.WhatsAppHookVideo.Thumbnail : default(string),
                    WhatsAppHookVideoForeignUrl = p.WhatsAppHookVideo != null ? p.WhatsAppHookVideo.ForeignUrl : default(string),
                    WhatsAppHookVideoLocalUrl = p.WhatsAppHookVideo != null ? p.WhatsAppHookVideo.LocalUrl : default(string)
                }));
            }
        }

        public override void MapToModel(WhatsAppHookMessageDto dto, WhatsAppHookMessage model)
        {
            ////BCC/ BEGIN CUSTOM CODE SECTION 
            ////ECC/ END CUSTOM CODE SECTION 
            model.Id = dto.Id;
            model.IdContact = dto.IdContact;
            model.EventType = dto.EventType;
            model.Token = dto.Token;
            model.ContactUid = dto.ContactUid;
            model.ContactName = dto.ContactName;
            model.ContactType = dto.ContactType;
            model.MessageDate = dto.MessageDate;
            model.MessageUid = dto.MessageUid;
            model.MessageCuid = dto.MessageCuid;
            model.MessageDirection = dto.MessageDirection;
            model.MessageType = dto.MessageType;
            model.IdHookText = dto.IdHookText;
            model.IdHookImage = dto.IdHookImage;
            model.IdHookVideo = dto.IdHookVideo;
            model.IdHookAudio = dto.IdHookAudio;
            model.IdHookPtt = dto.IdHookPtt;
            model.IdHookDocument = dto.IdHookDocument;
            model.IdHookVCard = dto.IdHookVCard;
            model.IdHookLocation = dto.IdHookLocation;

        }

        ////BCC/ BEGIN CUSTOM CODE SECTION
        public WhatsAppHookMessage MapToModel(WhatsAppHookMessageDto dto)
        {
            return new WhatsAppHookMessage
            {
                Id = dto.Id,
                IdContact = dto.IdContact,
                EventType = dto.EventType,
                Token = dto.Token,
                ContactUid = dto.ContactUid,
                ContactName = dto.ContactName,
                ContactType = dto.ContactType,
                MessageDate = dto.MessageDate,
                MessageUid = dto.MessageUid,
                MessageCuid = dto.MessageCuid,
                MessageDirection = dto.MessageDirection,
                MessageType = dto.MessageType,
                IdHookText = dto.IdHookText,
                IdHookImage = dto.IdHookImage,
                IdHookVideo = dto.IdHookVideo,
                IdHookAudio = dto.IdHookAudio,
                IdHookPtt = dto.IdHookPtt,
                IdHookDocument = dto.IdHookDocument,
                IdHookVCard = dto.IdHookVCard,
                IdHookLocation = dto.IdHookLocation
            };

        }

        public WhatsAppHookMessageDto MapToDto(WhatsAppHookMessage model)
        {
            return new WhatsAppHookMessageDto
            {
                Id = model.Id,
                IdContact = model.IdContact,
                EventType = model.EventType,
                Token = model.Token,
                ContactUid = model.ContactUid,
                ContactName = model.ContactName,
                ContactType = model.ContactType,
                MessageDate = model.MessageDate,
                MessageUid = model.MessageUid,
                MessageCuid = model.MessageCuid,
                MessageDirection = model.MessageDirection,
                MessageType = model.MessageType,
                IdHookText = model.IdHookText,
                IdHookImage = model.IdHookImage,
                IdHookVideo = model.IdHookVideo,
                IdHookAudio = model.IdHookAudio,
                IdHookPtt = model.IdHookPtt,
                IdHookDocument = model.IdHookDocument,
                IdHookVCard = model.IdHookVCard,
                IdHookLocation = model.IdHookLocation,
                WhatsAppHookAudioId = model.WhatsAppHookAudio?.Id ?? default(int),
                WhatsAppHookAudioCaption = model.WhatsAppHookAudio?.Caption,
                WhatsAppHookAudioMimeType = model.WhatsAppHookAudio?.MimeType,
                WhatsAppHookAudioDuration = model.WhatsAppHookAudio?.Duration ?? default(int),
                WhatsAppHookAudioSize = model.WhatsAppHookAudio?.Size ?? default(int),
                WhatsAppHookAudioForeignUrl = model.WhatsAppHookAudio?.ForeignUrl,
                WhatsAppHookAudioLocalUrl = model.WhatsAppHookAudio?.LocalUrl,
                WhatsAppHookDocumentId = model.WhatsAppHookDocument?.Id ?? default(int),
                WhatsAppHookDocumentCaption = model.WhatsAppHookDocument?.Caption,
                WhatsAppHookDocumentMimeType = model.WhatsAppHookDocument?.MimeType,
                WhatsAppHookDocumentSize = model.WhatsAppHookDocument?.Size ?? default(int),
                WhatsAppHookDocumentThumbnail = model.WhatsAppHookDocument?.Thumbnail,
                WhatsAppHookDocumentForeignUrl = model.WhatsAppHookDocument?.ForeignUrl,
                WhatsAppHookDocumentLocalUrl = model.WhatsAppHookDocument?.LocalUrl,
                WhatsAppHookImageId = model.WhatsAppHookImage?.Id ?? default(int),
                WhatsAppHookImageCaption = model.WhatsAppHookImage?.Caption,
                WhatsAppHookImageMimeType = model.WhatsAppHookImage?.MimeType,
                WhatsAppHookImageSize = model.WhatsAppHookImage?.Size ?? default(int),
                WhatsAppHookImageThumbnail = model.WhatsAppHookImage?.Thumbnail,
                WhatsAppHookImageForeignUrl = model.WhatsAppHookImage?.ForeignUrl,
                WhatsAppHookImageLocalUrl = model.WhatsAppHookImage?.LocalUrl,
                WhatsAppHookLocationId = model.WhatsAppHookLocation?.Id ?? default(int),
                WhatsAppHookLocationName = model.WhatsAppHookLocation?.Name,
                WhatsAppHookLocationLongitude = model.WhatsAppHookLocation?.Longitude,
                WhatsAppHookLocationLatitude = model.WhatsAppHookLocation?.Latitude,
                WhatsAppHookLocationThumbnail = model.WhatsAppHookLocation?.Thumbnail,
                WhatsAppHookLocationForeignUrl = model.WhatsAppHookLocation?.ForeignUrl,
                WhatsAppHookLocationLocalUrl = model.WhatsAppHookLocation?.LocalUrl,
                WhatsAppHookPttId = model.WhatsAppHookPtt?.Id ?? default(int),
                WhatsAppHookPttCaption = model.WhatsAppHookPtt?.Caption,
                WhatsAppHookPttMimeType = model.WhatsAppHookPtt?.MimeType,
                WhatsAppHookPttDuration = model.WhatsAppHookPtt?.Duration ?? default(int),
                WhatsAppHookPttSize = model.WhatsAppHookPtt?.Size ?? default(int),
                WhatsAppHookPttForeignUrl = model.WhatsAppHookPtt?.ForeignUrl,
                WhatsAppHookPttLocalUrl = model.WhatsAppHookPtt?.LocalUrl,
                WhatsAppHookTextId = model.WhatsAppHookText?.Id ?? default(int),
                WhatsAppHookTextText = model.WhatsAppHookText?.Text,
                WhatsAppHookVCardId = model.WhatsAppHookVCard?.Id ?? default(int),
                WhatsAppHookVCardContact = model.WhatsAppHookVCard?.Contact,
                WhatsAppHookVideoId = model.WhatsAppHookVideo?.Id ?? default(int),
                WhatsAppHookVideoCaption = model.WhatsAppHookVideo?.Caption,
                WhatsAppHookVideoMimeType = model.WhatsAppHookVideo?.MimeType,
                WhatsAppHookVideoDuration = model.WhatsAppHookVideo?.Duration ?? default(int),
                WhatsAppHookVideoSize = model.WhatsAppHookVideo?.Size ?? default(int),
                WhatsAppHookVideoThumbnail = model.WhatsAppHookVideo?.Thumbnail,
                WhatsAppHookVideoForeignUrl = model.WhatsAppHookVideo?.ForeignUrl,
                WhatsAppHookVideoLocalUrl = model.WhatsAppHookVideo?.LocalUrl
            };

        }
        ////ECC/ END CUSTOM CODE SECTION 
    }
}
