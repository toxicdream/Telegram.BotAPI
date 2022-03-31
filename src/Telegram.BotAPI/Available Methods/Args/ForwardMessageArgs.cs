using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Text.Json.Serialization;

#nullable enable

namespace Telegram.BotAPI
{
    /// <summary>Base object for message-sending methods arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ForwardMessageArgs : ForwardMessage<object, object>
    {
        /// <summary>Initialize a new instance of <see cref="SendMessageBase"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="fromChatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ForwardMessageArgs(long chatId, long fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>Initialize a new instance of <see cref="SendMessageBase"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="fromChatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ForwardMessageArgs(string chatId, string fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>Initialize a new instance of <see cref="SendMessageBase"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="fromChatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ForwardMessageArgs(long chatId, string fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>Initialize a new instance of <see cref="SendMessageBase"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="fromChatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ForwardMessageArgs(string chatId, long fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }
    }

    /// <summary>Base object for message-sending methods arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class ForwardMessage<TChatId, TFromChatId>
    {
        /// <summary>Initialize a new instance of <see cref="SendMessageBase"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="fromChatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        protected ForwardMessage(TChatId chatId, TFromChatId fromChatId, int messageId)
        {
            ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
            FromChatId = fromChatId ?? throw new ArgumentNullException(nameof(fromChatId));
            MessageId = messageId;
        }

        ///<summary><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonPropertyName(PropertyNames.ChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual TChatId ChatId { get; set; }

        ///<summary><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonPropertyName(PropertyNames.FromChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual TFromChatId FromChatId { get; set; }

        /// <summary>Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</summary>
        [JsonPropertyName(PropertyNames.DisableNotification)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? DisableNotification { get; set; }

        /// <summary>Protects the contents of the sent message from forwarding and saving.</summary>
        [JsonPropertyName(PropertyNames.ProtectContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ProtectContent { get; set; }

        ///<summary>Message identifier in the chat specified in from_chat_id.</summary>
        [JsonPropertyName(PropertyNames.MessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MessageId { get; set; }

    }

}
