﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventDataHistory_Info
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
  public class UpdateEventDataHistory_Info : UpdateEventDetailsHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventDataHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventDataHistory_Info_HistoryDetails")]
    protected EventDataHistoryDetail_Info _HistoryDetails;

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

    public EventDataHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (EventDataHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }
  }
}
