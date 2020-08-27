// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageQualityObject
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
  public class TriageQualityObject : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_QualityObjectRole")]
    protected NamedObjectRef _QualityObjectRole;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Category")]
    protected Enumeration<CategoryEnum, int> _Category;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_PriorityLevel")]
    protected NamedObjectRef _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_ChecklistTemplate")]
    protected RevisionedObjectRef _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_TriageSpecDetail")]
    protected NamedSubentityRef _TriageSpecDetail;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_ProcessModelTemplate")]
    protected RevisionedObjectRef _ProcessModelTemplate;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_ProcessModelMaint")]
    protected ProcessModelMaint _ProcessModelMaint;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_AssignChecklist")]
    protected AssignChecklist _AssignChecklist;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_TriageComplete")]
    protected Primitive<bool> _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_RouteProcessModelEnabled")]
    protected Primitive<bool> _RouteProcessModelEnabled;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_IsCARRequiredToClose")]
    protected Primitive<bool> _IsCARRequiredToClose;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_RouteProcessModel")]
    protected Primitive<bool> _RouteProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_QualityObjectOwner")]
    protected NamedObjectRef _QualityObjectOwner;

    public override bool Equals(object obj)
    {
      return obj is TriageQualityObject && object.Equals((object) this._QualityObjectRole, (object) ((TriageQualityObject) obj)._QualityObjectRole) && (object.Equals((object) this._Category, (object) ((TriageQualityObject) obj)._Category) && object.Equals((object) this._QualityObject, (object) ((TriageQualityObject) obj)._QualityObject)) && (object.Equals((object) this._PriorityLevel, (object) ((TriageQualityObject) obj)._PriorityLevel) && object.Equals((object) this._ChecklistTemplate, (object) ((TriageQualityObject) obj)._ChecklistTemplate) && (object.Equals((object) this._TriageSpecDetail, (object) ((TriageQualityObject) obj)._TriageSpecDetail) && object.Equals((object) this._ProcessModelTemplate, (object) ((TriageQualityObject) obj)._ProcessModelTemplate))) && (object.Equals((object) this._ProcessModelMaint, (object) ((TriageQualityObject) obj)._ProcessModelMaint) && object.Equals((object) this._AssignChecklist, (object) ((TriageQualityObject) obj)._AssignChecklist) && (object.Equals((object) this._TriageComplete, (object) ((TriageQualityObject) obj)._TriageComplete) && object.Equals((object) this._RouteProcessModelEnabled, (object) ((TriageQualityObject) obj)._RouteProcessModelEnabled)) && (object.Equals((object) this._IsCARRequiredToClose, (object) ((TriageQualityObject) obj)._IsCARRequiredToClose) && object.Equals((object) this._RouteProcessModel, (object) ((TriageQualityObject) obj)._RouteProcessModel) && object.Equals((object) this._QualityObjectOwner, (object) ((TriageQualityObject) obj)._QualityObjectOwner))) && base.Equals(obj);
    }

    public NamedObjectRef QualityObjectRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObjectRole));
      }
    }

    public Enumeration<CategoryEnum, int> Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Enumeration<CategoryEnum, int>) this.PropertyGet(nameof (Category));
      }
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

    public NamedObjectRef PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public RevisionedObjectRef ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }

    public NamedSubentityRef TriageSpecDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageSpecDetail), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (TriageSpecDetail));
      }
    }

    public RevisionedObjectRef ProcessModelTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelTemplate), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProcessModelTemplate));
      }
    }

    public ProcessModelMaint ProcessModelMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelMaint), (object) value);
      }
      get
      {
        return (ProcessModelMaint) this.PropertyGet(nameof (ProcessModelMaint));
      }
    }

    public AssignChecklist AssignChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignChecklist), (object) value);
      }
      get
      {
        return (AssignChecklist) this.PropertyGet(nameof (AssignChecklist));
      }
    }

    public Primitive<bool> TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Primitive<bool> RouteProcessModelEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteProcessModelEnabled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RouteProcessModelEnabled));
      }
    }

    public Primitive<bool> IsCARRequiredToClose
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCARRequiredToClose), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsCARRequiredToClose));
      }
    }

    public Primitive<bool> RouteProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteProcessModel), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RouteProcessModel));
      }
    }

    public NamedObjectRef QualityObjectOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectOwner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObjectOwner));
      }
    }
  }
}
