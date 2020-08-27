// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryViewTxn_Environment
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
  public class HistoryViewTxn_Environment : ShopFloor_Environment
  {
    [Metadata("Field Expression.", "", false, false, false, "String", 1052288, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewTxn_Environment_HistoryObjectFields")]
    protected Environment _HistoryObjectFields;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewTxn_Environment_HistoryView")]
    [Metadata("The History View object is used to store a user configured view of the History objects.  This object is used by the Live Manufacturing Audit Trail application.", "HistoryView", false, true, false, "NamedObjectRef", 1050022, false, false, true, null)]
    protected Environment _HistoryView;
    [Metadata("Field Expression.", "", false, false, false, "String", 1052288, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewTxn_Environment_HistoryMainlineFields")]
    protected Environment _HistoryMainlineFields;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewTxn_Environment_HistoryObject")]
    [Metadata("Generic String", "", false, false, false, "String", 16779403, false, false, true, null)]
    protected Environment _HistoryObject;

    public Environment HistoryObjectFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryObjectFields), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryObjectFields));
      }
    }

    public Environment HistoryView
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryView), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryView));
      }
    }

    public Environment HistoryMainlineFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryMainlineFields), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryMainlineFields));
      }
    }

    public Environment HistoryObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryObject));
      }
    }
  }
}
