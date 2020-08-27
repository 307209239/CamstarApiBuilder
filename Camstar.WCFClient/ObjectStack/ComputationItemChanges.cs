// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationItemChanges
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
  public class ComputationItemChanges : TaskItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_DataCollectionDef")]
    protected RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_ComputationParams")]
    protected ComputationParamMapChanges[] _ComputationParams;
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_Computation")]
    protected NamedObjectRef _Computation;

    public override bool Equals(object obj)
    {
      return obj is ComputationItemChanges && object.Equals((object) this._DataCollectionDef, (object) ((ComputationItemChanges) obj)._DataCollectionDef) && (this.CompareArrays((Array) this._ComputationParams, (Array) ((ComputationItemChanges) obj)._ComputationParams) && object.Equals((object) this._ListItemToChange, (object) ((ComputationItemChanges) obj)._ListItemToChange)) && (object.Equals((object) this._ObjectToChange, (object) ((ComputationItemChanges) obj)._ObjectToChange) && object.Equals((object) this._Computation, (object) ((ComputationItemChanges) obj)._Computation)) && base.Equals(obj);
    }

    public RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public ComputationParamMapChanges[] ComputationParams
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationParams), (object) value);
      }
      get
      {
        return (ComputationParamMapChanges[]) this.PropertyGet(nameof (ComputationParams));
      }
    }

    public new NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
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

    public NamedObjectRef Computation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Computation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Computation));
      }
    }
  }
}
