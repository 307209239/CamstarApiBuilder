// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureCause_Info
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
  public class EventFailureCause_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_Info_CauseCode")]
    protected Info _CauseCode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_Info_EventFailureActions")]
    protected EventFailureAction_Info _EventFailureActions;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCause_Info_IsRootCause")]
    protected Info _IsRootCause;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info CauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CauseCode));
      }
    }

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public EventFailureAction_Info EventFailureActions
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActions), (object) value);
      }
      get
      {
        return (EventFailureAction_Info) this.PropertyGet(nameof (EventFailureActions));
      }
    }

    public Info IsRootCause
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRootCause), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRootCause));
      }
    }
  }
}
