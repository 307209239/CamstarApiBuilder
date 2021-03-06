﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScaleFamilyMaint
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
  public class ScaleFamilyMaint : ResourceFamilyMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ScaleFamilyMaint_ObjectChanges")]
    protected ScaleFamilyChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ScaleFamilyMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ScaleFamilyMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ScaleFamilyMaint_UseUIPreference")]
    protected new Primitive<bool> _UseUIPreference;

    public override bool Equals(object obj)
    {
      return obj is ScaleFamilyMaint && object.Equals((object) this._ObjectChanges, (object) ((ScaleFamilyMaint) obj)._ObjectChanges) && (object.Equals((object) this._ObjectToChange, (object) ((ScaleFamilyMaint) obj)._ObjectToChange) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ScaleFamilyMaint) obj)._ObjectListInquiry)) && object.Equals((object) this._UseUIPreference, (object) ((ScaleFamilyMaint) obj)._UseUIPreference) && base.Equals(obj);
    }

    public ScaleFamilyChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ScaleFamilyChanges) this.PropertyGet(nameof (ObjectChanges));
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

    public new Primitive<bool> UseUIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseUIPreference), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseUIPreference));
      }
    }
  }
}
