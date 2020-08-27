// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgObjectHistoryDetails_Info
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
  public class ChgObjectHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectHistoryDetails_Info_OldObject")]
    protected Info _OldObject;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectHistoryDetails_Info_NewObject")]
    protected Info _NewObject;

    public Info OldObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldObject));
      }
    }

    public Info NewObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewObject));
      }
    }
  }
}
