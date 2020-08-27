// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureCause_Environment
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
  public class EventFailureCause_Environment : Subentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, true, "NamedObjectRef", 1050492, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_Environment_CauseCode")]
    protected Environment _CauseCode;
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_Environment_Comments")]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_Environment_EventFailureActions")]
    [Metadata("Identifies a failure action for an Event or Cause.", "EventFailureAction", false, false, true, "EventFailureAction", 1052950, false, true, false, null)]
    protected EventFailureAction_Environment _EventFailureActions;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052941, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_Environment_IsRootCause")]
    protected Environment _IsRootCause;

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

    public Environment CauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CauseCode));
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

    public EventFailureAction_Environment EventFailureActions
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActions), (object) value);
      }
      get
      {
        return (EventFailureAction_Environment) this.PropertyGet(nameof (EventFailureActions));
      }
    }

    public Environment IsRootCause
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRootCause), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRootCause));
      }
    }
  }
}
