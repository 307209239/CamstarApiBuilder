// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureDataChanges_Environment
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
  public class FailureDataChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Identifies the Severity of the Failure for an Event.", "FailureSeverity", false, false, false, "NamedObjectRef", 1051065, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_Environment_FailureSeverity")]
    protected Environment _FailureSeverity;
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, true, false, "NamedObjectRef", 1051064, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_Environment_FailureMode")]
    protected Environment _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_Environment_FailureType")]
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, false, "NamedObjectRef", 1050450, false, false, true, null)]
    protected Environment _FailureType;
    [Metadata("Failure data related to a quality object.", "FailureDataChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("Failure data related to a quality object.", "FailureData", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_Environment_Description")]
    protected Environment _Description;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "FailureDataChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment FailureSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureSeverity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureSeverity));
      }
    }

    public Environment FailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureMode));
      }
    }

    public Environment FailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureType));
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
