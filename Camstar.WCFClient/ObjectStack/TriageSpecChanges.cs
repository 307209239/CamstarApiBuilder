// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageSpecChanges
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
  public class TriageSpecChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecChanges_TriageSpecDetails")]
    protected TriageSpecDetailChanges[] _TriageSpecDetails;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecChanges_BusinessRules")]
    protected NamedObjectRef[] _BusinessRules;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is TriageSpecChanges && this.CompareArrays((Array) this._TriageSpecDetails, (Array) ((TriageSpecChanges) obj)._TriageSpecDetails) && (object.Equals((object) this._ObjectToChange, (object) ((TriageSpecChanges) obj)._ObjectToChange) && this.CompareArrays((Array) this._BusinessRules, (Array) ((TriageSpecChanges) obj)._BusinessRules)) && object.Equals((object) this._Name, (object) ((TriageSpecChanges) obj)._Name) && base.Equals(obj);
    }

    public TriageSpecDetailChanges[] TriageSpecDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageSpecDetails), (object) value);
      }
      get
      {
        return (TriageSpecDetailChanges[]) this.PropertyGet(nameof (TriageSpecDetails));
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

    public NamedObjectRef[] BusinessRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRules), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (BusinessRules));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
