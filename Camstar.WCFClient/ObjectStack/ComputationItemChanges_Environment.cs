// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationItemChanges_Environment
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
  public class ComputationItemChanges_Environment : TaskItemChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_Environment_DataCollectionDef")]
    [Metadata("A type of data collection that is configured through the InSite modeling tool, rather than the Designer, and allows for upper and lower limits for numeric data points", "UserDataCollectionDef", false, false, false, "RevisionedObjectRef", 1051020, false, false, true, null)]
    protected Environment _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_Environment_ComputationParams")]
    [Metadata("Computation Parameter Specifications are used to define parameters in the Computation.", "ComputationParamMapChanges", false, false, false, "ComputationParamMapChanges", 1051026, false, true, false, null)]
    protected ComputationParamMapChanges_Environment _ComputationParams;
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_Environment_ListItemToChange")]
    [Metadata("Computation Task Item allows the user to tie Computation Parameters and UDCD Data Points.", "ComputationItemChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Computation Task Item allows the user to tie Computation Parameters and UDCD Data Points.", "ComputationItem", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Computation CDO allows to define computational expressions.", "Computation", false, true, false, "NamedObjectRef", 1051017, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_Environment_Computation")]
    protected Environment _Computation;

    public Environment DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public ComputationParamMapChanges_Environment ComputationParams
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationParams), (object) value);
      }
      get
      {
        return (ComputationParamMapChanges_Environment) this.PropertyGet(nameof (ComputationParams));
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

    public Environment Computation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Computation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Computation));
      }
    }
  }
}
