// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordSPCViolationDetail_Environment
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
  public class RecordSPCViolationDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Environment_FileDirectory")]
    [Metadata("File directory path", "", false, false, false, "String", 1053012, false, false, false, null)]
    protected Environment _FileDirectory;
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1051133, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Environment_FileName")]
    protected Environment _FileName;
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, false, "String", 1053035, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Environment_Recipients")]
    protected Environment _Recipients;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Environment_Message")]
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, false, "String", 1051161, false, false, false, null)]
    protected Environment _Message;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Environment_SPCChartDef")]
    [Metadata("Defines SPC Charting information for a variable/chart type combination.  Includes designation for rules file, macro, display options, OCAPs and 10 user params to use during chart generation, display and OCAP processing", "SPCChartDef", false, false, false, "NamedObjectRef", 1052637, false, false, false, null)]
    protected Environment _SPCChartDef;
    [Metadata("EMail with details to be used in sending email.", "EMailMessage", false, false, false, "NamedObjectRef", 1053036, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Environment_EMailMessage")]
    protected Environment _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Environment_Violations")]
    [Metadata("The detail for the actual violation that needs to be recorded for a chart.", "SPCViolationDetail", false, false, false, "SPCViolationDetail", 1052997, false, true, false, null)]
    protected SPCViolationDetail_Environment _Violations;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Environment_SPCChartDefName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052629, false, false, false, null)]
    protected Environment _SPCChartDefName;

    public Environment FileDirectory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileDirectory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileDirectory));
      }
    }

    public Environment FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileName));
      }
    }

    public Environment Recipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (Recipients), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Recipients));
      }
    }

    public Environment Message
    {
      [param: In] set
      {
        this.PropertySet(nameof (Message), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Message));
      }
    }

    public Environment SPCChartDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SPCChartDef));
      }
    }

    public Environment EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EMailMessage));
      }
    }

    public SPCViolationDetail_Environment Violations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Violations), (object) value);
      }
      get
      {
        return (SPCViolationDetail_Environment) this.PropertyGet(nameof (Violations));
      }
    }

    public Environment SPCChartDefName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SPCChartDefName));
      }
    }
  }
}
