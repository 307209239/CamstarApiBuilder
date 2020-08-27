// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgBooleanHistoryDetails_Environment
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
  public class ChgBooleanHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanHistoryDetails_Environment_NewBooleanValue")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049731, false, false, false, "0")]
    protected Environment _NewBooleanValue;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049732, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanHistoryDetails_Environment_OldBooleanValue")]
    protected Environment _OldBooleanValue;

    public Environment NewBooleanValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewBooleanValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewBooleanValue));
      }
    }

    public Environment OldBooleanValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldBooleanValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldBooleanValue));
      }
    }
  }
}
