using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableMethods;

namespace Telegram.BotAPI.ReplyDirectly
{
    /// <summary> <see cref="SendMessageArgs"/> with "Method" property for Reply Directly</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SendMessageReplyDirectly : SendMessageArgs, IReplyDirectlyMethod
    {
        /// <summary>Initialize a new instance of <see cref="SendMessageReplyDirectly"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        public SendMessageReplyDirectly(long chatId, string text) : base(chatId, text) { }

        /// <summary>Initialize a new instance of <see cref="SendMessageReplyDirectly"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        public SendMessageReplyDirectly(string chatId, string text) : base(chatId, text) { }

        /// <summary>"Method" property for Reply Directly</summary>
        [JsonPropertyName(PropertyNames.Method)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Method => MethodNames.SendMessage;
    }
}
