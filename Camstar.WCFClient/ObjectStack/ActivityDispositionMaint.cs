// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityDispositionMaint
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
  public class ActivityDispositionMaint : ActivityMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionMaint_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionMaint_ObjectListInquiry")]
    protected new NamedSubentityRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionMaint_ObjectChanges")]
    protected ActivityDispositionChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionMaint_Template")]
    protected new NamedObjectRef _Template;

    public override bool Equals(object obj)
    {
      return obj is ActivityDispositionMaint && object.Equals((object) this._ObjectToChange, (object) ((ActivityDispositionMaint) obj)._ObjectToChange) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ActivityDispositionMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ObjectChanges, (object) ((ActivityDispositionMaint) obj)._ObjectChanges)) && object.Equals((object) this._Template, (object) ((ActivityDispositionMaint) obj)._Template) && base.Equals(obj);
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

    public ActivityDispositionChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityDispositionChanges) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
