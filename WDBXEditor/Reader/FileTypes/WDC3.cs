using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDBXEditor.Storage;
using static WDBXEditor.Common.Constants;

namespace WDBXEditor.Reader.FileTypes
{
    public class WDC3 : WDC1
    {
        public int SectionCount; // 8.2 + is more than 1

        #region Read
        public override void ReadHeader(ref BinaryReader dbReader, string signature)
        {

        }

        public new Dictionary<int, byte[]> ReadOffsetData(BinaryReader dbReader, long pos)
        {
            return null;
        }

        public override byte[] ReadData(BinaryReader dbReader, long pos)
        {
            return null;
        }

        public override Dictionary<int, string> ReadStringTable(BinaryReader dbReader)
        {
            return null;
        }

        public override int GetStringOffset(BinaryReader dbReader, int j, uint i)
        {
            return 0;
        }
        #endregion

        #region Write
        public override void WriteHeader(BinaryWriter bw, DBEntry entry)
        {

        }

        public override void WriteData(BinaryWriter bw, DBEntry entry)
        {

        }
        #endregion

        public override void Clear()
        {

        }
    }
}
