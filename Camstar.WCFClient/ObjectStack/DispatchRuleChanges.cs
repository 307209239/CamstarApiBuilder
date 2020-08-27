// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispatchRuleChanges
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
  public class DispatchRuleChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_DispatchDetails")]
    protected DispatchDetailChanges[] _DispatchDetails;
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_QueryType")]
    protected Enumeration<QueryTypeEnum, int> _QueryType;
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_EnforcementRange")]
    protected Primitive<int> _EnforcementRange;
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is DispatchRuleChanges && object.Equals((object) this._ObjectToChange, (object) ((DispatchRuleChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._DispatchDetails, (Array) ((DispatchRuleChanges) obj)._DispatchDetails) && object.Equals((object) this._QueryType, (object) ((DispatchRuleChanges) obj)._QueryType)) && (object.Equals((object) this._EnforcementRange, (object) ((DispatchRuleChanges) obj)._EnforcementRange) && object.Equals((object) this._Name, (object) ((DispatchRuleChanges) obj)._Name)) && base.Equals(obj);
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

    public DispatchDetailChanges[] DispatchDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchDetails), (object) value);
      }
      get
      {
        return (DispatchDetailChanges[]) this.PropertyGet(nameof (DispatchDetails));
      }
    }

    public Enumeration<QueryTypeEnum, int> QueryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryType), (object) value);
      }
      get
      {
        return (Enumeration<QueryTypeEnum, int>) this.PropertyGet(nameof (QueryType));
      }
    }

    public Primitive<int> EnforcementRange
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnforcementRange), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (EnforcementRange));
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
