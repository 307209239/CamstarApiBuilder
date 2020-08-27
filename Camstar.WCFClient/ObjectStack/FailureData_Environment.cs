// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureData_Environment
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
  public class FailureData_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureData_Environment_FailureSeverity")]
    [Metadata("Identifies the Severity of the Failure for an Event.", "FailureSeverity", false, false, true, "NamedObjectRef", 1051065, false, false, false, null)]
    protected Environment _FailureSeverity;
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, true, "NamedObjectRef", 1050450, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureData_Environment_FailureType")]
    protected Environment _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "FailureData_Environment_FailureMode")]
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, true, "NamedObjectRef", 1051064, false, false, false, null)]
    protected Environment _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "FailureData_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("One of the causes of the failure.", "FailureCauseData", false, false, true, "FailureCauseData", 1051709, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureData_Environment_Causes")]
    protected FailureCauseData_Environment _Causes;
    [DataMember(EmitDefaultValue = false, Name = "FailureData_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "FailureData_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
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

    public FailureCauseData_Environment Causes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Causes), (object) value);
      }
      get
      {
        return (FailureCauseData_Environment) this.PropertyGet(nameof (Causes));
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
