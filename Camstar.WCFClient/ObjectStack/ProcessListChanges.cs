// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessListChanges
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
  public class ProcessListChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_ReportInstruction")]
    protected Primitive<string> _ReportInstruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Instruction")]
    protected Primitive<string> _Instruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_ExecutionMode")]
    protected Enumeration<ExecutionModeEnum, int> _ExecutionMode;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_WorkstationGroup")]
    protected NamedObjectRef _WorkstationGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_PrerequisiteTaskList")]
    protected RevisionedObjectRef _PrerequisiteTaskList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Tasks")]
    protected ProcessItemChanges[] _Tasks;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Workstation")]
    protected NamedObjectRef _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_IsRevOfRcd")]
    protected new Primitive<bool> _IsRevOfRcd;

    public override bool Equals(object obj)
    {
      return obj is ProcessListChanges && object.Equals((object) this._ReportInstruction, (object) ((ProcessListChanges) obj)._ReportInstruction) && (object.Equals((object) this._Instruction, (object) ((ProcessListChanges) obj)._Instruction) && object.Equals((object) this._ExecutionMode, (object) ((ProcessListChanges) obj)._ExecutionMode)) && (object.Equals((object) this._WorkstationGroup, (object) ((ProcessListChanges) obj)._WorkstationGroup) && object.Equals((object) this._PrerequisiteTaskList, (object) ((ProcessListChanges) obj)._PrerequisiteTaskList) && (object.Equals((object) this._Base, (object) ((ProcessListChanges) obj)._Base) && this.CompareArrays((Array) this._Tasks, (Array) ((ProcessListChanges) obj)._Tasks))) && (object.Equals((object) this._ObjectToChange, (object) ((ProcessListChanges) obj)._ObjectToChange) && object.Equals((object) this._Workstation, (object) ((ProcessListChanges) obj)._Workstation) && (object.Equals((object) this._Name, (object) ((ProcessListChanges) obj)._Name) && object.Equals((object) this._IsRevOfRcd, (object) ((ProcessListChanges) obj)._IsRevOfRcd))) && base.Equals(obj);
    }

    public Primitive<string> ReportInstruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportInstruction), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReportInstruction));
      }
    }

    public Primitive<string> Instruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instruction), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Instruction));
      }
    }

    public Enumeration<ExecutionModeEnum, int> ExecutionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionMode), (object) value);
      }
      get
      {
        return (Enumeration<ExecutionModeEnum, int>) this.PropertyGet(nameof (ExecutionMode));
      }
    }

    public NamedObjectRef WorkstationGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkstationGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WorkstationGroup));
      }
    }

    public RevisionedObjectRef PrerequisiteTaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTaskList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PrerequisiteTaskList));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public ProcessItemChanges[] Tasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (Tasks), (object) value);
      }
      get
      {
        return (ProcessItemChanges[]) this.PropertyGet(nameof (Tasks));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Workstation));
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

    public new Primitive<bool> IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }
  }
}
