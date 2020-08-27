// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.InstructionItemChanges_Environment
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
  public class InstructionItemChanges_Environment : TaskItemChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "InstructionItemChanges_Environment_ObjectToChange")]
    [Metadata("A Task that instructs the user on how to perform the Task, optionally collects data for the Task, and allows the user to identify whether the Task should include a Pass/Fail status at runtime.", "InstructionItem", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "InstructionItemChanges_Environment_InstructionType")]
    [Metadata("Enumeration for the InstructionType.\r\n1 = Pass/Fail\r\n2 = Data Collection\r\n3 = Acknowledgement", "InstructionTypeEnum", false, true, false, "Integer", 1050525, false, false, true, null)]
    protected new Environment _InstructionType;
    [Metadata("A Task that instructs the user on how to perform the Task, optionally collects data for the Task, and allows the user to identify whether the Task should include a Pass/Fail status at runtime.", "InstructionItemChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "InstructionItemChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "InstructionItemChanges_Environment_DataCollectionDef")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, false, "RevisionedObjectRef", 1048868, false, false, true, null)]
    protected Environment _DataCollectionDef;

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

    public new Environment InstructionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstructionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstructionType));
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
  }
}
