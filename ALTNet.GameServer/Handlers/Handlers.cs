using ALTNet.Common.Utils;
using ALTNet.GameServer.Packets;
using ClientPacket.Account;
using ClientPacket.Community;
using ClientPacket.Defence;
using ClientPacket.Game;
using ClientPacket.Item;
using ClientPacket.Mode;
using ClientPacket.Service;
using ClientPacket.User;
using Cs.Protocol;
using NKM;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTNet.GameServer.Handlers
{
    public static class Handlers
    {
        public static NKMPacket_CONTENTS_VERSION_ACK kNKMPacket_CONTENTS_VERSION_REQ_Handler(ISerializable req)
        {
            var rsp = PcapUtils.FromJson<NKMPacket_CONTENTS_VERSION_ACK>();

            rsp.utcTime = DateTime.UtcNow;
            rsp.contentsTag = Config.ContentsTag;

            return rsp;
            return new NKMPacket_CONTENTS_VERSION_ACK()
            {
                errorCode = NKM_ERROR_CODE.NEC_OK,
                //contentsVersion = "7.2.e",
                contentsVersion = "7.2.f",
                utcTime = DateTime.UtcNow,
                utcOffset = TimeSpan.Parse("09:00:00"),
                contentsTag = Config.ContentsTag,
            };
        }

        public static NKMPacket_LOGIN_ACK kNKMPacket_STEAM_LOGIN_REQ_Handler(ISerializable req)
        {
            var rsp = PcapUtils.FromJson<NKMPacket_LOGIN_ACK>();

            rsp.contentsTag = Config.ContentsTag;
            return rsp;
            return new NKMPacket_LOGIN_ACK()
            {
                errorCode = NKM_ERROR_CODE.NEC_OK,
                accessToken = "d87a5aa0421b4eddad1809de9cf4d69b",
                //gameServerIP = "ctsglobal-agame02.sbside.com",
                gameServerIP = Config.GameServerIP,
                gameServerPort = Config.GameServerPort,
                //gameServerPort = 20000,
                contentsVersion = "7.2.f",
                contentsTag = Config.ContentsTag,
            };
        }

        public static NKMPacket_JOIN_LOBBY_ACK kNKMPacket_JOIN_LOBBY_REQ_Handler(ISerializable req)
        {
            var rsp = PcapUtils.FromJson<NKMPacket_JOIN_LOBBY_ACK>();
            //rsp.gameData.m_NKM_GAME_TYPE = NKM_GAME_TYPE.NGT_DEV;
            Log.Information("Pcap Response Loaded!" + rsp.friendCode);

            Config.ReconnectKey = rsp.reconnectKey;
            Log.Information("Reconnecting the client! Key: " + Config.ReconnectKey);

            rsp.userData.m_companyBuffDataList = [
                    new NKMCompanyBuffData(200, 3155378975999999999),
                    new NKMCompanyBuffData(11002, 3155378975999999999),
                    new NKMCompanyBuffData(11102, 3155378975999999999),
            ];

            rsp.utcTime = DateTime.UtcNow;
            rsp.utcOffset = TimeSpan.Parse("09:00:00");

            return rsp;
        }

        public static NKMPacket_POST_LIST_ACK kNKMPacket_POST_LIST_REQ_Handler(ISerializable req)
        {
            var rsp = PcapUtils.FromJson<NKMPacket_POST_LIST_ACK>();

            return rsp;
        }

        public static NKMPacket_EQUIP_PRESET_LIST_ACK kNKMPacket_EQUIP_PRESET_LIST_REQ_Handler(ISerializable req)
        {
            var rsp = PcapUtils.FromJson<NKMPacket_EQUIP_PRESET_LIST_ACK>();

            return rsp;
        }

        public static NKMPacket_FRIEND_LIST_ACK kNKMPacket_FRIEND_LIST_REQ_Handler(ISerializable req)
        {
            return new NKMPacket_FRIEND_LIST_ACK()
            {
                errorCode = NKM_ERROR_CODE.NEC_OK,
                friendListType = NKM_FRIEND_LIST_TYPE.RECEIVE_REQUEST,
                list = []
            };
        }
        public static NKMPacket_GREETING_MESSAGE_ACK kNKMPacket_GREETING_MESSAGE_REQ_Handler(ISerializable req)
        {
            return new NKMPacket_GREETING_MESSAGE_ACK()
            {
                errorCode = NKM_ERROR_CODE.NEC_OK,
                message = ""
            };
        }

        public static NKMPacket_FAVORITES_STAGE_ACK kNKMPacket_FAVORITES_STAGE_REQ_Handler(ISerializable req)
        {
            return new NKMPacket_FAVORITES_STAGE_ACK()
            {
                errorCode = NKM_ERROR_CODE.NEC_OK,
                favoritesStage = new()
            };
        }

        public static NKMPacket_GAME_LOAD_ACK kNKMPacket_GAME_LOAD_REQ_Handler(ISerializable req)
        {
            var rsp = PcapUtils.FromJson<NKMPacket_GAME_LOAD_ACK>();

            return rsp;
        }

        public static NKMPacket_SERVER_TIME_ACK kNKMPacket_SERVER_TIME_REQ_Handler(ISerializable req)
        {
            return new NKMPacket_SERVER_TIME_ACK()
            {
                utcServerTimeTicks = DateTime.UtcNow.Ticks
            };
        }

        public static NKMPacket_REFRESH_COMPANY_BUFF_ACK kNKMPacket_REFRESH_COMPANY_BUFF_REQ_Handler(ISerializable req)
        {
            return new NKMPacket_REFRESH_COMPANY_BUFF_ACK()
            {
                errorCode = NKM_ERROR_CODE.NEC_OK,
                companyBuffDataList = [
                    new NKMCompanyBuffData(200, 3155378975999999999),
                    new NKMCompanyBuffData(11002, 3155378975999999999),
                    new NKMCompanyBuffData(11102, 3155378975999999999),
                ]
            };
        }

        public static NKMPacket_HEART_BIT_ACK kNKMPacket_HEART_BIT_REQ_Handler(ISerializable req)
        {
            return new NKMPacket_HEART_BIT_ACK()
            {
                time = DateTime.UtcNow.Ticks
            };
        }

        public static NKMPacket_RECONNECT_ACK kNKMPacket_RECONNECT_REQ_Handler(NKMPacket_RECONNECT_REQ req)
        {
            Config.ReconnectKey = req.reconnectKey;
            //NTI1MDIyMjAwNTUzODk4MTk5N3w4MDcwNDUwNTMyMjQ5NjY1NjM2fDYzM2VjMDQxNWU1YzQyNDZhMWQwMWE5Yjg3OTgzNzI4
            var rsp = PcapUtils.FromJson<NKMPacket_RECONNECT_ACK>();
            rsp.gameServerIp = Config.GameServerIP;
            rsp.gameServerPort = Config.GameServerPort;
            return rsp;
        }

        public static NKMPacket_GAME_LOAD_COMPLETE_ACK kNKMPacket_GAME_LOAD_COMPLETE_REQ_Handler(ISerializable req)
        {
            var rsp = PcapUtils.FromJson<NKMPacket_GAME_LOAD_COMPLETE_ACK>();

            return rsp;
        }

        public static NKMPacket_UI_SCEN_CHANGED_REQ kNKMPacket_UI_SCEN_CHANGED_REQ_Handler(ISerializable req)
        {
            return null;
        }

        public static NKMPacket_INFORM_MY_LOADING_PROGRESS_REQ kNKMPacket_INFORM_MY_LOADING_PROGRESS_REQ_Handler(ISerializable req)
        {
            return null;
        }

        public static NKMPacket_DEFENCE_INFO_ACK kNKMPacket_DEFENCE_INFO_REQ_Handler(ISerializable req)
        {
            var rsp = PcapUtils.FromJson<NKMPacket_DEFENCE_INFO_ACK>();

            return rsp;
        }
        

    }
    
}
