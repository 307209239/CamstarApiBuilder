// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryViewTxn_Info
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
  public class HistoryViewTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewTxn_Info_HistoryObjectFields")]
    protected Info _HistoryObjectFields;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewTxn_Info_HistoryView")]
    protected Info _HistoryView;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewTxn_Info_HistoryMainlineFields")]
    protected Info _HistoryMainlineFields;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewTxn_Info_HistoryObject")]
    protected Info _HistoryObject;

    public Info HistoryObjectFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryObjectFields), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryObjectFields));
      }
    }

    public Info HistoryView
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryView), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryView));
      }
    }

    public Info HistoryMainlineFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryMainlineFields), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryMainlineFields));
      }
    }

    public Info HistoryObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryObject));
      }
    }
  }
}
