// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserDataCollectionDefChanges_Environment
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
  public class UserDataCollectionDefChanges_Environment : DataCollectionDefChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Environment_DataPoints")]
    [Metadata("A single data item to be collected for a DataPointCollectionDef.", "DataPointChanges", false, false, false, "DataPointChanges", 1050536, false, true, false, null)]
    protected DataPointChanges_Environment _DataPoints;
    [Metadata("A type of data collection that is configured through the InSite modeling tool, rather than the Designer, and allows for upper and lower limits for numeric data points", "UserDataCollectionDef", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Environment_Base")]
    [Metadata("A new type of data collection that is configured through the InSite modeling tool, rather than the Designer, and allows for upper and lower limits for numeric data points", "UserDataCollectionDefBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Environment_DataPointLayout")]
    [Metadata("DataPointLayout", "DataPointLayoutEnum", false, true, false, "Integer", 1050890, false, false, true, null)]
    protected Environment _DataPointLayout;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Environment_ParametricDataDefType")]
    [Metadata("CDO Definition Id", "", false, false, true, "Integer", 1050394, false, false, true, null)]
    protected new Environment _ParametricDataDefType;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050535, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Environment_DisplayLimits")]
    protected Environment _DisplayLimits;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050575, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1049436, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Environment_ParametricDataDef")]
    protected new Environment _ParametricDataDef;
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Environment_IsRevOfRcd")]
    protected new Environment _IsRevOfRcd;

    public DataPointChanges_Environment DataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoints), (object) value);
      }
      get
      {
        return (DataPointChanges_Environment) this.PropertyGet(nameof (DataPoints));
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

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public Environment DataPointLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointLayout), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataPointLayout));
      }
    }

    public new Environment ParametricDataDefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDefType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParametricDataDefType));
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

    public new Environment ParametricDataDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParametricDataDef));
      }
    }

    public new Environment IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }
  }
}
