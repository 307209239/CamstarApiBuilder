// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgBooleanListHistoryDetails_Environment
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
  public class ChgBooleanListHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanListHistoryDetails_Environment_OldBooleanListValue")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049734, false, true, false, "0")]
    protected Environment _OldBooleanListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanListHistoryDetails_Environment_NewBooleanListValue")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049733, false, true, false, "0")]
    protected Environment _NewBooleanListValue;

    public Environment OldBooleanListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldBooleanListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldBooleanListValue));
      }
    }

    public Environment NewBooleanListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewBooleanListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewBooleanListValue));
      }
    }
  }
}
