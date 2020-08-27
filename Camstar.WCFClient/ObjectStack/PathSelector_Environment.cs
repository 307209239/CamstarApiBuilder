// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PathSelector_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ReworkPathSelector_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MovePathSelector_Environment))]
  [Serializable]
  public class PathSelector_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Environment_Path")]
    [Metadata("A Path defines an allowable (Standard) move from one Step to another within a Workflow. Each Step contains zero or more (outbound) Paths. Only one of the Paths is the default Path, all others are alternate paths. If a Step contains any Paths, one must be the default. The default Route for a Workflow is determined by traversing through the Steps, starting at the first Step (defined in the workflow), using the default Path for each.\r\n\r\nPaths are referenced by name or by Id. Path names are unique within the context of their Step.", "Path", false, false, true, "NamedSubentityRef", 1049030, false, false, false, null)]
    protected Environment _Path;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Environment_IsEnabled")]
    [Metadata("Determines, based on Status and Effective From and Thru dates whether a CDO should be considered for processing.\r\nIf a field is not found within the CDO, a positive result is assumed.", "", false, false, true, "Boolean", 1049431, false, false, false, "0")]
    protected Environment _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Environment_Expression")]
    [Metadata("Current Value Expression string", "", false, false, true, "String", 1049630, false, false, false, null)]
    protected Environment _Expression;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Environment_EffectiveThruDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049028, false, false, false, null)]
    protected Environment _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Environment_EffectiveFromDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048744, false, false, false, null)]
    protected Environment _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Environment_EffectiveFromDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049026, false, false, false, null)]
    protected Environment _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Environment_EffectiveThruDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049027, false, false, false, null)]
    protected Environment _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    protected Environment _Notes;
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Environment_Status")]
    protected Environment _Status;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PathSelector_Environment_IsFrozen")]
    protected Environment _IsFrozen;

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

    public Environment IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsEnabled));
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
  }
}
