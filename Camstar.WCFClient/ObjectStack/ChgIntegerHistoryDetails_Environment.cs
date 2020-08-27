// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgIntegerHistoryDetails_Environment
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
  public class ChgIntegerHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerHistoryDetails_Environment_OldIntegerValue")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049749, false, false, false, null)]
    protected Environment _OldIntegerValue;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049748, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerHistoryDetails_Environment_NewIntegerValue")]
    protected Environment _NewIntegerValue;

    public Environment OldIntegerValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldIntegerValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldIntegerValue));
      }
    }

    public Environment NewIntegerValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewIntegerValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewIntegerValue));
      }
    }
  }
}
