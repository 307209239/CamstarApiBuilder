// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PathSelectorChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ReworkPathSelectorChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MovePathSelectorChanges_Environment))]
  [Serializable]
  public class PathSelectorChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Environment_ObjectToChange")]
    [Metadata("Path selectors are used to select a Path based on the value of specific data within a transaction. Each Path selector includes an expression to evaluate and a Path to select. The expression must be a Boolean expression, and is defined using the standard InSite expression syntax.\r\n\r\nA MovePathSelector is the path selector used for a normal path between steps, MovePathSelectors are evaluated by all Move-type transactions other than Rework and TransferRework.  ReworkPathSelectors are evaluated by the  Rework and TransferRework transactions. ", "MovePathSelector", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Current Value Expression string", "", false, false, false, "String", 1049630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Environment_Expression")]
    protected Environment _Expression;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Environment_Parent")]
    [Metadata("This CDO contains all the fields for a Spec Step and a Subworkflow Step.  This CDO will not be instanciated directly however.  The SpecStepChanges and SubworkflowStepChanges will be used.  The only difference is that the ObjectToChange Field type have been overridden.", "StepChanges", false, false, false, "NamedSubentityRef", 1048825, false, false, false, null)]
    protected new Environment _Parent;
    [Metadata("Changes CDO for PathBase", "PathChanges", false, false, false, "NamedSubentityRef", 1049329, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Environment_Path")]
    protected Environment _Path;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Environment_EffectiveFromDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049026, false, false, false, null)]
    protected Environment _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Environment_EffectiveFromDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048744, false, false, false, null)]
    protected Environment _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Environment_EffectiveThruDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049028, false, false, false, null)]
    protected Environment _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Environment_EffectiveThruDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049027, false, false, false, null)]
    protected Environment _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048624, false, false, false, null)]
    protected Environment _Notes;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Environment_Status")]
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, false, "Integer", 1048671, false, false, true, null)]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PathSelectorChanges_Environment_Description")]
    protected Environment _Description;

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

    public Environment Expression
    {
      [param: In] set
      {
        this.PropertySet(nameof (Expression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Expression));
      }
    }

    public new Environment Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parent));
      }
    }

    public Environment Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Path));
      }
    }

    public Environment EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveFromDateGMT));
      }
    }

    public Environment EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Environment EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveThruDateGMT));
      }
    }

    public Environment EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveThruDate));
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

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public Environment IsFrozen
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
