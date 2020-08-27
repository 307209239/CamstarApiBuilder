// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRHistoryInquiry
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
  public class NCRHistoryInquiry : ContainerHistoryInquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRHistoryInquiry_NonconformanceReport")]
    protected NamedObjectRef _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "NCRHistoryInquiry_Container")]
    protected new ContainerRef _Container;

    public override bool Equals(object obj)
    {
      return obj is NCRHistoryInquiry && object.Equals((object) this._NonconformanceReport, (object) ((NCRHistoryInquiry) obj)._NonconformanceReport) && object.Equals((object) this._Container, (object) ((NCRHistoryInquiry) obj)._Container) && base.Equals(obj);
    }

    public NamedObjectRef NonconformanceReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReport), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NonconformanceReport));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }
  }
}
