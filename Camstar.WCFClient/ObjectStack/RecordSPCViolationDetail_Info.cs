// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordSPCViolationDetail_Info
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
  public class RecordSPCViolationDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Info_FileDirectory")]
    protected Info _FileDirectory;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Info_FileName")]
    protected Info _FileName;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Info_Recipients")]
    protected Info _Recipients;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Info_Message")]
    protected Info _Message;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Info_SPCChartDef")]
    protected Info _SPCChartDef;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Info_EMailMessage")]
    protected Info _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Info_Violations")]
    protected SPCViolationDetail_Info _Violations;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Info_SPCChartDefName")]
    protected Info _SPCChartDefName;

    public Info FileDirectory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileDirectory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FileDirectory));
      }
    }

    public Info FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FileName));
      }
    }

    public Info Recipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (Recipients), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Recipients));
      }
    }

    public Info Message
    {
      [param: In] set
      {
        this.PropertySet(nameof (Message), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Message));
      }
    }

    public Info SPCChartDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SPCChartDef));
      }
    }

    public Info EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EMailMessage));
      }
    }

    public SPCViolationDetail_Info Violations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Violations), (object) value);
      }
      get
      {
        return (SPCViolationDetail_Info) this.PropertyGet(nameof (Violations));
      }
    }

    public Info SPCChartDefName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SPCChartDefName));
      }
    }
  }
}
