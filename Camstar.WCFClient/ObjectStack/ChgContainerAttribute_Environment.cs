// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgContainerAttribute_Environment
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
  public class ChgContainerAttribute_Environment : ContainerTxn_Environment
  {
    [Metadata("Child processing enum.", "ChildProcessingEnum", false, false, false, "Integer", 1050286, false, false, true, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttribute_Environment_ChildProcessingMode")]
    protected Environment _ChildProcessingMode;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050288, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttribute_Environment_RecordDetailPostHistory")]
    protected Environment _RecordDetailPostHistory;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050287, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttribute_Environment_RecordDetailPreHistory")]
    protected Environment _RecordDetailPreHistory;

    public Environment ChildProcessingMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildProcessingMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildProcessingMode));
      }
    }

    public Environment RecordDetailPostHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordDetailPostHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordDetailPostHistory));
      }
    }

    public Environment RecordDetailPreHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordDetailPreHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordDetailPreHistory));
      }
    }
  }
}
