// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgIntegerListHistoryDetails_Environment
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
  public class ChgIntegerListHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049750, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerListHistoryDetails_Environment_NewIntegerListValue")]
    protected Environment _NewIntegerListValue;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049751, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerListHistoryDetails_Environment_OldIntegerListValue")]
    protected Environment _OldIntegerListValue;

    public Environment NewIntegerListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewIntegerListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewIntegerListValue));
      }
    }

    public Environment OldIntegerListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldIntegerListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldIntegerListValue));
      }
    }
  }
}
