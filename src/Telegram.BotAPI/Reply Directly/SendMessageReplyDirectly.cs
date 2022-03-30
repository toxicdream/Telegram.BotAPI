using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableMethods;

namespace Telegram.BotAPI.ReplyDirectly
{
    /// <summary> <see cref="SendMessageArgs"/> with "Method" property for Reply Directly</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SendMessageReplyDirectly : SendMessageArgs, IReplyDirectlyMethod
    {
        /// <summary>Initialize a new instance of <see cref="SendMessageReplyDirectly"/>.</summary>
        public SendMessageReplyDirectly(long chatId, string text) : base(chatId, text) 
        {
            Method = MethodNames.SendMessage;
        }

        /// <summary>Method property for Reply Directly</summary>
        [JsonPropertyName(PropertyNames.Method)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Method { get; }
    }
}
