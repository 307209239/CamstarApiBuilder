// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigReqTxnMapChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ContainerESigTxnMapChanges_Info))]
  [KnownType(typeof (NCRESigTxnMapChanges_Info))]
  [Serializable]
  public class ESigReqTxnMapChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Info_ESigRequirement")]
    protected Info _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Info_Parent")]
    protected new Info _Parent;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Info_TxnId")]
    protected Info _TxnId;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Info_AllTxns")]
    protected Info _AllTxns;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigRequirement));
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

    public new Info Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Parent));
      }
    }

    public Info TxnId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnId));
      }
    }

    public Info AllTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllTxns), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllTxns));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
