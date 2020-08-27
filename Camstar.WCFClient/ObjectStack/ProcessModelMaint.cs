// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModelMaint
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
  public class ProcessModelMaint : ProcessObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelMaint_ParentDataObject")]
    protected NamedObjectRef _ParentDataObject;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelMaint_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelMaint_ObjectChanges")]
    protected ProcessModelChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelMaint_Template")]
    protected RevisionedObjectRef _Template;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelMaint_ObjectListInquiry")]
    protected new NamedSubentityRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelMaint_ValidChildTypes")]
    protected new Primitive<string> _ValidChildTypes;

    public override bool Equals(object obj)
    {
      return obj is ProcessModelMaint && object.Equals((object) this._ParentDataObject, (object) ((ProcessModelMaint) obj)._ParentDataObject) && (object.Equals((object) this._ObjectToChange, (object) ((ProcessModelMaint) obj)._ObjectToChange) && object.Equals((object) this._ObjectChanges, (object) ((ProcessModelMaint) obj)._ObjectChanges)) && (object.Equals((object) this._Template, (object) ((ProcessModelMaint) obj)._Template) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ProcessModelMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ValidChildTypes, (object) ((ProcessModelMaint) obj)._ValidChildTypes)) && base.Equals(obj);
    }

    public NamedObjectRef ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ParentDataObject));
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

    public ProcessModelChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessModelChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public RevisionedObjectRef Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Template));
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
