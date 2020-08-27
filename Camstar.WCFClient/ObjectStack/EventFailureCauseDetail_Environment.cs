// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureCauseDetail_Environment
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
  public class EventFailureCauseDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 1052954, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Environment_Comments")]
    protected Environment _Comments;
    [Metadata("A User Code Object Group that represents a group of NCRCauseCodes.", "NCRCauseCodeGroup", false, false, false, "NamedObjectRef", 1050493, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Environment_CauseCodeGroup")]
    protected Environment _CauseCodeGroup;
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, false, "NamedObjectRef", 1050492, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Environment_CauseCode")]
    protected Environment _CauseCode;
    [Metadata("Identifies a failure cause for an Event.", "EventFailureCause", false, false, false, "SubentityRef", 1052958, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Environment_EventFailureCause")]
    protected Environment _EventFailureCause;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Environment_EventFailureActionDetails")]
    [Metadata("Identifies a failure action for an Event or Cause.", "EventFailureActionDetail", false, false, false, "EventFailureActionDetail", 1052955, false, true, false, null)]
    protected EventFailureActionDetail_Environment _EventFailureActionDetails;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052941, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Environment_IsRootCause")]
    protected Environment _IsRootCause;

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

    public Environment CauseCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCodeGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CauseCodeGroup));
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

    public Environment EventFailureCause
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureCause), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventFailureCause));
      }
    }

    public EventFailureActionDetail_Environment EventFailureActionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionDetails), (object) value);
      }
      get
      {
        return (EventFailureActionDetail_Environment) this.PropertyGet(nameof (EventFailureActionDetails));
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
