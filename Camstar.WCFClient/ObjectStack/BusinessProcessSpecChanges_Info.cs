// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessProcessSpecChanges_Info
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
  public class BusinessProcessSpecChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecChanges_Info_BPSpecBizRuleTxnMap")]
    protected BPSpecBizRuleTxnMapChanges_Info _BPSpecBizRuleTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecChanges_Info_Name")]
    protected new Info _Name;

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public BPSpecBizRuleTxnMapChanges_Info BPSpecBizRuleTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (BPSpecBizRuleTxnMap), (object) value);
      }
      get
      {
        return (BPSpecBizRuleTxnMapChanges_Info) this.PropertyGet(nameof (BPSpecBizRuleTxnMap));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
