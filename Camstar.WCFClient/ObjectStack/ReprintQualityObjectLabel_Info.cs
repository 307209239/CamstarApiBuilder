// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReprintQualityObjectLabel_Info
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
  public class ReprintQualityObjectLabel_Info : ReprintLabel_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ReprintQualityObjectLabel_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ReprintQualityObjectLabel_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ReprintQualityObjectLabel_Info_LabelHistorySummary")]
    protected new Info _LabelHistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "ReprintQualityObjectLabel_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ReprintQualityObjectLabel_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ReprintQualityObjectLabel_Info_WorkCenter")]
    protected Info _WorkCenter;

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

    public Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new Info LabelHistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelHistorySummary), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelHistorySummary));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }

    public Info WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkCenter));
      }
    }
  }
}
