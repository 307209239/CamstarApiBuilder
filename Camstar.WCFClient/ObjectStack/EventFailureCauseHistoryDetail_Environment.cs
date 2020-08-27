// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureCauseHistoryDetail_Environment
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
  public class EventFailureCauseHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Environment_CauseCode")]
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, true, "NamedObjectRef", 1050492, false, false, false, null)]
    protected Environment _CauseCode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Environment_FailureMode")]
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, true, "NamedObjectRef", 1051064, false, false, false, null)]
    protected Environment _FailureMode;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("EventFailureActionHistoryDtl", "EventFailureActionHistoryDtl", false, false, true, "SubentityRef", 1052968, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Environment_EventFailureActionHistoryDetails")]
    protected Environment _EventFailureActionHistoryDetails;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052941, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Environment_IsRootCause")]
    protected Environment _IsRootCause;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

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

    public Environment EventFailureActionHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionHistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventFailureActionHistoryDetails));
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

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
