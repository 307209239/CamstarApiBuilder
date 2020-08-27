// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFixedHistoryDetails_Environment
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
  public class ChgFixedHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedHistoryDetails_Environment_OldFixedValue")]
    [Metadata("Generic Fixed.  The fixed data type is used to store a fixed point number as a floating point number in the database.  A floating point value is an approximation of a fixed point value.  Note that a \"Decimal\" type is available and should be used to store an exact numeric value with defined precision and scale.", "", false, false, true, "Fixed", 1049741, false, false, false, null)]
    protected Environment _OldFixedValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedHistoryDetails_Environment_NewFixedValue")]
    [Metadata("Generic Fixed.  The fixed data type is used to store a fixed point number as a floating point number in the database.  A floating point value is an approximation of a fixed point value.  Note that a \"Decimal\" type is available and should be used to store an exact numeric value with defined precision and scale.", "", false, false, true, "Fixed", 1049740, false, false, false, null)]
    protected Environment _NewFixedValue;

    public Environment OldFixedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldFixedValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldFixedValue));
      }
    }

    public Environment NewFixedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewFixedValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewFixedValue));
      }
    }
  }
}
