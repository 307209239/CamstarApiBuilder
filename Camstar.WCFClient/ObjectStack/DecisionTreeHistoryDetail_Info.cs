// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DecisionTreeHistoryDetail_Info
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
  public class DecisionTreeHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeHistoryDetail_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeHistoryDetail_Info_Response")]
    protected Info _Response;
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeHistoryDetail_Info_Question")]
    protected Info _Question;
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public Info Response
    {
      [param: In] set
      {
        this.PropertySet(nameof (Response), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Response));
      }
    }

    public Info Question
    {
      [param: In] set
      {
        this.PropertySet(nameof (Question), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Question));
      }
    }

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

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
