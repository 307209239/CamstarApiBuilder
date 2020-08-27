// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationChanges_Environment
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
  public class ComputationChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Field Expression.", "", false, false, false, "String", 1050533, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Environment_LowerLimit")]
    protected Environment _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Environment_UpperLimit")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1050532, false, false, false, null)]
    protected Environment _UpperLimit;
    [Metadata("ComputationExpression", "", false, true, false, "String", 1051007, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Environment_ComputationExpression")]
    protected Environment _ComputationExpression;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Environment_ResultDataType")]
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, true, false, "Integer", 1051009, false, false, true, null)]
    protected Environment _ResultDataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Environment_ComputationParamSpecs")]
    [Metadata("Computation Parameter Specification", "ComputationParamSpecChanges", false, false, false, "ComputationParamSpecChanges", 1051015, false, true, true, null)]
    protected ComputationParamSpecChanges_Environment _ComputationParamSpecs;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Environment_ObjectToChange")]
    [Metadata("Computation CDO allows to define computational expressions.", "Computation", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("A unique name for an attribute of a object.", "", false, false, false, "String", 1051934, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Environment_AttributeName")]
    protected Environment _AttributeName;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052103, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Environment_MapToContainerAttribute")]
    protected Environment _MapToContainerAttribute;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Environment_DisplayLimits")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050535, false, false, false, "0")]
    protected Environment _DisplayLimits;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050544, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Environment_IsLimitOverrideAllowed")]
    protected Environment _IsLimitOverrideAllowed;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051008, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Environment_ResultName")]
    protected Environment _ResultName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051006, false, false, false, null)]
    protected new Environment _Name;

    public Environment LowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LowerLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LowerLimit));
      }
    }

    public Environment UpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpperLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UpperLimit));
      }
    }

    public Environment ComputationExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationExpression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ComputationExpression));
      }
    }

    public Environment ResultDataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultDataType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResultDataType));
      }
    }

    public ComputationParamSpecChanges_Environment ComputationParamSpecs
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationParamSpecs), (object) value);
      }
      get
      {
        return (ComputationParamSpecChanges_Environment) this.PropertyGet(nameof (ComputationParamSpecs));
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

    public Environment AttributeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttributeName));
      }
    }

    public Environment MapToContainerAttribute
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapToContainerAttribute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MapToContainerAttribute));
      }
    }

    public Environment DisplayLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayLimits), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayLimits));
      }
    }

    public Environment IsLimitOverrideAllowed
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitOverrideAllowed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsLimitOverrideAllowed));
      }
    }

    public Environment ResultName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResultName));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
