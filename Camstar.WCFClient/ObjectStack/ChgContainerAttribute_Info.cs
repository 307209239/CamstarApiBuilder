// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgContainerAttribute_Info
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
  public class ChgContainerAttribute_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttribute_Info_ChildProcessingMode")]
    protected Info _ChildProcessingMode;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttribute_Info_RecordDetailPostHistory")]
    protected Info _RecordDetailPostHistory;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttribute_Info_RecordDetailPreHistory")]
    protected Info _RecordDetailPreHistory;

    public Info ChildProcessingMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildProcessingMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildProcessingMode));
      }
    }

    public Info RecordDetailPostHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordDetailPostHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecordDetailPostHistory));
      }
    }

    public Info RecordDetailPreHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordDetailPreHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecordDetailPreHistory));
      }
    }
  }
}
