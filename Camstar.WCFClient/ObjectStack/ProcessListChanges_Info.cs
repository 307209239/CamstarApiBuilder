// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessListChanges_Info
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
  public class ProcessListChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Info_ReportInstruction")]
    protected Info _ReportInstruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Info_Instruction")]
    protected Info _Instruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Info_ExecutionMode")]
    protected Info _ExecutionMode;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Info_WorkstationGroup")]
    protected Info _WorkstationGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Info_PrerequisiteTaskList")]
    protected Info _PrerequisiteTaskList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Info_Tasks")]
    protected ProcessItemChanges_Info _Tasks;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Info_Workstation")]
    protected Info _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Info_IsRevOfRcd")]
    protected new Info _IsRevOfRcd;

    public Info ReportInstruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportInstruction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportInstruction));
      }
    }

    public Info Instruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instruction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Instruction));
      }
    }

    public Info ExecutionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionMode));
      }
    }

    public Info WorkstationGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkstationGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkstationGroup));
      }
    }

    public Info PrerequisiteTaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTaskList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrerequisiteTaskList));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public ProcessItemChanges_Info Tasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (Tasks), (object) value);
      }
      get
      {
        return (ProcessItemChanges_Info) this.PropertyGet(nameof (Tasks));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workstation));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }
  }
}
