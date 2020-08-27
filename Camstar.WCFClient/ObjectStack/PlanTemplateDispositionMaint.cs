// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanTemplateDispositionMaint
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
  public class PlanTemplateDispositionMaint : PlanTemplateMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateDispositionMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateDispositionMaint_ObjectChanges")]
    protected PlanTemplateDispositionChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateDispositionMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateDispositionMaint_ProcessObjectTemplateDetails")]
    protected PlanTemplateDisposition _ProcessObjectTemplateDetails;

    public override bool Equals(object obj)
    {
      return obj is PlanTemplateDispositionMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((PlanTemplateDispositionMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._ObjectChanges, (object) ((PlanTemplateDispositionMaint) obj)._ObjectChanges) && object.Equals((object) this._ObjectToChange, (object) ((PlanTemplateDispositionMaint) obj)._ObjectToChange)) && object.Equals((object) this._ProcessObjectTemplateDetails, (object) ((PlanTemplateDispositionMaint) obj)._ProcessObjectTemplateDetails) && base.Equals(obj);
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

    public PlanTemplateDispositionChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PlanTemplateDispositionChanges) this.PropertyGet(nameof (ObjectChanges));
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

    public PlanTemplateDisposition ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (PlanTemplateDisposition) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }
  }
}
