// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeItemChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RecipeIssueItemChanges_Environment))]
  [Serializable]
  public class RecipeItemChanges_Environment : ProcessItemChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Environment_TaskType")]
    [Metadata("Enumeration for TaskType.\r\n1 = Start Process Task\r\n2 = End Process Task\r\n3 = Regular Process Task", "TaskTypeEnum", false, true, false, "Integer", 1050512, false, false, true, null)]
    protected new Environment _TaskType;
    [Metadata("Relative sequence number", "", false, true, false, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Environment_Sequence")]
    protected new Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Environment_ObjectToChange")]
    [Metadata("An abstract class of type ProcessItem. This is added on the assumption that there will be other types of Recipe Items in the future that don’t belong with EProcedures, but that don’t have a material associated with them.\r\n", "RecipeItem", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Environment_ListItemToChange")]
    [Metadata("An abstract class of type ProcessItem. This is added on the assumption that there will be other types of Recipe Items in the future that don’t belong with EProcedures, but that don’t have a material associated with them.\r\n", "RecipeItemChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Enumeration of the Task Usage\r\n1 = Container\r\n2 = Batch", "TaskUsageEnum", false, false, false, "Integer", 1051883, false, false, true, "1")]
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Environment_TaskUsage")]
    protected new Environment _TaskUsage;
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItemChanges", false, false, false, "NamedSubentityRef", 1050549, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Environment_PrerequisiteTasks")]
    protected new Environment _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050503, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, false, "NamedObjectRef", 1048646, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Environment_DocumentSet")]
    protected Environment _DocumentSet;

    public new Environment TaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskType));
      }
    }

    public new Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
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

    public new Environment TaskUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskUsage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskUsage));
      }
    }

    public new Environment PrerequisiteTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTasks), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrerequisiteTasks));
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

    public Environment DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentSet));
      }
    }
  }
}
