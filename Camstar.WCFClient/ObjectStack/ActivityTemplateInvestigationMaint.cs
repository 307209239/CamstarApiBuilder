// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplateInvestigationMaint
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
  public class ActivityTemplateInvestigationMaint : ActivityTemplateMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationMaint_ObjectChanges")]
    protected ActivityTemplateInvestigationChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationMaint_ProcessObjectTemplateDetails")]
    protected ActivityTemplateInvestigation _ProcessObjectTemplateDetails;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is ActivityTemplateInvestigationMaint && object.Equals((object) this._ObjectChanges, (object) ((ActivityTemplateInvestigationMaint) obj)._ObjectChanges) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ActivityTemplateInvestigationMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ProcessObjectTemplateDetails, (object) ((ActivityTemplateInvestigationMaint) obj)._ProcessObjectTemplateDetails)) && object.Equals((object) this._ObjectToChange, (object) ((ActivityTemplateInvestigationMaint) obj)._ObjectToChange) && base.Equals(obj);
    }

    public ActivityTemplateInvestigationChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityTemplateInvestigationChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public ActivityTemplateInvestigation ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ActivityTemplateInvestigation) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
