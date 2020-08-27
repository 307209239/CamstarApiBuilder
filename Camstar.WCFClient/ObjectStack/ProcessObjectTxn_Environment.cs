// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectTxn_Environment
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
  public class ProcessObjectTxn_Environment : QualityTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Environment_QualityObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051057, false, false, true, null)]
    protected new Environment _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Environment_DataCollectionDef")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, false, "RevisionedObjectRef", 1048868, false, false, false, null)]
    protected new Environment _DataCollectionDef;
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Environment_Comments")]
    protected new Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Environment_ApprovalSheetDetails")]
    [Metadata("Used to update an ApprovalSheet for a parent object", "ApprovalSheetDetails", false, false, false, "ApprovalSheetDetails", 1051619, false, false, false, null)]
    protected ApprovalSheetDetails_Environment _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Environment_ProcessObject")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, false, "NamedSubentityRef", 1051396, false, false, false, null)]
    protected Environment _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Environment_AvailableActions")]
    [Metadata("View = 1\r\nEdit = 2\r\nDesignate = 4\r\nRoute = 8\r\nReassign = 16\r\nComplete = 32\r\nOpen = 64\r\nVoid = 128\r\nModify = 256\r\nEndCollaboration = 512\r\nCancelApproval = 1024\r\nReprocess = 2048\r\nEditFlag_AssigneeReadOnly = 33554432\r\nEditFlag_AllReadOnly = 67108864\r\nEditFlag_OnHold = 134217728", "ProcessObjectActionsEnum", false, false, true, "Integer", 1052079, false, false, false, null)]
    protected new Environment _AvailableActions;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, false, "ProcessObject", 1051538, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Environment_ProcessObjectDetails")]
    protected ProcessObject_Environment _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxn_Environment_ProcessESignatures")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050357, false, false, false, "1")]
    protected new Environment _ProcessESignatures;

    public new Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new Environment DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public ApprovalSheetDetails_Environment ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails_Environment) this.PropertyGet(nameof (ApprovalSheetDetails));
      }
    }

    public Environment ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public new Environment AvailableActions
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableActions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AvailableActions));
      }
    }

    public ProcessObject_Environment ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ProcessObject_Environment) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public new Environment ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessESignatures));
      }
    }
  }
}
