// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigReqTxnMap_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ContainerESigTxnMap_Info))]
  [Serializable]
  public class ESigReqTxnMap_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_Info_ESigRequirement")]
    protected Info _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_Info_AllTxns")]
    protected Info _AllTxns;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_Info_TxnId")]
    protected Info _TxnId;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_Info_TxnToUse")]
    protected Info _TxnToUse;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_Info_IsFrozen")]
    protected Info _IsFrozen;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

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

    public Info TxnToUse
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToUse), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnToUse));
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
