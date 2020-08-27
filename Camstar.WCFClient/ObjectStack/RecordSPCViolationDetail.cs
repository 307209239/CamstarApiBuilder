// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordSPCViolationDetail
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
  public class RecordSPCViolationDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_FileDirectory")]
    protected Primitive<string> _FileDirectory;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_FileName")]
    protected Primitive<string> _FileName;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Recipients")]
    protected Primitive<string> _Recipients;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Message")]
    protected Primitive<string> _Message;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_SPCChartDef")]
    protected NamedObjectRef _SPCChartDef;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_EMailMessage")]
    protected NamedObjectRef _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_Violations")]
    protected SPCViolationDetail[] _Violations;
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolationDetail_SPCChartDefName")]
    protected Primitive<string> _SPCChartDefName;

    public override bool Equals(object obj)
    {
      return obj is RecordSPCViolationDetail && object.Equals((object) this._FileDirectory, (object) ((RecordSPCViolationDetail) obj)._FileDirectory) && (object.Equals((object) this._FileName, (object) ((RecordSPCViolationDetail) obj)._FileName) && object.Equals((object) this._Recipients, (object) ((RecordSPCViolationDetail) obj)._Recipients)) && (object.Equals((object) this._Message, (object) ((RecordSPCViolationDetail) obj)._Message) && object.Equals((object) this._SPCChartDef, (object) ((RecordSPCViolationDetail) obj)._SPCChartDef) && (object.Equals((object) this._EMailMessage, (object) ((RecordSPCViolationDetail) obj)._EMailMessage) && this.CompareArrays((Array) this._Violations, (Array) ((RecordSPCViolationDetail) obj)._Violations))) && object.Equals((object) this._SPCChartDefName, (object) ((RecordSPCViolationDetail) obj)._SPCChartDefName) && base.Equals(obj);
    }

    public Primitive<string> FileDirectory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileDirectory), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FileDirectory));
      }
    }

    public Primitive<string> FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FileName));
      }
    }

    public Primitive<string> Recipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (Recipients), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Recipients));
      }
    }

    public Primitive<string> Message
    {
      [param: In] set
      {
        this.PropertySet(nameof (Message), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Message));
      }
    }

    public NamedObjectRef SPCChartDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDef), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SPCChartDef));
      }
    }

    public NamedObjectRef EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EMailMessage));
      }
    }

    public SPCViolationDetail[] Violations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Violations), (object) value);
      }
      get
      {
        return (SPCViolationDetail[]) this.PropertyGet(nameof (Violations));
      }
    }

    public Primitive<string> SPCChartDefName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SPCChartDefName));
      }
    }
  }
}
