// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseTemplateDispositionMaint
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
  public class PhaseTemplateDispositionMaint : PhaseTemplateMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateDispositionMaint_ObjectChanges")]
    protected PhaseTemplateDispositionChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateDispositionMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateDispositionMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateDispositionMaint_ProcessObjectTemplateDetails")]
    protected PhaseTemplateDisposition _ProcessObjectTemplateDetails;

    public override bool Equals(object obj)
    {
      return obj is PhaseTemplateDispositionMaint && object.Equals((object) this._ObjectChanges, (object) ((PhaseTemplateDispositionMaint) obj)._ObjectChanges) && (object.Equals((object) this._ObjectToChange, (object) ((PhaseTemplateDispositionMaint) obj)._ObjectToChange) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((PhaseTemplateDispositionMaint) obj)._ObjectListInquiry)) && object.Equals((object) this._ProcessObjectTemplateDetails, (object) ((PhaseTemplateDispositionMaint) obj)._ProcessObjectTemplateDetails) && base.Equals(obj);
    }

    public PhaseTemplateDispositionChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PhaseTemplateDispositionChanges) this.PropertyGet(nameof (ObjectChanges));
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

    public PhaseTemplateDisposition ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (PhaseTemplateDisposition) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }
  }
}
