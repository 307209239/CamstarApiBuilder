// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageQualityObject_Info
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
  public class TriageQualityObject_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_QualityObjectRole")]
    protected Info _QualityObjectRole;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_Category")]
    protected Info _Category;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_QualityObject")]
    protected new Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_PriorityLevel")]
    protected Info _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_ChecklistTemplate")]
    protected Info _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_TriageSpecDetail")]
    protected Info _TriageSpecDetail;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_ProcessModelTemplate")]
    protected Info _ProcessModelTemplate;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_ProcessModelMaint")]
    protected ProcessModelMaint_Info _ProcessModelMaint;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_AssignChecklist")]
    protected AssignChecklist_Info _AssignChecklist;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_TriageComplete")]
    protected Info _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_RouteProcessModelEnabled")]
    protected Info _RouteProcessModelEnabled;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_IsCARRequiredToClose")]
    protected Info _IsCARRequiredToClose;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_RouteProcessModel")]
    protected Info _RouteProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Info_QualityObjectOwner")]
    protected Info _QualityObjectOwner;

    public Info QualityObjectRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObjectRole));
      }
    }

    public Info Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Category));
      }
    }

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

    public Info PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Info ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }

    public Info TriageSpecDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageSpecDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriageSpecDetail));
      }
    }

    public Info ProcessModelTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessModelTemplate));
      }
    }

    public ProcessModelMaint_Info ProcessModelMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelMaint), (object) value);
      }
      get
      {
        return (ProcessModelMaint_Info) this.PropertyGet(nameof (ProcessModelMaint));
      }
    }

    public AssignChecklist_Info AssignChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignChecklist), (object) value);
      }
      get
      {
        return (AssignChecklist_Info) this.PropertyGet(nameof (AssignChecklist));
      }
    }

    public Info TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Info RouteProcessModelEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteProcessModelEnabled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RouteProcessModelEnabled));
      }
    }

    public Info IsCARRequiredToClose
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCARRequiredToClose), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsCARRequiredToClose));
      }
    }

    public Info RouteProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteProcessModel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RouteProcessModel));
      }
    }

    public Info QualityObjectOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObjectOwner));
      }
    }
  }
}
