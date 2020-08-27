// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRHistoryInquiry_Info
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
  public class NCRHistoryInquiry_Info : ContainerHistoryInquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRHistoryInquiry_Info_NonconformanceReport")]
    protected Info _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "NCRHistoryInquiry_Info_Container")]
    protected new Info _Container;

    public Info NonconformanceReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReport), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NonconformanceReport));
      }
    }

    public new Info Container
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
  }
}
