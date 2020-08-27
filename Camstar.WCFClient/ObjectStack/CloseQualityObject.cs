// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CloseQualityObject
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
  public class CloseQualityObject : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_ApprovalSheetTemplate")]
    protected NamedObjectRef _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_ApprovalSheetMap")]
    protected SubentityRef _ApprovalSheetMap;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_QualityResolutionCode")]
    protected NamedObjectRef _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_ResolutionAction")]
    protected Enumeration<ResolutionActionEnum, int> _ResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_ApprovalSheetStatus")]
    protected Enumeration<ApprovalStatusEnum, int> _ApprovalSheetStatus;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_ExecuteChecklist")]
    protected ExecuteChecklist _ExecuteChecklist;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_ApprovalRequired")]
    protected Primitive<bool> _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObject_CloseDescription")]
    protected Primitive<string> _CloseDescription;

    public override bool Equals(object obj)
    {
      return obj is CloseQualityObject && object.Equals((object) this._QualityObject, (object) ((CloseQualityObject) obj)._QualityObject) && (object.Equals((object) this._ApprovalSheetTemplate, (object) ((CloseQualityObject) obj)._ApprovalSheetTemplate) && object.Equals((object) this._ApprovalSheetMap, (object) ((CloseQualityObject) obj)._ApprovalSheetMap)) && (object.Equals((object) this._QualityResolutionCode, (object) ((CloseQualityObject) obj)._QualityResolutionCode) && object.Equals((object) this._ResolutionAction, (object) ((CloseQualityObject) obj)._ResolutionAction) && (object.Equals((object) this._ApprovalSheetStatus, (object) ((CloseQualityObject) obj)._ApprovalSheetStatus) && object.Equals((object) this._ExecuteChecklist, (object) ((CloseQualityObject) obj)._ExecuteChecklist))) && (object.Equals((object) this._ApprovalRequired, (object) ((CloseQualityObject) obj)._ApprovalRequired) && object.Equals((object) this._CloseDescription, (object) ((CloseQualityObject) obj)._CloseDescription)) && base.Equals(obj);
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

    public NamedObjectRef ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public SubentityRef ApprovalSheetMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetMap), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ApprovalSheetMap));
      }
    }

    public NamedObjectRef QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Enumeration<ResolutionActionEnum, int> ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Enumeration<ResolutionActionEnum, int>) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public Enumeration<ApprovalStatusEnum, int> ApprovalSheetStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetStatus), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalStatusEnum, int>) this.PropertyGet(nameof (ApprovalSheetStatus));
      }
    }

    public ExecuteChecklist ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public Primitive<bool> ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public Primitive<string> CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CloseDescription));
      }
    }
  }
}
