// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseDispositionMaint
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
  public class PhaseDispositionMaint : PhaseMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionMaint_ObjectListInquiry")]
    protected new NamedSubentityRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionMaint_ObjectChanges")]
    protected PhaseDispositionChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionMaint_Template")]
    protected new NamedObjectRef _Template;
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionMaint_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is PhaseDispositionMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((PhaseDispositionMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._ObjectChanges, (object) ((PhaseDispositionMaint) obj)._ObjectChanges) && object.Equals((object) this._Template, (object) ((PhaseDispositionMaint) obj)._Template)) && object.Equals((object) this._ObjectToChange, (object) ((PhaseDispositionMaint) obj)._ObjectToChange) && base.Equals(obj);
    }

    public new NamedSubentityRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public PhaseDispositionChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PhaseDispositionChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new NamedObjectRef Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Template));
      }
    }

    public new NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
