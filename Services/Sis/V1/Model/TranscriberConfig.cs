using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TranscriberConfig 
    {
        /// <summary>
        /// 支持语音的格式。  audioformat取值范围:  auto  自动判断，系统会自动判断并支持WAV（内部支持pcm/ulaw/alaw/adpcm编码格式）、MP3、M4A、ogg-speex、ogg-opus、AMR、wma等格式，相应的文件后缀名为.wav, .mp3, .m4a, .spx, .opus, .amr 和.wma, 不区分大小写。支持双声道的音频。  pcm16k16bit  16k16bit裸音频录音数据。  pcm8k16bit   8k16bit裸音频录音数据。  ulaw16k8bit  16k8bit ulaw 裸音频录音数据。  ulaw8k8bit   8k8bit ulaw 裸音频录音数据。  alaw16k8bit  16k8bit alaw 裸音频录音数据。  alaw8k8bit   8k8bit alaw 裸音频录音数据。  vox8k4bit    8k4bit vox 裸音频录音数据。  v3_8k4bit    8k4bit v3 裸音频录音数据。
        /// </summary>
        /// <value>支持语音的格式。  audioformat取值范围:  auto  自动判断，系统会自动判断并支持WAV（内部支持pcm/ulaw/alaw/adpcm编码格式）、MP3、M4A、ogg-speex、ogg-opus、AMR、wma等格式，相应的文件后缀名为.wav, .mp3, .m4a, .spx, .opus, .amr 和.wma, 不区分大小写。支持双声道的音频。  pcm16k16bit  16k16bit裸音频录音数据。  pcm8k16bit   8k16bit裸音频录音数据。  ulaw16k8bit  16k8bit ulaw 裸音频录音数据。  ulaw8k8bit   8k8bit ulaw 裸音频录音数据。  alaw16k8bit  16k8bit alaw 裸音频录音数据。  alaw8k8bit   8k8bit alaw 裸音频录音数据。  vox8k4bit    8k4bit vox 裸音频录音数据。  v3_8k4bit    8k4bit v3 裸音频录音数据。</value>
        [JsonConverter(typeof(EnumClassConverter<AudioFormatEnum>))]
        public class AudioFormatEnum
        {
            /// <summary>
            /// Enum AUTO for value: auto
            /// </summary>
            public static readonly AudioFormatEnum AUTO = new AudioFormatEnum("auto");

            /// <summary>
            /// Enum PCM16K16BIT for value: pcm16k16bit
            /// </summary>
            public static readonly AudioFormatEnum PCM16K16BIT = new AudioFormatEnum("pcm16k16bit");

            /// <summary>
            /// Enum PCM8K16BIT for value: pcm8k16bit
            /// </summary>
            public static readonly AudioFormatEnum PCM8K16BIT = new AudioFormatEnum("pcm8k16bit");

            /// <summary>
            /// Enum ULAW16K8BIT for value: ulaw16k8bit
            /// </summary>
            public static readonly AudioFormatEnum ULAW16K8BIT = new AudioFormatEnum("ulaw16k8bit");

            /// <summary>
            /// Enum ULAW8K8BIT for value: ulaw8k8bit
            /// </summary>
            public static readonly AudioFormatEnum ULAW8K8BIT = new AudioFormatEnum("ulaw8k8bit");

            /// <summary>
            /// Enum ALAW16K8BIT for value: alaw16k8bit
            /// </summary>
            public static readonly AudioFormatEnum ALAW16K8BIT = new AudioFormatEnum("alaw16k8bit");

            /// <summary>
            /// Enum ALAW8K8BIT for value: alaw8k8bit
            /// </summary>
            public static readonly AudioFormatEnum ALAW8K8BIT = new AudioFormatEnum("alaw8k8bit");

            /// <summary>
            /// Enum VOX8K4BIT for value: vox8k4bit
            /// </summary>
            public static readonly AudioFormatEnum VOX8K4BIT = new AudioFormatEnum("vox8k4bit");

            /// <summary>
            /// Enum V3_8K4BIT for value: v3_8k4bit
            /// </summary>
            public static readonly AudioFormatEnum V3_8K4BIT = new AudioFormatEnum("v3_8k4bit");

            private static readonly Dictionary<string, AudioFormatEnum> StaticFields =
            new Dictionary<string, AudioFormatEnum>()
            {
                { "auto", AUTO },
                { "pcm16k16bit", PCM16K16BIT },
                { "pcm8k16bit", PCM8K16BIT },
                { "ulaw16k8bit", ULAW16K8BIT },
                { "ulaw8k8bit", ULAW8K8BIT },
                { "alaw16k8bit", ALAW16K8BIT },
                { "alaw8k8bit", ALAW8K8BIT },
                { "vox8k4bit", VOX8K4BIT },
                { "v3_8k4bit", V3_8K4BIT },
            };

            private string Value;

            public AudioFormatEnum(string value)
            {
                Value = value;
            }

            public static AudioFormatEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as AudioFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AudioFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(AudioFormatEnum a, AudioFormatEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(AudioFormatEnum a, AudioFormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 所使用的模型特征串。通常是“语种_采样率_领域”的形式，例如chinese_8k_common。  采样率需要与音频采样率保持一致。  当前支持如下模型特征串：  chinese_8k_common  chinese_16k_conversation  chinese_8k_bank（银行领域，区域仅支持cn-north-4）  chinese_8k_insurance（保险领域，区域仅支持cn-north-4） 
        /// </summary>
        /// <value>所使用的模型特征串。通常是“语种_采样率_领域”的形式，例如chinese_8k_common。  采样率需要与音频采样率保持一致。  当前支持如下模型特征串：  chinese_8k_common  chinese_16k_conversation  chinese_8k_bank（银行领域，区域仅支持cn-north-4）  chinese_8k_insurance（保险领域，区域仅支持cn-north-4） </value>
        [JsonConverter(typeof(EnumClassConverter<PropertyEnum>))]
        public class PropertyEnum
        {
            /// <summary>
            /// Enum CHINESE_8K_COMMON for value: chinese_8k_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_8K_COMMON = new PropertyEnum("chinese_8k_common");

            /// <summary>
            /// Enum CHINESE_16K_CONVERSATION for value: chinese_16k_conversation
            /// </summary>
            public static readonly PropertyEnum CHINESE_16K_CONVERSATION = new PropertyEnum("chinese_16k_conversation");

            /// <summary>
            /// Enum CHINESE_8K_BANK for value: chinese_8k_bank
            /// </summary>
            public static readonly PropertyEnum CHINESE_8K_BANK = new PropertyEnum("chinese_8k_bank");

            /// <summary>
            /// Enum CHINESE_8K_INSURANCE for value: chinese_8k_insurance
            /// </summary>
            public static readonly PropertyEnum CHINESE_8K_INSURANCE = new PropertyEnum("chinese_8k_insurance");

            private static readonly Dictionary<string, PropertyEnum> StaticFields =
            new Dictionary<string, PropertyEnum>()
            {
                { "chinese_8k_common", CHINESE_8K_COMMON },
                { "chinese_16k_conversation", CHINESE_16K_CONVERSATION },
                { "chinese_8k_bank", CHINESE_8K_BANK },
                { "chinese_8k_insurance", CHINESE_8K_INSURANCE },
            };

            private string Value;

            public PropertyEnum(string value)
            {
                Value = value;
            }

            public static PropertyEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as PropertyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PropertyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(PropertyEnum a, PropertyEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(PropertyEnum a, PropertyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否加标点， 可以为 yes, no(缺省)。
        /// </summary>
        /// <value>是否加标点， 可以为 yes, no(缺省)。</value>
        [JsonConverter(typeof(EnumClassConverter<AddPuncEnum>))]
        public class AddPuncEnum
        {
            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly AddPuncEnum YES = new AddPuncEnum("yes");

            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly AddPuncEnum NO = new AddPuncEnum("no");

            private static readonly Dictionary<string, AddPuncEnum> StaticFields =
            new Dictionary<string, AddPuncEnum>()
            {
                { "yes", YES },
                { "no", NO },
            };

            private string Value;

            public AddPuncEnum(string value)
            {
                Value = value;
            }

            public static AddPuncEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as AddPuncEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AddPuncEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(AddPuncEnum a, AddPuncEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(AddPuncEnum a, AddPuncEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 表示是否将语音中的数字识别为阿拉伯数字，取值为yes 、 no，缺省为yes。
        /// </summary>
        /// <value>表示是否将语音中的数字识别为阿拉伯数字，取值为yes 、 no，缺省为yes。</value>
        [JsonConverter(typeof(EnumClassConverter<DigitNormEnum>))]
        public class DigitNormEnum
        {
            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly DigitNormEnum YES = new DigitNormEnum("yes");

            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly DigitNormEnum NO = new DigitNormEnum("no");

            private static readonly Dictionary<string, DigitNormEnum> StaticFields =
            new Dictionary<string, DigitNormEnum>()
            {
                { "yes", YES },
                { "no", NO },
            };

            private string Value;

            public DigitNormEnum(string value)
            {
                Value = value;
            }

            public static DigitNormEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as DigitNormEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DigitNormEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DigitNormEnum a, DigitNormEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DigitNormEnum a, DigitNormEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 表示是否在识别结果中输出分词结果信息，取值为“yes”和“no”，默认为“no”。
        /// </summary>
        /// <value>表示是否在识别结果中输出分词结果信息，取值为“yes”和“no”，默认为“no”。</value>
        [JsonConverter(typeof(EnumClassConverter<NeedWordInfoEnum>))]
        public class NeedWordInfoEnum
        {
            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly NeedWordInfoEnum YES = new NeedWordInfoEnum("yes");

            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly NeedWordInfoEnum NO = new NeedWordInfoEnum("no");

            private static readonly Dictionary<string, NeedWordInfoEnum> StaticFields =
            new Dictionary<string, NeedWordInfoEnum>()
            {
                { "yes", YES },
                { "no", NO },
            };

            private string Value;

            public NeedWordInfoEnum(string value)
            {
                Value = value;
            }

            public static NeedWordInfoEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as NeedWordInfoEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NeedWordInfoEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(NeedWordInfoEnum a, NeedWordInfoEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(NeedWordInfoEnum a, NeedWordInfoEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 支持语音的格式。  audioformat取值范围:  auto  自动判断，系统会自动判断并支持WAV（内部支持pcm/ulaw/alaw/adpcm编码格式）、MP3、M4A、ogg-speex、ogg-opus、AMR、wma等格式，相应的文件后缀名为.wav, .mp3, .m4a, .spx, .opus, .amr 和.wma, 不区分大小写。支持双声道的音频。  pcm16k16bit  16k16bit裸音频录音数据。  pcm8k16bit   8k16bit裸音频录音数据。  ulaw16k8bit  16k8bit ulaw 裸音频录音数据。  ulaw8k8bit   8k8bit ulaw 裸音频录音数据。  alaw16k8bit  16k8bit alaw 裸音频录音数据。  alaw8k8bit   8k8bit alaw 裸音频录音数据。  vox8k4bit    8k4bit vox 裸音频录音数据。  v3_8k4bit    8k4bit v3 裸音频录音数据。
        /// </summary>
        [JsonProperty("audio_format", NullValueHandling = NullValueHandling.Ignore)]
        public AudioFormatEnum AudioFormat { get; set; }
        /// <summary>
        /// 所使用的模型特征串。通常是“语种_采样率_领域”的形式，例如chinese_8k_common。  采样率需要与音频采样率保持一致。  当前支持如下模型特征串：  chinese_8k_common  chinese_16k_conversation  chinese_8k_bank（银行领域，区域仅支持cn-north-4）  chinese_8k_insurance（保险领域，区域仅支持cn-north-4） 
        /// </summary>
        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public PropertyEnum Property { get; set; }
        /// <summary>
        /// 是否加标点， 可以为 yes, no(缺省)。
        /// </summary>
        [JsonProperty("add_punc", NullValueHandling = NullValueHandling.Ignore)]
        public AddPuncEnum AddPunc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("need_analysis_info", NullValueHandling = NullValueHandling.Ignore)]
        public AnalysisInfo NeedAnalysisInfo { get; set; }

        /// <summary>
        /// 热词表id，不使用则不填写。
        /// </summary>
        [JsonProperty("vocabulary_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VocabularyId { get; set; }

        /// <summary>
        /// 表示是否将语音中的数字识别为阿拉伯数字，取值为yes 、 no，缺省为yes。
        /// </summary>
        [JsonProperty("digit_norm", NullValueHandling = NullValueHandling.Ignore)]
        public DigitNormEnum DigitNorm { get; set; }
        /// <summary>
        /// 用于录音文件识表示回调 url，即用户用于接收识别结果的服务器地址，不支持IP地址方式调用，url长度小于2048字节。服务请求方法为POST。  如果用户使用回调方式获取识别结果，需填写该参数，处理成功后用户服务器需返回状态码“200”。  如果用户使用轮询方式获取识别结果，则无需填写该参数。别结果的回调url，不使用则不填写。
        /// </summary>
        [JsonProperty("callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 表示是否在识别结果中输出分词结果信息，取值为“yes”和“no”，默认为“no”。
        /// </summary>
        [JsonProperty("need_word_info", NullValueHandling = NullValueHandling.Ignore)]
        public NeedWordInfoEnum NeedWordInfo { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriberConfig {\n");
            sb.Append("  audioFormat: ").Append(AudioFormat).Append("\n");
            sb.Append("  property: ").Append(Property).Append("\n");
            sb.Append("  addPunc: ").Append(AddPunc).Append("\n");
            sb.Append("  needAnalysisInfo: ").Append(NeedAnalysisInfo).Append("\n");
            sb.Append("  vocabularyId: ").Append(VocabularyId).Append("\n");
            sb.Append("  digitNorm: ").Append(DigitNorm).Append("\n");
            sb.Append("  callbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  needWordInfo: ").Append(NeedWordInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TranscriberConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TranscriberConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AudioFormat == input.AudioFormat ||
                    (this.AudioFormat != null &&
                    this.AudioFormat.Equals(input.AudioFormat))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
                ) && 
                (
                    this.AddPunc == input.AddPunc ||
                    (this.AddPunc != null &&
                    this.AddPunc.Equals(input.AddPunc))
                ) && 
                (
                    this.NeedAnalysisInfo == input.NeedAnalysisInfo ||
                    (this.NeedAnalysisInfo != null &&
                    this.NeedAnalysisInfo.Equals(input.NeedAnalysisInfo))
                ) && 
                (
                    this.VocabularyId == input.VocabularyId ||
                    (this.VocabularyId != null &&
                    this.VocabularyId.Equals(input.VocabularyId))
                ) && 
                (
                    this.DigitNorm == input.DigitNorm ||
                    (this.DigitNorm != null &&
                    this.DigitNorm.Equals(input.DigitNorm))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.NeedWordInfo == input.NeedWordInfo ||
                    (this.NeedWordInfo != null &&
                    this.NeedWordInfo.Equals(input.NeedWordInfo))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AudioFormat != null)
                    hashCode = hashCode * 59 + this.AudioFormat.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.AddPunc != null)
                    hashCode = hashCode * 59 + this.AddPunc.GetHashCode();
                if (this.NeedAnalysisInfo != null)
                    hashCode = hashCode * 59 + this.NeedAnalysisInfo.GetHashCode();
                if (this.VocabularyId != null)
                    hashCode = hashCode * 59 + this.VocabularyId.GetHashCode();
                if (this.DigitNorm != null)
                    hashCode = hashCode * 59 + this.DigitNorm.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.NeedWordInfo != null)
                    hashCode = hashCode * 59 + this.NeedWordInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
