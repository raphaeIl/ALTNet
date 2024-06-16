using ALTNet.Common.Utils;
using ALTNet.GameServer.Protocol;
using ClientPacket.Game;
using ClientPacket.Item;
using ClientPacket.User;
using NKM;
using Serilog;

namespace ALTNet.GameServer.Handlers
{
    public static class ConnectionNotifyExtensions
    {
        public static void RESET_GROUP_COUNT_NOT(this Connection connection)
        {
            Log.Information("Sending RESET_GROUP_COUNT_NOT Notify");

            connection.Send(new NKMPacket_RESET_GROUP_COUNT_NOT()
            {
                resetCountList = []
            });
        }

        public static void RESET_POST_ARRIVE_NOT(this Connection connection, int count)
        {
            Log.Information("Sending RESET_GROUP_COUNT_NOT Notify, Count: " + count);

            connection.Send(new NKMPacket_POST_ARRIVE_NOT()
            {
                count = count
            });
        }

        public static void ATTENDANCE_NOT(this Connection connection)
        {
            Log.Information("Sending ATTENDANCE_NOT");

            connection.Send(new NKMPacket_ATTENDANCE_NOT()
            {
                errorCode = NKM.NKM_ERROR_CODE.NEC_OK,
                lastUpdateDate = DateTime.Now.Ticks,
                attendanceData = [],
                //attendanceData = [
                //    new() {
                //        IDX = 23018,
                //        Count = 9,
                //        EventEndDate = DateTime.Parse("2024-06-30T19:00:00")
                //    },
                //    new() {
                //        IDX = 30213,
                //        Count = 9,
                //        EventEndDate = DateTime.Parse("2024-07-04T19:00:00")
                //    },
                //    new() {
                //        IDX = 30315,
                //        Count = 9,
                //        EventEndDate = DateTime.Parse("2024-07-03T05:00:00")
                //    }
                //]
            });
        }

        public static void MISSION_UPDATE_NOT(this Connection connection)
        {
            Log.Information("Sending MISSION_UPDATE_NOT");

            var not = PcapUtils.FromJson<NKMPacket_MISSION_UPDATE_NOT>();

            connection.Send(not);
        }

        public static void FIERCE_SEASON_NOT(this Connection connection)
        {
            Log.Information("Sending FIERCE_SEASON_NOT Notify");

            connection.Send(new NKMPacket_FIERCE_SEASON_NOT()
            {
                fierceId = 2114
            });
        }
    }
}
