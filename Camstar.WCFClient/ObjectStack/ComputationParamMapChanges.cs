// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationParamMapChanges
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
  public class ComputationParamMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_DataPoint")]
    protected NamedSubentityRef _DataPoint;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_ComputationVariable")]
    protected NamedSubentityRef _ComputationVariable;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ComputationParamMapChanges && object.Equals((object) this._ObjectToChange, (object) ((ComputationParamMapChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((ComputationParamMapChanges) obj)._ListItemToChange) && object.Equals((object) this._DataPoint, (object) ((ComputationParamMapChanges) obj)._DataPoint)) && (object.Equals((object) this._ComputationVariable, (object) ((ComputationParamMapChanges) obj)._ComputationVariable) && object.Equals((object) this._IsFrozen, (object) ((ComputationParamMapChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedSubentityRef DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (DataPoint));
      }
    }

    public NamedSubentityRef ComputationVariable
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationVariable), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ComputationVariable));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
