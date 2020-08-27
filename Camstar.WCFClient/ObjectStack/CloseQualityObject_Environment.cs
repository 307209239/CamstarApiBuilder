// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CloseQualityObject_Environment
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
  public class CloseQualityObject_Environment : QualityTxn_Environment
  {
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051057, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Environment_QualityObject")]
    protected new Environment _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Environment_ApprovalSheetTemplate")]
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, true, "NamedObjectRef", 1051618, false, false, false, null)]
    protected Environment _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Environment_ApprovalSheetMap")]
    [Metadata("The ApprovalSheetMap sets up that relationship of the ResolutionAction to the ApprovalSheetTemplate.", "ApprovalSheetMap", false, false, false, "SubentityRef", 1051999, false, false, false, null)]
    protected Environment _ApprovalSheetMap;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Environment_QualityResolutionCode")]
    [Metadata("Identifies the valid resolution codes for closing an Event or CAPA.", "QualityResolutionCode", false, false, false, "NamedObjectRef", 1050494, false, false, true, null)]
    protected Environment _QualityResolutionCode;
    [Metadata("Enumeration for the Resolution Action:\r\n1 = Close", "ResolutionActionEnum", false, false, false, "Integer", 1051644, false, false, true, "1")]
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Environment_ResolutionAction")]
    protected Environment _ResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Environment_ApprovalSheetStatus")]
    [Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    protected Environment _ApprovalSheetStatus;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Environment_ExecuteChecklist")]
    [Metadata("Execute Checklist transaction is used to complete assigned checklist.", "ExecuteChecklist", false, false, false, "ExecuteChecklist", 1052417, true, false, false, null)]
    protected ExecuteChecklist_Environment _ExecuteChecklist;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051371, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Environment_ApprovalRequired")]
    protected Environment _ApprovalRequired;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Environment_CloseDescription")]
    protected Environment _CloseDescription;

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

    public Environment ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public Environment ApprovalSheetMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetMap), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetMap));
      }
    }

    public Environment QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Environment ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public Environment ApprovalSheetStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetStatus));
      }
    }

    public ExecuteChecklist_Environment ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Environment) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public Environment ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public Environment CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseDescription));
      }
    }
  }
}
