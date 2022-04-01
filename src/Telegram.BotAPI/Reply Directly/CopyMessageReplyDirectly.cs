using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableMethods;

namespace Telegram.BotAPI.ReplyDirectly
{
    /// <summary> <see cref="CopyMessageArgs"/> with "Method" property for Reply Directly</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CopyMessageReplyDirectly : CopyMessageArgs, IReplyDirectlyMethod
    {
        /// <summary>
        /// Initialize a new instance of <see cref="CopyMessageReplyDirectly"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
        /// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
        public CopyMessageReplyDirectly(long chatId, long fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>
        /// Initialize a new instance of <see cref="CopyMessageReplyDirectly"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
        /// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
        public CopyMessageReplyDirectly(string chatId, long fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>
        /// Initialize a new instance of <see cref="CopyMessageReplyDirectly"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
        /// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
        public CopyMessageReplyDirectly(long chatId, string fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>
        /// Initialize a new instance of <see cref="CopyMessageReplyDirectly"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
        /// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
        public CopyMessageReplyDirectly(string chatId, string fromChatId, int messageId) : base(chatId, fromChatId, messageId) { }

        /// <summary>"Method" property for Reply Directly</summary>
        [JsonPropertyName(PropertyNames.Method)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Method => MethodNames.CopyMessage;
    }
}
