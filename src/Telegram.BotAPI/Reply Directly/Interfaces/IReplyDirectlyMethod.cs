using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.ReplyDirectly
{
    /// <summary>Added Method property for Reply Directly</summary>
    public interface IReplyDirectlyMethod
    {
        /// <summary>Method property for Reply Directly</summary>
        public string Method { get; }
    }
}
