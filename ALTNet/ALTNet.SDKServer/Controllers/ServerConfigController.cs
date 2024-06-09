using Microsoft.AspNetCore.Mvc;

namespace SCHALE.GameServer.Controllers
{
    [ApiController]
    [Route("/")]
    public class ServerConfigController : ControllerBase
    {
        private readonly ILogger<ServerConfigController> _logger;

        public ServerConfigController(ILogger<ServerConfigController> logger)
        {
            _logger = logger;
        }

        [HttpGet("server_config/live")]
        public IResult GetServerConfig()
        {
            return Results.Text(@"
{
  ""server"": {
    ""Korea"": {
      ""ip"": ""ctskorea-login.sbside.com"",
      ""port"": 22000,
      ""defaultTagSet"": [
        ""KOR"",
        ""LANGUAGE_KOR"",
        ""VOICE_KOR"",
        ""VOICE_JPN"",
        ""CHECK_MAINTENANCE"",
        ""MULTITASK_DOWNLOAD""
      ],
      ""Maintenance"": {
        ""Interval"": 0,
        ""Use"": false,
        ""Description"": {
          ""DEFAULT"": ""선택하신 서버는 점검 중입니다.\n자세한 내용은 공지사항을 참고하세요.""
        }
      }
    },
    ""Global"": {
      //""ip"": ""ctsglobal-login.sbside.com"",
      ""ip"": ""192.168.1.11"",
      ""port"": 22000,
      ""defaultTagSet"": [
        ""GLOBAL"",
        ""LANGUAGE_KOR"",
        ""LANGUAGE_ENG"",
        ""LANGUAGE_DEU"",
        ""LANGUAGE_FRA"",
        ""LANGUAGE_JPN"",
        ""VOICE_KOR"",
        ""VOICE_JPN"",
        ""CHECK_MAINTENANCE"",
        ""MULTITASK_DOWNLOAD""
      ],
      ""Maintenance"": {
        ""Interval"": 0,
        ""Use"": false,
        ""Description"": {
          ""DEFAULT"": ""선택하신 서버는 점검 중입니다.\n자세한 내용은 공지사항을 참고하세요."",
          ""NNC_KOREA"": ""선택하신 서버는 점검 중입니다.\n자세한 내용은 공지사항을 참고하세요."",
          ""NNC_FRENCH"": ""Le serveur sélectionné est actuellement en cours de maintenance.\nPour plus d'informations, veuillez vous référer à l'annonce publiée à ce sujet."",
          ""NNC_DEUTSCH"": ""Der ausgewählte Server ist in Wartung.\nFür weitere Informationen siehe Wartungsankündigung."",
          ""NNC_JAPAN"": ""このサーバーは、只今メンテナンス中です。\n詳細内容は公式サイトの「お知らせ」を確認してください。"",
          ""NNC_ENG"": ""The selected server is currently undergoing maintenance.\nPlease refer to Notice for more details.""
        }
      }
    },
  },
  //""type"": ""LIVE"",
  ""type"": ""PRIVATE"",
  ""cdn"": ""https://ctsglobal-cdndown.sbside.com/patchfiles/"",
  ""versionJson"": ""/liveVersion.json"",
  ""DownloadTimeout"": 300000
}

");
        }

      
    }
}
