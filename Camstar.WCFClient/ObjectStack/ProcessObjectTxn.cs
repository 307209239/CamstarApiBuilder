// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectTxn
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
  public class ProcessObjectTxn : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_DataCollectionDef")]
    protected new RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_ApprovalSheetDetails")]
    protected ApprovalSheetDetails _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_ProcessObject")]
    protected NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_AvailableActions")]
    protected Enumeration<ProcessObjectActionsEnum, int> _AvailableActions;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_ProcessObjectDetails")]
    protected Camstar.WCF.ObjectStack.ProcessObject _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_ProcessESignatures")]
    protected new Primitive<bool> _ProcessESignatures;

    public override bool Equals(object obj)
    {
      return obj is ProcessObjectTxn && object.Equals((object) this._QualityObject, (object) ((ProcessObjectTxn) obj)._QualityObject) && (object.Equals((object) this._DataCollectionDef, (object) ((ProcessObjectTxn) obj)._DataCollectionDef) && object.Equals((object) this._Comments, (object) ((ProcessObjectTxn) obj)._Comments)) && (object.Equals((object) this._ApprovalSheetDetails, (object) ((ProcessObjectTxn) obj)._ApprovalSheetDetails) && object.Equals((object) this._ProcessObject, (object) ((ProcessObjectTxn) obj)._ProcessObject) && (object.Equals((object) this._AvailableActions, (object) ((ProcessObjectTxn) obj)._AvailableActions) && object.Equals((object) this._ProcessObjectDetails, (object) ((ProcessObjectTxn) obj)._ProcessObjectDetails))) && object.Equals((object) this._ProcessESignatures, (object) ((ProcessObjectTxn) obj)._ProcessESignatures) && base.Equals(obj);
    }

    public new NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public ApprovalSheetDetails ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails) this.PropertyGet(nameof (ApprovalSheetDetails));
      }
    }

    public NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public Enumeration<ProcessObjectActionsEnum, int> AvailableActions
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableActions), (object) value);
      }
      get
      {
        return (Enumeration<ProcessObjectActionsEnum, int>) this.PropertyGet(nameof (AvailableActions));
      }
    }

    public Camstar.WCF.ObjectStack.ProcessObject ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ProcessObject) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public new Primitive<bool> ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessESignatures));
      }
    }
  }
}
