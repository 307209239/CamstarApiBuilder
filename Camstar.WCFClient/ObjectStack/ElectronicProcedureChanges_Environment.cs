// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ElectronicProcedureChanges_Environment
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
  public class ElectronicProcedureChanges_Environment : ProductionProcessChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ElectronicProcedureChanges_Environment_EProcedureDetails")]
    [Metadata("Allows a TaskList to be assigned to an ElectronicProcedure in a particular sequence.", "EProcedureDetailChanges", false, true, false, "EProcedureDetailChanges", 1050522, false, true, false, null)]
    protected EProcedureDetailChanges_Environment _EProcedureDetails;
    [DataMember(EmitDefaultValue = false, Name = "ElectronicProcedureChanges_Environment_Base")]
    [Metadata("Provides the framework for executing a series of Tasks at the Spec.", "ElectronicProcedureBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("Provides the framework for executing a series of Tasks at the Spec.  An Electronic Procedure defines a set of instructions (a checklisst for performing a set of tasks), and is compose of one ore more TaskLists.", "ElectronicProcedure", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ElectronicProcedureChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ElectronicProcedureChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050501, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "ElectronicProcedureChanges_Environment_IsRevOfRcd")]
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "1")]
    protected new Environment _IsRevOfRcd;

    public EProcedureDetailChanges_Environment EProcedureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EProcedureDetails), (object) value);
      }
      get
      {
        return (EProcedureDetailChanges_Environment) this.PropertyGet(nameof (EProcedureDetails));
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
