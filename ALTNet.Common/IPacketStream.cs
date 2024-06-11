using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Protocol
{
    public interface IPacketStream
    {
        void PutOrGet(ref bool data);

        void PutOrGet(ref sbyte data);

        void PutOrGet(ref byte data);

        void PutOrGet(ref short data);

        void PutOrGet(ref ushort data);

        void PutOrGet(ref int data);

        void PutOrGet(ref uint data);

        void PutOrGet(ref long data);

        void PutOrGet(ref ulong data);

        void PutOrGet(ref float data);

        void AsHalf(ref float data);

        void PutOrGet(ref double data);

        void PutOrGet(ref string data);

        void PutOrGet(ref bool[] data);

        void PutOrGet(ref int[] data);

        void PutOrGet(ref long[] data);

        void PutOrGet<T>(ref T[] data) where T : ISerializable;

        void PutOrGet(ref byte[] data);

        void PutOrGet(ref BitArray data);

        void PutOrGet(ref DateTime data);

        void PutOrGet(ref TimeSpan data);

        void PutOrGet<T>(ref T data) where T : ISerializable;

        void PutOrGetEnum<T>(ref T data) where T : Enum;

        void PutOrGetEnum<T>(ref List<T> data) where T : Enum;

        void PutOrGet(ref List<bool> data);

        void PutOrGet(ref List<byte> data);

        void PutOrGet(ref List<short> data);

        void PutOrGet(ref List<int> data);

        void PutOrGet(ref List<float> data);

        void PutOrGet(ref List<long> data);

        void PutOrGet(ref List<string> data);

        void PutOrGet<T>(ref List<T> data) where T : ISerializable;

        void PutOrGet(ref HashSet<short> data);

        void PutOrGet(ref HashSet<int> data);

        void PutOrGet(ref HashSet<string> data);

        void PutOrGet(ref HashSet<long> data);

        void PutOrGet<T>(ref HashSet<T> data) where T : ISerializable;

        void PutOrGetEnum<T>(ref HashSet<T> data) where T : Enum;

        void PutOrGet(ref Dictionary<int, int> data);

        void PutOrGet(ref Dictionary<int, float> data);

        void PutOrGet(ref Dictionary<int, long> data);

        void PutOrGet(ref Dictionary<long, int> data);

        void PutOrGet(ref Dictionary<byte, byte> data);

        void PutOrGet(ref Dictionary<byte, long> data);

        void PutOrGet(ref Dictionary<long, long> data);

        void PutOrGet(ref Dictionary<string, int> data);

        void PutOrGet(ref Dictionary<long, float> data);

        void PutOrGet<T>(ref Dictionary<byte, T> data) where T : ISerializable;

        void PutOrGet<T>(ref Dictionary<short, T> data) where T : ISerializable;

        void PutOrGet<T>(ref Dictionary<int, T> data) where T : ISerializable;

        void PutOrGet<T>(ref Dictionary<long, T> data) where T : ISerializable;

        void PutOrGet<T>(ref Dictionary<string, T> data) where T : ISerializable;
    }
}
