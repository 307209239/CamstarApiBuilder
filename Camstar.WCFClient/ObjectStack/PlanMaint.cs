// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanMaint
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
  public class PlanMaint : ProcessObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "PlanMaint_ObjectChanges")]
    protected PlanChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PlanMaint_Template")]
    protected NamedObjectRef _Template;
    [DataMember(EmitDefaultValue = false, Name = "PlanMaint_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PlanMaint_ObjectListInquiry")]
    protected new NamedSubentityRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PlanMaint_ValidChildTypes")]
    protected new Primitive<string> _ValidChildTypes;

    public override bool Equals(object obj)
    {
      return obj is PlanMaint && object.Equals((object) this._ObjectChanges, (object) ((PlanMaint) obj)._ObjectChanges) && (object.Equals((object) this._Template, (object) ((PlanMaint) obj)._Template) && object.Equals((object) this._ObjectToChange, (object) ((PlanMaint) obj)._ObjectToChange)) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((PlanMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ValidChildTypes, (object) ((PlanMaint) obj)._ValidChildTypes)) && base.Equals(obj);
    }

    public PlanChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PlanChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public NamedObjectRef Template
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

    public new Primitive<string> ValidChildTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidChildTypes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ValidChildTypes));
      }
    }
  }
}
