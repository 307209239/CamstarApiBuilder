// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PathChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ReworkPathChanges_Environment))]
  [KnownType(typeof (MovePathChanges_Environment))]
  [Serializable]
  public class PathChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("This CDO contains all the fields for a Spec Step and a Subworkflow Step.  This CDO will not be instanciated directly however.  The SpecStepChanges and SubworkflowStepChanges will be used.  The only difference is that the ObjectToChange Field type have been overridden.", "StepChanges", false, false, false, "NamedSubentityRef", 1048928, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Environment_ReturnToStep")]
    protected Environment _ReturnToStep;
    [Metadata("This CDO contains all the fields for a Spec Step and a Subworkflow Step.  This CDO will not be instanciated directly however.  The SpecStepChanges and SubworkflowStepChanges will be used.  The only difference is that the ObjectToChange Field type have been overridden.", "StepChanges", false, false, true, "NamedSubentityRef", 1048927, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Environment_FromStep")]
    protected Environment _FromStep;
    [Metadata("Changes CDO for TxnDetails.", "TxnDetailsChanges", false, false, false, "TxnDetailsChanges", 1048930, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Environment_TxnDetails")]
    protected TxnDetailsChanges_Environment _TxnDetails;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Environment_ToStep")]
    [Metadata("This CDO contains all the fields for a Spec Step and a Subworkflow Step.  This CDO will not be instanciated directly however.  The SpecStepChanges and SubworkflowStepChanges will be used.  The only difference is that the ObjectToChange Field type have been overridden.", "StepChanges", false, false, false, "NamedSubentityRef", 1048929, false, false, false, null)]
    protected Environment _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Environment_IsDefaultPath")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050280, false, false, false, "0")]
    protected Environment _IsDefaultPath;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048913, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Environment_OnDefaultRoute")]
    protected Environment _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050256, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("A Path defines an allowable (Standard) move from one Step to another within a Workflow. Each Step contains zero or more (outbound) Paths. Only one of the Paths is the default Path, all others are alternate paths. If a Step contains any Paths, one must be the default. The default Route for a Workflow is determined by traversing through the Steps, starting at the first Step (defined in the workflow), using the default Path for each.\r\n\r\nPaths are referenced by name or by Id. Path names are unique within the context of their Step.", "MovePath", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048624, false, false, false, null)]
    protected Environment _Notes;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Environment_Description")]
    protected Environment _Description;

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

    public TxnDetailsChanges_Environment TxnDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDetails), (object) value);
      }
      get
      {
        return (TxnDetailsChanges_Environment) this.PropertyGet(nameof (TxnDetails));
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
  }
}
