using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;


namespace Telegram.BotAPI.ReplyDirectly
{
    /// <summary> <see cref="ForwardMessageArgs"/> with "Method" property for Reply Directly</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ForwardMessageReplyDirectly : ForwardMessageArgs, IReplyDirectlyMethod
    {
        /// <summary>Initialize a new instance of <see cref="ForwardMessageReplyDirectly"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="fromChatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ForwardMessageReplyDirectly(long chatId, long fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>Initialize a new instance of <see cref="ForwardMessageReplyDirectly"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="fromChatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ForwardMessageReplyDirectly(string chatId, string fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>Initialize a new instance of <see cref="ForwardMessageReplyDirectly"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="fromChatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ForwardMessageReplyDirectly(long chatId, string fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>Initialize a new instance of <see cref="ForwardMessageReplyDirectly"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="fromChatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ForwardMessageReplyDirectly(string chatId, long fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>"Method" property for Reply Directly</summary>
        [JsonPropertyName(PropertyNames.Method)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Method => MethodNames.ForwardMessage;
    }
}
