// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationParamMapChanges_Environment
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
  public class ComputationParamMapChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_Environment_ObjectToChange")]
    [Metadata("Computation Parameter Map is used to define the link between Data Point and Computation Parameter Spec", "ComputationParamMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_Environment_ListItemToChange")]
    [Metadata("Computation Parameter Specifications are used to define parameters in the Computation.", "ComputationParamMapChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("A single data item to be collected for a DataPointCollectionDef.", "DataPoint", false, true, false, "NamedSubentityRef", 1050537, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_Environment_DataPoint")]
    protected Environment _DataPoint;
    [Metadata("Computation Parameter Specifications are used to define parameters in the Computation.", "ComputationParamSpec", false, true, false, "NamedSubentityRef", 1051018, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_Environment_ComputationVariable")]
    protected Environment _ComputationVariable;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataPoint));
      }
    }

    public Environment ComputationVariable
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationVariable), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ComputationVariable));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
