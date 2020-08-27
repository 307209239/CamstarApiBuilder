// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectTxn_Info
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
  public class ProcessObjectTxn_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Info_QualityObject")]
    protected new Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Info_DataCollectionDef")]
    protected new Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Info_ApprovalSheetDetails")]
    protected ApprovalSheetDetails_Info _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Info_ProcessObject")]
    protected Info _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Info_AvailableActions")]
    protected new Info _AvailableActions;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Info_ProcessObjectDetails")]
    protected ProcessObject_Info _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Info_ProcessESignatures")]
    protected new Info _ProcessESignatures;

    public new Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public new Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public ApprovalSheetDetails_Info ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails_Info) this.PropertyGet(nameof (ApprovalSheetDetails));
      }
    }

    public Info ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public new Info AvailableActions
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableActions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AvailableActions));
      }
    }

    public ProcessObject_Info ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ProcessObject_Info) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public new Info ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessESignatures));
      }
    }
  }
}
