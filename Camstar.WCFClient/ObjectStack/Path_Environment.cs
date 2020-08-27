// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Path_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ReworkPath_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MovePath_Environment))]
  [Serializable]
  public class Path_Environment : NamedSubentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Path_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Path_Environment_OnDefaultRoute")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048913, false, false, false, "0")]
    protected Environment _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "Path_Environment_IsDefaultPath")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050280, false, false, false, "0")]
    protected Environment _IsDefaultPath;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Path_Environment_Notes")]
    protected Environment _Notes;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, true, "NamedSubentityRef", 1048928, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Path_Environment_ReturnToStep")]
    protected Environment _ReturnToStep;
    [DataMember(EmitDefaultValue = false, Name = "Path_Environment_FromStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, true, "NamedSubentityRef", 1048927, false, false, false, null)]
    protected Environment _FromStep;
    [DataMember(EmitDefaultValue = false, Name = "Path_Environment_ToStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, true, "NamedSubentityRef", 1048929, false, false, false, null)]
    protected Environment _ToStep;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Path_Environment_IsFrozen")]
    protected new Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "Path_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050256, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "Path_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [Metadata("This is not implemented in the current version of InSite.\r\n\r\nTransaction details are used to define the type of processing (transaction type) required to \"move-down\" a Path. This is used to define, for example, whether a Move or a Combine transaction is to be used. Each Path has an associated Transaction Details entry. This is used when the Path is selected directly. Bins and other entities that can be used to select a Path also have their own associated Transaction Details (which overrides the Transaction Details for the Path).", "TxnDetails", false, false, true, "TxnDetails", 1048930, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Path_Environment_TxnDetails")]
    protected TxnDetails_Environment _TxnDetails;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment OnDefaultRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnDefaultRoute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OnDefaultRoute));
      }
    }

    public Environment IsDefaultPath
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDefaultPath), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsDefaultPath));
      }
    }

    public Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }

    public Environment ReturnToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReturnToStep));
      }
    }

    public Environment FromStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromStep));
      }
    }

    public Environment ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStep));
      }
    }

    public new Environment IsFrozen
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

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public TxnDetails_Environment TxnDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDetails), (object) value);
      }
      get
      {
        return (TxnDetails_Environment) this.PropertyGet(nameof (TxnDetails));
      }
    }
  }
}
