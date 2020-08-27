// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportLogDetail
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
  public class ExportImportLogDetail : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Status")]
    protected Enumeration<ExportImportDetailStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_ObjectName")]
    protected Primitive<string> _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_ObjectInstanceId")]
    protected Primitive<string> _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_LastUpdateTime")]
    protected Primitive<DateTime> _LastUpdateTime;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_CompletionMessage")]
    protected Primitive<string> _CompletionMessage;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_ObjectRevision")]
    protected Primitive<string> _ObjectRevision;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_ObjectTypeName")]
    protected Primitive<string> _ObjectTypeName;

    public override bool Equals(object obj)
    {
      return obj is ExportImportLogDetail && object.Equals((object) this._Status, (object) ((ExportImportLogDetail) obj)._Status) && (object.Equals((object) this._ObjectName, (object) ((ExportImportLogDetail) obj)._ObjectName) && object.Equals((object) this._ObjectInstanceId, (object) ((ExportImportLogDetail) obj)._ObjectInstanceId)) && (object.Equals((object) this._LastUpdateTime, (object) ((ExportImportLogDetail) obj)._LastUpdateTime) && object.Equals((object) this._CompletionMessage, (object) ((ExportImportLogDetail) obj)._CompletionMessage) && (object.Equals((object) this._ObjectRevision, (object) ((ExportImportLogDetail) obj)._ObjectRevision) && object.Equals((object) this._ObjectTypeName, (object) ((ExportImportLogDetail) obj)._ObjectTypeName))) && base.Equals(obj);
    }

    public Enumeration<ExportImportDetailStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<ExportImportDetailStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public Primitive<string> ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectName));
      }
    }

    public Primitive<string> ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Primitive<DateTime> LastUpdateTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdateTime), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdateTime));
      }
    }

    public Primitive<string> CompletionMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionMessage), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CompletionMessage));
      }
    }

    public Primitive<string> ObjectRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectRevision));
      }
    }

    public Primitive<string> ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectTypeName));
      }
    }
  }
}
