using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 视频的元数据信息。  经过视频解析后产生，包括封装格式、大小、分辨率、码率、帧率。
    /// </summary>
    public class MetaData 
    {
        /// <summary>
        /// 视频编码格式。  取值如下： - MPEG-2 - MPEG-4 - H.264 - H.265 - WMV - Vorbis - AAC - AC-3 - AMR - APE - FLAC - MP3 - MP2 - WMA - PCM - ADPCM - WavPack
        /// </summary>
        /// <value>视频编码格式。  取值如下： - MPEG-2 - MPEG-4 - H.264 - H.265 - WMV - Vorbis - AAC - AC-3 - AMR - APE - FLAC - MP3 - MP2 - WMA - PCM - ADPCM - WavPack</value>
        [JsonConverter(typeof(EnumClassConverter<CodecEnum>))]
        public class CodecEnum
        {
            /// <summary>
            /// Enum MPEG_2 for value: MPEG-2
            /// </summary>
            public static readonly CodecEnum MPEG_2 = new CodecEnum("MPEG-2");

            /// <summary>
            /// Enum MPEG_4 for value: MPEG-4
            /// </summary>
            public static readonly CodecEnum MPEG_4 = new CodecEnum("MPEG-4");

            /// <summary>
            /// Enum H_264 for value: H.264
            /// </summary>
            public static readonly CodecEnum H_264 = new CodecEnum("H.264");

            /// <summary>
            /// Enum H_265 for value: H.265
            /// </summary>
            public static readonly CodecEnum H_265 = new CodecEnum("H.265");

            /// <summary>
            /// Enum WMV for value: WMV
            /// </summary>
            public static readonly CodecEnum WMV = new CodecEnum("WMV");

            /// <summary>
            /// Enum VORBIS for value: Vorbis
            /// </summary>
            public static readonly CodecEnum VORBIS = new CodecEnum("Vorbis");

            /// <summary>
            /// Enum AAC for value: AAC
            /// </summary>
            public static readonly CodecEnum AAC = new CodecEnum("AAC");

            /// <summary>
            /// Enum EAC_3 for value: EAC-3
            /// </summary>
            public static readonly CodecEnum EAC_3 = new CodecEnum("EAC-3");

            /// <summary>
            /// Enum AC_3 for value: AC-3
            /// </summary>
            public static readonly CodecEnum AC_3 = new CodecEnum("AC-3");

            /// <summary>
            /// Enum AMR for value: AMR
            /// </summary>
            public static readonly CodecEnum AMR = new CodecEnum("AMR");

            /// <summary>
            /// Enum APE for value: APE
            /// </summary>
            public static readonly CodecEnum APE = new CodecEnum("APE");

            /// <summary>
            /// Enum FLAC for value: FLAC
            /// </summary>
            public static readonly CodecEnum FLAC = new CodecEnum("FLAC");

            /// <summary>
            /// Enum MP3 for value: MP3
            /// </summary>
            public static readonly CodecEnum MP3 = new CodecEnum("MP3");

            /// <summary>
            /// Enum MP2 for value: MP2
            /// </summary>
            public static readonly CodecEnum MP2 = new CodecEnum("MP2");

            /// <summary>
            /// Enum WMA for value: WMA
            /// </summary>
            public static readonly CodecEnum WMA = new CodecEnum("WMA");

            /// <summary>
            /// Enum PCM for value: PCM
            /// </summary>
            public static readonly CodecEnum PCM = new CodecEnum("PCM");

            /// <summary>
            /// Enum ADPCM for value: ADPCM
            /// </summary>
            public static readonly CodecEnum ADPCM = new CodecEnum("ADPCM");

            /// <summary>
            /// Enum WAVPACK for value: WavPack
            /// </summary>
            public static readonly CodecEnum WAVPACK = new CodecEnum("WavPack");

            /// <summary>
            /// Enum HEAAC for value: HEAAC
            /// </summary>
            public static readonly CodecEnum HEAAC = new CodecEnum("HEAAC");

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            public static readonly CodecEnum UNKNOWN = new CodecEnum("UNKNOWN");

            private static readonly Dictionary<string, CodecEnum> StaticFields =
            new Dictionary<string, CodecEnum>()
            {
                { "MPEG-2", MPEG_2 },
                { "MPEG-4", MPEG_4 },
                { "H.264", H_264 },
                { "H.265", H_265 },
                { "WMV", WMV },
                { "Vorbis", VORBIS },
                { "AAC", AAC },
                { "EAC-3", EAC_3 },
                { "AC-3", AC_3 },
                { "AMR", AMR },
                { "APE", APE },
                { "FLAC", FLAC },
                { "MP3", MP3 },
                { "MP2", MP2 },
                { "WMA", WMA },
                { "PCM", PCM },
                { "ADPCM", ADPCM },
                { "WavPack", WAVPACK },
                { "HEAAC", HEAAC },
                { "UNKNOWN", UNKNOWN },
            };

            private string Value;

            public CodecEnum(string value)
            {
                Value = value;
            }

            public static CodecEnum FromValue(string value)
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

                if (this.Equals(obj as CodecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CodecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(CodecEnum a, CodecEnum b)
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

            public static bool operator !=(CodecEnum a, CodecEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 视频编码格式。  取值如下： - MPEG-2 - MPEG-4 - H.264 - H.265 - WMV - Vorbis - AAC - AC-3 - AMR - APE - FLAC - MP3 - MP2 - WMA - PCM - ADPCM - WavPack
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public CodecEnum Codec { get; set; }
        /// <summary>
        /// 视频时长。  若视频的原时长为非整数，则该字段值为原时长的向上取整。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        /// <summary>
        /// 视频文件大小。  单位：字节。
        /// </summary>
        [JsonProperty("video_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? VideoSize { get; set; }

        /// <summary>
        /// 视频宽度（单位：像素）。 - 编码为H.264的取值范围：[32,3840]之间2的倍数。 - 编码为H.265的取值范围：[320,3840]之间4的倍数。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }

        /// <summary>
        /// 视频高度（单位：像素）。 - 编码为H.264的取值范围：[32,2160]之间2的倍数 。 - 编码为H.265的取值范围：[240,2160]之间4的倍数。
        /// </summary>
        [JsonProperty("hight", NullValueHandling = NullValueHandling.Ignore)]
        public long? Hight { get; set; }

        /// <summary>
        /// 视频平均码率。
        /// </summary>
        [JsonProperty("bit_rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? BitRate { get; set; }

        /// <summary>
        /// 帧率（单位：帧每秒）。  取值如下： - FRAMERATE_AUTO &#x3D; 1, - FRAMERATE_10 &#x3D; 2, - FRAMERATE_15 &#x3D; 3, - FRAMERATE_2397 &#x3D; 4, // 23.97 fps - FRAMERATE_24 &#x3D; 5, - FRAMERATE_25 &#x3D; 6, - FRAMERATE_2997 &#x3D; 7, // 29.97 fps - FRAMERATE_30 &#x3D; 8, - FRAMERATE_50 &#x3D; 9, - FRAMERATE_60 &#x3D; 10  默认值：1。  单位：帧每秒。
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? FrameRate { get; set; }

        /// <summary>
        /// 清晰度。  取值如下： - FULL_HD：超高清 - HD：高清 - SD：标清 - FLUENT：流畅 - AD：自适应 - 2K - 4K
        /// </summary>
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        public string Quality { get; set; }

        /// <summary>
        /// 音频的声道数。
        /// </summary>
        [JsonProperty("audio_channels", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudioChannels { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaData {\n");
            sb.Append("  codec: ").Append(Codec).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  videoSize: ").Append(VideoSize).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  hight: ").Append(Hight).Append("\n");
            sb.Append("  bitRate: ").Append(BitRate).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  quality: ").Append(Quality).Append("\n");
            sb.Append("  audioChannels: ").Append(AudioChannels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetaData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetaData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Codec == input.Codec ||
                    (this.Codec != null &&
                    this.Codec.Equals(input.Codec))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.VideoSize == input.VideoSize ||
                    (this.VideoSize != null &&
                    this.VideoSize.Equals(input.VideoSize))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Hight == input.Hight ||
                    (this.Hight != null &&
                    this.Hight.Equals(input.Hight))
                ) && 
                (
                    this.BitRate == input.BitRate ||
                    (this.BitRate != null &&
                    this.BitRate.Equals(input.BitRate))
                ) && 
                (
                    this.FrameRate == input.FrameRate ||
                    (this.FrameRate != null &&
                    this.FrameRate.Equals(input.FrameRate))
                ) && 
                (
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
                ) && 
                (
                    this.AudioChannels == input.AudioChannels ||
                    (this.AudioChannels != null &&
                    this.AudioChannels.Equals(input.AudioChannels))
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
                if (this.Codec != null)
                    hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.VideoSize != null)
                    hashCode = hashCode * 59 + this.VideoSize.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Hight != null)
                    hashCode = hashCode * 59 + this.Hight.GetHashCode();
                if (this.BitRate != null)
                    hashCode = hashCode * 59 + this.BitRate.GetHashCode();
                if (this.FrameRate != null)
                    hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.AudioChannels != null)
                    hashCode = hashCode * 59 + this.AudioChannels.GetHashCode();
                return hashCode;
            }
        }
    }
}
