// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CloseQualityObject_Info
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
  public class CloseQualityObject_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Info_QualityObject")]
    protected new Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Info_ApprovalSheetTemplate")]
    protected Info _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Info_ApprovalSheetMap")]
    protected Info _ApprovalSheetMap;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Info_QualityResolutionCode")]
    protected Info _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Info_ResolutionAction")]
    protected Info _ResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Info_ApprovalSheetStatus")]
    protected Info _ApprovalSheetStatus;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Info_ExecuteChecklist")]
    protected ExecuteChecklist_Info _ExecuteChecklist;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Info_ApprovalRequired")]
    protected Info _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_Info_CloseDescription")]
    protected Info _CloseDescription;

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

    public Info ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public Info ApprovalSheetMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetMap), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetMap));
      }
    }

    public Info QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Info ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public Info ApprovalSheetStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetStatus));
      }
    }

    public ExecuteChecklist_Info ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Info) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public Info ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public Info CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseDescription));
      }
    }
  }
}
