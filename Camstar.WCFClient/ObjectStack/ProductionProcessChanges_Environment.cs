// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductionProcessChanges_Environment
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
  public class ProductionProcessChanges_Environment : RevisionedObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Environment_ExecutionMode")]
    [Metadata("Enumeration for Execution Mode.\r\n1 = Sequential\r\n2 = Non-Sequential", "ExecutionModeEnum", false, true, false, "Integer", 1050515, false, false, true, "1")]
    protected Environment _ExecutionMode;
    [Metadata("Enumeration for DisplayMode.\r\n1 = DrillDown\r\n2 = Outline", "DisplayModeEnum", false, false, false, "Integer", 1050521, false, false, true, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Environment_DisplayMode")]
    protected Environment _DisplayMode;
    [Metadata("Encapsulates various types of TaskList that are to be assigned to a ProductionProcess in a particular sequence.", "ProductionProcessDetailChanges", false, true, false, "ProductionProcessDetailChanges", 1050522, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Environment_EProcedureDetails")]
    protected ProductionProcessDetailChanges_Environment _EProcedureDetails;
    [Metadata("Encapsulates logic for different types of processes.", "ProductionProcess", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Environment_Base")]
    [Metadata("Encapsulates logic for different types of processes.", "ProductionProcessBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Environment_IsRevOfRcd")]
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "0")]
    protected new Environment _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050234, false, false, false, null)]
    protected new Environment _Name;

    public Environment ExecutionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecutionMode));
      }
    }

    public Environment DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public ProductionProcessDetailChanges_Environment EProcedureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EProcedureDetails), (object) value);
      }
      get
      {
        return (ProductionProcessDetailChanges_Environment) this.PropertyGet(nameof (EProcedureDetails));
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
