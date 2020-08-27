// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureCauseData_Environment
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
  public class FailureCauseData_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, true, "NamedObjectRef", 1051703, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Environment_Cause")]
    protected Environment _Cause;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Environment_FailurePlans")]
    [Metadata("Specifies the plan that will be executed to correct the failure or prevent it in the future.", "FailurePlanData", false, false, true, "FailurePlanData", 1052145, false, true, false, null)]
    protected FailurePlanData_Environment _FailurePlans;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051704, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Environment_RootCauseConfirmed")]
    protected Environment _RootCauseConfirmed;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseData_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

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

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment Cause
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cause), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Cause));
      }
    }

    public FailurePlanData_Environment FailurePlans
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailurePlans), (object) value);
      }
      get
      {
        return (FailurePlanData_Environment) this.PropertyGet(nameof (FailurePlans));
      }
    }

    public Environment RootCauseConfirmed
    {
      [param: In] set
      {
        this.PropertySet(nameof (RootCauseConfirmed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RootCauseConfirmed));
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
