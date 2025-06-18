using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EduVerseFunction.Dtos
{
    public class VideoRequestModel
    {
        [JsonPropertyName("videoRequestId")]
        public int VideoRequestId { get; set; }
    }
}
