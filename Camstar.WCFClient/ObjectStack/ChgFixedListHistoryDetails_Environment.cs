// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFixedListHistoryDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChgFixedListHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [Metadata("Generic Fixed.  The fixed data type is used to store a fixed point number as a floating point number in the database.  A floating point value is an approximation of a fixed point value.  Note that a \"Decimal\" type is available and should be used to store an exact numeric value with defined precision and scale.", "", false, false, true, "Fixed", 1049742, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedListHistoryDetails_Environment_NewFixedListValue")]
    protected Environment _NewFixedListValue;
    [Metadata("Generic Fixed.  The fixed data type is used to store a fixed point number as a floating point number in the database.  A floating point value is an approximation of a fixed point value.  Note that a \"Decimal\" type is available and should be used to store an exact numeric value with defined precision and scale.", "", false, false, true, "Fixed", 1049743, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedListHistoryDetails_Environment_OldFixedList")]
    protected Environment _OldFixedList;

    public Environment NewFixedListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewFixedListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewFixedListValue));
      }
    }

    public Environment OldFixedList
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldFixedList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldFixedList));
      }
    }
  }
}
