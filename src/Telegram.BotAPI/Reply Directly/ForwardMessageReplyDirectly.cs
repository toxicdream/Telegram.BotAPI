using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

#nullable enable

namespace Telegram.BotAPI.ReplyDirectly
{
    /// <summary> <see cref="ForwardMessageArgs"/> with "Method" property for Reply Directly</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ForwardMessageReplyDirectly : ForwardMessageArgs, IReplyDirectlyMethod
    {
        /// <summary>Initialize a new instance of <see cref="ForwardMessageReplyDirectly"/>.</summary>
        /// <param name="chatId">Unique identifier of the target chat.</param>
        /// <param name="fromChatId">Unique identifier of the source chat.</param>
        /// <param name="messageId">Unique identifier of source message.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ForwardMessageReplyDirectly(long chatId, long fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>Initialize a new instance of <see cref="ForwardMessageReplyDirectly"/>.</summary>
        /// <param name="chatId">Unique identifier of the target chat.</param>
        /// <param name="fromChatId">Unique identifier of the source chat.</param>
        /// <param name="messageId">Unique identifier of source message.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ForwardMessageReplyDirectly(string chatId, string fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>Initialize a new instance of <see cref="ForwardMessageReplyDirectly"/>.</summary>
        /// <param name="chatId">Unique identifier of the target chat.</param>
        /// <param name="fromChatId">Unique identifier of the source chat.</param>
        /// <param name="messageId">Unique identifier of source message.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ForwardMessageReplyDirectly(long chatId, string fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>Initialize a new instance of <see cref="ForwardMessageReplyDirectly"/>.</summary>
        /// <param name="chatId">Unique identifier of the target chat.</param>
        /// <param name="fromChatId">Unique identifier of the source chat.</param>
        /// <param name="messageId">Unique identifier of source message.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ForwardMessageReplyDirectly(string chatId, long fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>"Method" property for Reply Directly</summary>
        [JsonPropertyName(PropertyNames.Method)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Method => MethodNames.ForwardMessage;
    }
}
